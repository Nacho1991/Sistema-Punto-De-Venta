using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data; // manejo de datos
using System.Data.OleDb;
using System.Xml;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Collections;

namespace AccesoDatos
{
    public class AccesoDatosMySql : AccesoDatos
    {
        private Boolean isError = false;        //Una bandera, para determinar si existe o no algun error
        private String errorDescripcion;        //Almacena la descripcion del error        
        private string usuario;
        private string contrasena;
        private string bd;
        private string servidor;
        public MySqlConnection conexion;       //Objeto de tipo conexion, para establecer comunicacion con la BD
        private MySqlTransaction transaccion;  //Objeto de tipo transaccion de base de datos, para iniciar, procesar y cerrar transacciones
        private bool hayTransaccion;            //Bandera que determina si hay una transaccion activa
        private string schema;                  //Almacena el esquema con el cual se trabaja en la base de datos, para devolverlo mediante un metodo get
        string tipoconexion = "1";

        static int instancias = 0;              //Contador de cuanta veces se ha instanciado la clase, para evitar que se instancie mas de una vez
        // Constructor
        public AccesoDatosMySql(string ConnectionString)
        {
            limpiarEstado();

            conexion = new MySqlConnection(ConnectionString);
            instancias += 1;

            // no puede haber + de una instancia de la clase
            if (instancias > 1)
                return;
            //ok  esta  en reapaldo 
            try
            {
                conexion.Open();
            }
            catch (MySqlException error)
            {
                instancias = 0;
                ProcesarExcepcion(error);
            }

        }
        // Indica el estado de la persistencia
        public override Boolean estado()
        {
            limpiarEstado();

            String mensaje = "";

            // estado dela conexión
            switch (conexion.State)
            {
                case System.Data.ConnectionState.Broken:
                    mensaje = "0010|| ||La conexión con la base de datos fue interrumpida.";
                    break;
                case System.Data.ConnectionState.Closed:
                    mensaje = "0011|| ||La conexión con la base de datos fue cerrada o no pudo ser establecida.";
                    break;
                case System.Data.ConnectionState.Connecting:
                    mensaje = "0012|| ||Conectandose.";
                    break;
                case System.Data.ConnectionState.Executing:
                    mensaje = "0013|| ||Ejecutando.";
                    break;
                case System.Data.ConnectionState.Fetching:
                    mensaje = "0014|| ||Extrayendo.";
                    break;
                case System.Data.ConnectionState.Open:
                    mensaje = "0015|| ||Abierta.";
                    break;
            }

            // cargar la propiedad con el estado de la conexion
            ErrorDescripcion = mensaje;

            if ((conexion.State == ConnectionState.Open) ||
                  (conexion.State == ConnectionState.Executing) ||
                  (conexion.State == ConnectionState.Fetching))
                return true;
            else
                return false;
        }
        // destructor
        ~AccesoDatosMySql()
        {
        }
        //
        public override void conectar()
        {
            try
            {
                if (!(conexion.State == ConnectionState.Open))
                {
                    conexion.Open();
                    instancias = 1;
                }
            }
            catch (MySqlException error)
            {
                ProcesarExcepcion(error);
            }
            catch
            {

            }
        }
        
        public override void desconectar()
        {
            try
            {
                conexion.Close();
                instancias = 0;
            }
            catch (MySqlException error)
            {
                ProcesarExcepcion(error);
            }
        }

        //Manipulacion de select
        public override DataSet ejecutarConsultaSQL(String pSql)
        {
            limpiarEstado();

            MySqlDataAdapter oDataAdapter = new MySqlDataAdapter(pSql, conexion);
            DataSet oDataSet = new DataSet();
            if (this.hayTransaccion) 
            {
                oDataAdapter.SelectCommand.Transaction = this.transaccion;
            }
            // capturar la excepción
            try
            {
                oDataAdapter.Fill(oDataSet);
            }
            catch (MySqlException error)
            {
                ProcesarExcepcion(error);

            }

            return oDataSet;
        }
        
