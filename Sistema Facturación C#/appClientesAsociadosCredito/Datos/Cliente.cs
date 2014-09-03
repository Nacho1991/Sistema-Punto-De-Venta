using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using System.Data;
using MySql.Data.MySqlClient;

namespace Datos
{
    class Cliente
    {
        AccesoDatosMySql cnx;
        bool isError;
        string errorDescripcion;
        public Cliente(AccesoDatosMySql pCnx) 
        {
            cnx = pCnx;
            isError = false;
            errorDescripcion = "";
        }
        public DataSet ObtenerClientes()
        {
            DataSet retorno = new DataSet();
            string sql = "SELECT * FROM Cliente_Credito";
            retorno = cnx.ejecutarConsultaSQL(sql);
            isError = cnx.IsError;
            return retorno;
        }
        public DataSet FiltrarDatos(string pFiltro, string pTabla)
        {
            DataSet retorno = new DataSet();
            string sql = "SELECT * FROM Cliente_Credito WHERE" + " " + pTabla + " LIKE '%" + pFiltro + "%'";
            retorno = cnx.ejecutarConsultaSQL(sql);
            isError = cnx.IsError;
            return retorno;
        }
        public void asignarCreditio(string pCedula,string pRegistro,string pMontoAcreditado,string pMontoActual,string pPeriodoPago,DateTime pFechaIncioCredito) 
        {
            string sql = "INSERT INTO Area_Credito(Id_Registro,Cliente_Credito_Id_Cedula,Monto_Acreditado,Monto_Actual,Periodo_Pago,Fecha_Inicio_Credito)" +
                         " VALUES(@Id_Registro,@Cliente_Credito_Id_Cedula,@Monto_Acreditado,@Monto_Actual,@Periodo_Pago,@Fecha_Inicio_Credito)";//consulta basica para insertar valores a la base de datos parámetrizada
            MySqlParameter[] parametros = new MySqlParameter[6];
            parametros[0] = new MySqlParameter();
            parametros[0].MySqlDbType = MySqlDbType.VarChar;
            parametros[0].ParameterName = "@Id_Registro";
            parametros[0].Value = pRegistro;

            parametros[1] = new MySqlParameter();
            parametros[1].MySqlDbType = MySqlDbType.VarChar;
            parametros[1].ParameterName = "@Cliente_Credito_Id_Cedula";
            parametros[1].Value = pCedula;

            parametros[2] = new MySqlParameter();
            parametros[2].MySqlDbType = MySqlDbType.VarChar;
            parametros[2].ParameterName = "@Monto_Acreditado";
            parametros[2].Value = pMontoAcreditado;

            parametros[3] = new MySqlParameter();
            parametros[3].MySqlDbType = MySqlDbType.VarChar;
            parametros[3].ParameterName = "@Monto_Actual";
            parametros[3].Value = pMontoActual;

            parametros[4] = new MySqlParameter();
            parametros[4].MySqlDbType = MySqlDbType.VarChar;
            parametros[4].ParameterName = "@Periodo_Pago";
            parametros[4].Value = pPeriodoPago;

            parametros[5] = new MySqlParameter();
            parametros[5].MySqlDbType = MySqlDbType.DateTime;
            parametros[5].ParameterName = "@Fecha_Inicio_Credito";
            parametros[5].Value = pFechaIncioCredito;

            this.cnx.ejecutarConsultaSQL(sql, "Area_Credito", parametros);
            this.isError = this.cnx.IsError;
            this.errorDescripcion = this.cnx.ErrorDescripcion;
        }
        public void agregarClienteCredito(string pCedula, string pNombre, string pApellido, string pTipoCliente, string pTelefono, string pCelular, string pDireccion,string pCreadoPor,string pEstadoCliente) //se recibe por parámetros los valores de NuevoUsuario
        {
            string sql = "INSERT INTO Cliente_Credito(id_cedula,Tipo_Cliente_Id_Tipo_Cliente,Estado_Cliente,Nombre,Apellidos,telefono,celular,direccion,Fcha_Creacion,Fecha_Modificacion,Modificado_Por,Creado_Por)" +
                         " VALUES(@id_cedula,@Tipo_Cliente_Id_Tipo_Cliente,@Estado_Cliente,@Nombre,@Apellidos,@telefono,@celular,@direccion,@Fcha_Creacion,@Fecha_Modificacion,@Modificado_Por,@Creado_Por)";//consulta basica para insertar valores a la base de datos parámetrizada
            MySqlParameter[] parametros = new MySqlParameter[12];

            parametros[0] = new MySqlParameter();
            parametros[0].MySqlDbType = MySqlDbType.VarChar;
            parametros[0].ParameterName = "@id_cedula";
            parametros[0].Value = pCedula;

            parametros[1] = new MySqlParameter();
            parametros[1].MySqlDbType = MySqlDbType.VarChar;
            parametros[1].ParameterName = "@Nombre";
            parametros[1].Value = pNombre;

            parametros[2] = new MySqlParameter();
            parametros[2].MySqlDbType = MySqlDbType.VarChar;
            parametros[2].ParameterName = "@apellidos";
            parametros[2].Value = pApellido;

            parametros[3] = new MySqlParameter();
            parametros[3].MySqlDbType = MySqlDbType.VarChar;
            parametros[3].ParameterName = "@Tipo_Cliente_Id_Tipo_Cliente";
            parametros[3].Value = pTipoCliente;

            parametros[4] = new MySqlParameter();
            parametros[4].MySqlDbType = MySqlDbType.VarChar;
            parametros[4].ParameterName = "@telefono";
            parametros[4].Value = pTelefono;

            parametros[5] = new MySqlParameter();
            parametros[5].MySqlDbType = MySqlDbType.VarChar;
            parametros[5].ParameterName = "@celular";
            parametros[5].Value = pCelular;

            parametros[6] = new MySqlParameter();
            parametros[6].MySqlDbType = MySqlDbType.VarChar;
            parametros[6].ParameterName = "@direccion";
            parametros[6].Value = pDireccion;

            parametros[7] = new MySqlParameter();
            parametros[7].MySqlDbType = MySqlDbType.DateTime;
            parametros[7].ParameterName = "@Fcha_Creacion";
            parametros[7].Value = DateTime.Now;

            parametros[8] = new MySqlParameter();
            parametros[8].MySqlDbType = MySqlDbType.DateTime;
            parametros[8].ParameterName = "@fecha_modificacion";
            parametros[8].Value = DateTime.Now;

            parametros[9] = new MySqlParameter();
            parametros[9].MySqlDbType = MySqlDbType.VarChar;
            parametros[9].ParameterName = "@Modificado_Por";
            parametros[9].Value = null;

            parametros[10] = new MySqlParameter();
            parametros[10].MySqlDbType = MySqlDbType.VarChar;
            parametros[10].ParameterName = "@Creado_Por";
            parametros[10].Value = pCreadoPor;

            parametros[11] = new MySqlParameter();
            parametros[11].MySqlDbType = MySqlDbType.VarChar;
            parametros[11].ParameterName = "@Estado_Cliente";
            parametros[11].Value = pEstadoCliente;

            this.cnx.ejecutarConsultaSQL(sql, "Cliente_Credito", parametros);
            this.isError = this.cnx.IsError;
            this.errorDescripcion = this.cnx.ErrorDescripcion;
        }
        public void borrarCliente(string pIdCliente)
        {

            string sql = "DELETE FROM Cliente_Credito WHERE id_cedula = @id_cedula";//consulta delete hacia la base de datos por medio de la llave primaria
            MySqlParameter[] parametro = new MySqlParameter[1];

            parametro[0] = new MySqlParameter();
            parametro[0].MySqlDbType = MySqlDbType.VarChar;
            parametro[0].ParameterName = "@id_cedula";
            parametro[0].Value = pIdCliente;
            this.cnx.ejecutarConsultaSQL(sql, "Cliente_Credito", parametro);
            if (this.cnx.IsError)
            {
                isError = true;
                errorDescripcion = cnx.ErrorDescripcion;
            }
        }
        public bool IsError
        {
            get { return isError; }
            set { isError = value; }
        }
        public string ErrorDescripcion
        {
            get { return errorDescripcion; }
            set { errorDescripcion = value; }
        }
    }
}
