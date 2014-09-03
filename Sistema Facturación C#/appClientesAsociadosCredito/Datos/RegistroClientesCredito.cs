using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using System.Data;
using AccesoDatos;

namespace Datos

{
   public class RegistroClientesCredito
    {
       //Atributos
       AccesoDatosMySql cnx;
        private bool error = false;
        private string errorDescripcion;

       //Constructor
        public RegistroClientesCredito(AccesoDatosMySql pCnx) 
        {
            errorDescripcion = "";
            this.cnx = pCnx;
            error = false;
        }

       //Obtiene la informacion de la base de datos de todos los clientes registrados en el area de crédito
        public DataSet ObtenerRegistroClientesCredito()
        {
            DataSet retorno = new DataSet();
            string sql = "Select * from clientesCreditoAsociados";
            retorno = cnx.ejecutarConsultaSQL(sql);
            return retorno;
        }

        public void actualizadorMontoCompra(string pMonto, string pID_Tabla) 
        {
            string sql = "Update Factura set   monto = :monto where id_Factura  = :id_Factura";
            //mismo procedimiento que el metódo agregar ,lo que cambia es la consulta update para editar sobre los elementos existentes ,con valores parámetrizados
            OracleParameter[] Parametros = new OracleParameter[10];

            Parametros[0] = new OracleParameter();
            Parametros[0].OracleType = OracleType.VarChar;
            Parametros[0].ParameterName = ":monto";
            Parametros[0].Value = pMonto;

            Parametros[1] = new OracleParameter();
            Parametros[1].OracleType = OracleType.VarChar;
            Parametros[1].ParameterName = ":id_Factura";
            Parametros[1].Value = pID_Tabla;

            this.cnx.ejecutarSQL(sql, Parametros);
            this.error = this.cnx.IsError;
            this.errorDescripcion = this.cnx.ErrorDescripcion;
        }