        public override DataSet ejecutarConsultaSQL(String pSql, String pnTabla, Object[] myParamArray)
        {
            limpiarEstado();

            MySqlCommand cmd = new MySqlCommand(pSql, conexion);

            cmd.CommandType = CommandType.Text;

            for (int j = 0; j < myParamArray.Length; j++)
            {
                cmd.Parameters.Add(((MySqlParameter)myParamArray[j]));
            }


            MySqlDataAdapter oDataAdapter = new MySqlDataAdapter(cmd);
            DataSet oDataSet = new DataSet();
            if (this.hayTransaccion)
            {
                oDataAdapter.SelectCommand.Transaction = this.transaccion;
            }
            // capturar la excepción
            try
            {
                oDataAdapter.Fill(oDataSet, pnTabla);
            }
            catch (MySqlException error)
            {
                ProcesarExcepcion(error);
            }

            return oDataSet;
        }
        public DataSet ejecutarConsultaSQL(String sql, IEnumerable parametros)
        {
            this.limpiarEstado();
            var oDataSet = new DataSet();
            try
            {
                var oDataAdapter = new MySqlDataAdapter(sql, conexion);
                var cmd = new MySqlCommand(sql, conexion);
                foreach (MySqlParameter parametro in parametros)
                {
                    cmd.Parameters.Add(parametro);
                }
                oDataAdapter.SelectCommand = cmd;

                if (this.hayTransaccion)
                {
                    oDataAdapter.SelectCommand.Transaction = this.transaccion;
                }
                oDataAdapter.Fill(oDataSet);
            }
            catch (Exception error)
            {
                IsError = true;
                ErrorDescripcion = "Error en ejecutarConsultaSQL \n";
                ErrorDescripcion += error.Message;
            }
            return oDataSet;
        }
        public DataTable ejecutarTableSQL(String pSql)
        {
            limpiarEstado();

            MySqlDataAdapter oDataAdapter = new MySqlDataAdapter(pSql, conexion);
            DataTable oDataTable = new DataTable();

            // capturar la excepción
            try
            {
                oDataAdapter.Fill(oDataTable);
            }
            catch (MySqlException error)
            {
                ProcesarExcepcion(error);
            }

            return oDataTable;
        }
        public override DataSet ejecutarConsultaSQL(String pSql, String pnTabla)
         {
            limpiarEstado();


            MySqlDataAdapter oDataAdapter = new MySqlDataAdapter(pSql, conexion);
            DataSet oDataSet = new DataSet();

            // capturar la excepción
            try
            {
                oDataAdapter.Fill(oDataSet, pnTabla);
            }
            catch (MySqlException error)
            {
                ProcesarExcepcion(error);
            }

            return oDataSet;
        }
        // Método para manipular Insert, Update, Delete
        public override void ejecutarSQL(String pSql)
        {
            limpiarEstado();

            // Definicion de Command
            MySqlCommand cmd = null;

            try
            {
                cmd = new MySqlCommand(pSql, conexion);

                if (this.hayTransaccion)
                {
                    cmd.Transaction = this.transaccion;
                }

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException error)
            {
                ProcesarExcepcion(error);
            }

        }
        // Método para manipular Insert, Update, Delete con identidad
        public override void ejecutarSQL(string pSql, Object[] myParamArray, ref string pNumero)
        {
            limpiarEstado();

            try
            {
                MySqlCommand cmd = new MySqlCommand(pSql, conexion);
                cmd.CommandType = CommandType.Text;
                for (int j = 0; j < myParamArray.Length; j++)
                {
                    cmd.Parameters.Add((MySqlParameter)myParamArray[j]);
                }

                if (this.hayTransaccion)
                {
                    cmd.Transaction = this.transaccion;
                }

                pNumero = "";
                pNumero = cmd.ExecuteScalar().ToString();
            }
            catch (MySqlException error)
            {
                ProcesarExcepcion(error);
            }
        }
        //Método para manipular Insert, Update pero con parametros
        public override void ejecutarSQL(string sql, Object[] myParamArray)
        {
            limpiarEstado();

            try
            {

                MySqlCommand cmd = new MySqlCommand(sql, conexion);
                cmd.CommandType = CommandType.Text;
                for (int j = 0; j < myParamArray.Length; j++)
                {
                    cmd.Parameters.Add((MySqlParameter)myParamArray[j]);
                }

                if (this.hayTransaccion)
                {
                    cmd.Transaction = this.transaccion;
                }

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException error)
            {
                ProcesarExcepcion(error);
            }

        }

        /// <summary>
        /// obtiene el siguiente valor para el sequence especificado
        /// </summary>
        /// <param name="pNombre">código del sequence</param>
        public override int NextValSequence(string pNombre) 
        {
            int valor = 0;
            limpiarEstado();
            try
            {
                DataSet dsetDatos = new DataSet();
                dsetDatos = this.ejecutarConsultaSQL("select " + pNombre + ".NEXTVAL from dual ");
                valor = Convert.ToInt32(dsetDatos.Tables[0].Rows[0][0].ToString());
            }
            catch (MySqlException error)
            {
                ProcesarExcepcion(error);
            }
            return valor;
        }

        //Metodos de transaccion
        public override void iniciarTransaccion()
        {
            if (this.hayTransaccion == false)
            {
                this.transaccion = this.conexion.BeginTransaction();
                this.hayTransaccion = true;
            }
        }
        //
        public override void commitTransaccion()
        {
            if (this.hayTransaccion)
            {
                this.transaccion.Commit();
                this.hayTransaccion = false;
            }
        }
        //
        public override void rollbackTransaccion()
        {
            if (this.hayTransaccion)
            {
                this.transaccion.Rollback();
                this.hayTransaccion = false;
            }
        }

        //
        //
        public override DateTime ObtieneFecha()
        {

            string sql = "select getdate()";

            DataSet dsetDatos = new DataSet();
            dsetDatos = ejecutarConsultaSQL(sql, "Fecha");

            return Convert.ToDateTime(dsetDatos.Tables[0].Rows[0][0].ToString());
        }
        //
        // Metodos de Set & Get

        public override string Usuario
        {
            get { return usuario; }
        }

        public override string Servidor
        {
            get { return servidor; }
        }

        public override string DB
        {
            get { return bd; }
        }

        public override string Contrasena
        {
            get { return contrasena; }
        }

        public override string Puerto
        {
            get { return ""; }
        }
        
        public override Boolean IsError
        {
            set { isError = value; }
            get { return isError; }
        }
        //
        public override String ErrorDescripcion
        {
            set { errorDescripcion = value; }
            get { return errorDescripcion; }
        }
        //
        public override string Schema
        {
            get { return this.schema; }
        }
        //
        public override string TipoConexion
        {
            get { return this.tipoconexion; }
        }

        //Elimina el estado de error de la clase.
        public override void limpiarEstado()
        {
            this.errorDescripcion = "";
            this.isError = false;
        }

        private void ProcesarExcepcion(MySqlException pExcepcion)
        {
            IsError = true;
            
                ErrorDescripcion += pExcepcion.ErrorCode + "||";
                ErrorDescripcion += pExcepcion.StackTrace + "||";
                ErrorDescripcion += pExcepcion.Message;
        }


        private DataSet ejecutarConsultaSQL2(String pSql)
        {
            MySqlDataAdapter oDataAdapter = new MySqlDataAdapter(pSql, conexion);
            DataSet oDataSet = new DataSet();
            if (this.hayTransaccion)
            {
                oDataAdapter.SelectCommand.Transaction = this.transaccion;
            }
            // capturar la excepción
            try
            {
                oDataAdapter.Fill(oDataSet);
            }
            catch (MySqlException error)
            {
                ProcesarExcepcion(error);

            }

            return oDataSet;
        }

        private void ejecutarSQL2(String pSql)
        {
            // Definicion de Command
            MySqlCommand cmd = null;

            try
            {
                cmd = new MySqlCommand(pSql, conexion);

                if (this.hayTransaccion)
                {
                    cmd.Transaction = this.transaccion;
                }

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException error)
            {
                ProcesarExcepcion(error);
            }

        }

        public override string ejecutarSQLReturning(string pSql, Object[] myParamArray, string retparameter)
        {
            limpiarEstado();

            try
            {
                MySqlCommand cmd = new MySqlCommand(pSql, conexion);
                cmd.CommandType = CommandType.Text;
                for (int j = 0; j < myParamArray.Length; j++)
                {
                    cmd.Parameters.Add((MySqlParameter)myParamArray[j]);
                }

                if (this.hayTransaccion)
                {
                    cmd.Transaction = this.transaccion;
                }

                cmd.ExecuteNonQuery();
                return cmd.Parameters["" + retparameter].Value.ToString();
            }
            catch (MySqlException error)
            {
                ProcesarExcepcion(error);
                return "";
            }
        }
    }//finaliza clase
}//finaliza namespace