       //Agrega a un nuevo asociado o cliente en la base de datos despues de comprobar de que no existe en la base de datos
        public void agregarAsociadoCredito(string pCodigoCliente,string estado,string pCcedula,string pNombre, string pPrimerApellido, string pSegundoApellido, string pDireccion, string pTelefono, string pLimiteCredito, string pCantidadCreditoActual,DateTime pFechaModificacion,string pModificadoPor, string pCreadoPor) //se recibe por parámetros los valores de NuevoUsuario
        {
            string sql = "Insert into clientesCreditoAsociados(id_CodigoCliente,cedulaCliente,estadoCliente,nombreCliente,primerApellidoCliente,segundoApellidoCliente,direccionCliente,telefonoCliente,limiteCreditoCliente,cantidadCreditoActualCliente,fechaCreacion,fechaModificacion,modificadoPor,creadoPor)" +
                " Values(:id_CodigoCliente,:cedulaCliente,:estadoCliente,:nombreCliente,:primerApellidoCliente,:segundoApellidoCliente,:direccionCliente,:telefonoCliente,:limiteCreditoCliente,:cantidadCreditoActualCliente,:fechaCreacion,:fechaModificacion,:modificadoPor,:creadoPor)";//consulta basica para insertar valores a la base de datos parámetrizada
            OracleParameter[] parametros = new OracleParameter[14];
            parametros[0] = new OracleParameter();
            parametros[0].OracleType = OracleType.VarChar;
            parametros[0].ParameterName = ":id_CodigoCliente";
            parametros[0].Value = pCodigoCliente;

            parametros[1] = new OracleParameter();
            parametros[1].OracleType = OracleType.VarChar;
            parametros[1].ParameterName = ":cedulaCliente";
            parametros[1].Value = pCcedula;

            parametros[2] = new OracleParameter();
            parametros[2].OracleType = OracleType.VarChar;
            parametros[2].ParameterName = ":estadoCliente";
            parametros[2].Value = estado;

            parametros[3] = new OracleParameter();
            parametros[3].OracleType = OracleType.VarChar;
            parametros[3].ParameterName = ":nombreCliente";
            parametros[3].Value = pNombre;

            parametros[4] = new OracleParameter();
            parametros[4].OracleType = OracleType.VarChar;
            parametros[4].ParameterName = ":primerApellidoCliente";
            parametros[4].Value = pPrimerApellido;

            parametros[5] = new OracleParameter();
            parametros[5].OracleType = OracleType.VarChar;
            parametros[5].ParameterName = ":segundoApellidoCliente";
            parametros[5].Value = pSegundoApellido;

            parametros[6] = new OracleParameter();
            parametros[6].OracleType = OracleType.VarChar;
            parametros[6].ParameterName = ":direccionCliente";
            parametros[6].Value = pDireccion;

            parametros[7] = new OracleParameter();
            parametros[7].OracleType = OracleType.VarChar;
            parametros[7].ParameterName = ":telefonoCliente";
            parametros[7].Value = pTelefono;

            parametros[8] = new OracleParameter();
            parametros[8].OracleType = OracleType.VarChar;
            parametros[8].ParameterName = ":limiteCreditoCliente";
            parametros[8].Value = pLimiteCredito;

            parametros[9] = new OracleParameter();
            parametros[9].OracleType = OracleType.VarChar;
            parametros[9].ParameterName = ":cantidadCreditoActualCliente";
            parametros[9].Value = pCantidadCreditoActual;

            parametros[10] = new OracleParameter();
            parametros[10].OracleType = OracleType.DateTime;
            parametros[10].ParameterName = ":fechaCreacion";
            parametros[10].Value = DateTime.Now;

            parametros[11] = new OracleParameter();
            parametros[11].OracleType = OracleType.DateTime;
            parametros[11].ParameterName = ":fechaModificacion";
            parametros[11].Value = pFechaModificacion;

            parametros[12] = new OracleParameter();
            parametros[12].OracleType = OracleType.VarChar;
            parametros[12].ParameterName = ":modificadoPor";
            parametros[12].Value = pModificadoPor;

            parametros[13] = new OracleParameter();
            parametros[13].OracleType = OracleType.VarChar;
            parametros[13].ParameterName = ":creadoPor";
            parametros[13].Value = pCreadoPor;


            this.cnx.ejecutarConsultaSQL(sql, "clientesCreditoAsociados", parametros);
            this.error = this.cnx.IsError;
            this.errorDescripcion = this.cnx.ErrorDescripcion;
        }

       //Borra un cliente de acuerdo a la selección del usuario
        public void borrarCliente(string pIdCliente)
        {

            string sql = "delete from clientesCreditoAsociados where id_CodigoCliente = :id_CodigoCliente";//consulta delete hacia la base de datos por medio de la llave primaria
            OracleParameter[] parametro = new OracleParameter[1];
            parametro[0] = new OracleParameter();
            parametro[0].OracleType = OracleType.VarChar;
            parametro[0].ParameterName = ":id_CodigoCliente";
            parametro[0].Value = pIdCliente;
            this.cnx.ejecutarConsultaSQL(sql, "clientesCreditoAsociados", parametro);
            if (this.cnx.IsError)
            {
                this.errorDescripcion = "Éste Usuario no puede ser borrado porque se encuentra asociado a otra tabla.\nSi desea desactivarlo puede hacerlo en la pestaña Editar";
            }
        }

       //Modifica al cliente o actualiza los datos ya registrados en la base de datos
        public void modificarCliente(string pCedulaCliente, string pNombreCliente,string pEstado, string pPrimerApellido, string pSegundoApellido, string pDireccion, string pTelefono, string pLimite, string pCantidadActual, DateTime pFechaCreacion, string pCodigoCliente, DateTime pFechaModificacion, string pModificadoPor)
        {

            string sql = "Update clientesCreditoAsociados set   cedulaCliente = :cedulaCliente,estadoCliente = :estadoCliente,nombreCliente = :nombreCliente,primerApellidoCliente = :primerApellidoCliente,segundoApellidoCliente = :segundoApellidoCliente,direccionCliente = :direccionCliente,telefonoCliente = :telefonoCliente,limiteCreditoCliente = :limiteCreditoCliente,cantidadCreditoActualCliente = :cantidadCreditoActualCliente,fechaCreacion = :fechaCreacion, fechaModificacion = :fechaModificacion,modificadoPor = :modificadoPor where id_CodigoCliente  = :id_CodigoCliente";
            //mismo procedimiento que el metódo agregar ,lo que cambia es la consulta update para editar sobre los elementos existentes ,con valores parámetrizados
            OracleParameter[] Parametros = new OracleParameter[13];

            Parametros[0] = new OracleParameter();
            Parametros[0].OracleType = OracleType.VarChar;
            Parametros[0].ParameterName = ":cedulaCliente";
            Parametros[0].Value = pCedulaCliente;

            Parametros[1] = new OracleParameter();
            Parametros[1].OracleType = OracleType.VarChar;
            Parametros[1].ParameterName = ":estadoCliente";
            Parametros[1].Value = pEstado;

            Parametros[2] = new OracleParameter();
            Parametros[2].OracleType = OracleType.VarChar;
            Parametros[2].ParameterName = ":nombreCliente";
            Parametros[2].Value = pNombreCliente;

            Parametros[3] = new OracleParameter();
            Parametros[3].OracleType = OracleType.VarChar;
            Parametros[3].ParameterName = ":primerApellidoCliente";
            Parametros[3].Value = pPrimerApellido;

            Parametros[4] = new OracleParameter();
            Parametros[4].OracleType = OracleType.VarChar;
            Parametros[4].ParameterName = ":segundoApellidoCliente";
            Parametros[4].Value = pSegundoApellido;

            Parametros[5] = new OracleParameter();
            Parametros[5].OracleType = OracleType.VarChar;
            Parametros[5].ParameterName = ":direccionCliente";
            Parametros[5].Value = pDireccion;

            Parametros[6] = new OracleParameter();
            Parametros[6].OracleType = OracleType.VarChar;
            Parametros[6].ParameterName = ":telefonoCliente";
            Parametros[6].Value = pTelefono;

            Parametros[7] = new OracleParameter();
            Parametros[7].OracleType = OracleType.VarChar;
            Parametros[7].ParameterName = ":limiteCreditoCliente";
            Parametros[7].Value = pLimite;

            Parametros[8] = new OracleParameter();
            Parametros[8].OracleType = OracleType.VarChar;
            Parametros[8].ParameterName = ":cantidadCreditoActualCliente";
            Parametros[8].Value = pCantidadActual;

            Parametros[9] = new OracleParameter();
            Parametros[9].OracleType = OracleType.DateTime;
            Parametros[9].ParameterName = ":fechaCreacion";
            Parametros[9].Value = pFechaCreacion;

            Parametros[10] = new OracleParameter();
            Parametros[10].OracleType = OracleType.DateTime;
            Parametros[10].ParameterName = ":fechaModificacion";
            Parametros[10].Value = pFechaModificacion;

            Parametros[11] = new OracleParameter();
            Parametros[11].OracleType = OracleType.VarChar;
            Parametros[11].ParameterName = ":modificadoPor";
            Parametros[11].Value = pModificadoPor;

            Parametros[12] = new OracleParameter();
            Parametros[12].OracleType = OracleType.VarChar;
            Parametros[12].ParameterName = ":id_CodigoCliente";
            Parametros[12].Value = pCodigoCliente;

            this.cnx.ejecutarSQL(sql, Parametros);
            this.error = this.cnx.IsError;
            this.errorDescripcion = this.cnx.ErrorDescripcion;
        }
        public string ErrorDescripcion
        {
            get { return errorDescripcion; }

        }
        public bool Error
        {
            get { return error; }
        }
    }
}
