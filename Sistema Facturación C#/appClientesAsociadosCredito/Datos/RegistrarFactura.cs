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
    class RegistrarFactura
    {
        AccesoDatosMySql cnx;
        private bool error = false;
        private string errorDescripcion;

        public RegistrarFactura(AccesoDatosMySql pCnx) 
        {
            errorDescripcion = "";
            this.cnx = pCnx;
            error = false;
        }
        public DataSet obtenerFacturas()
        {
            DataSet retorno = new DataSet();
            string sql = "SELECT * FROM Productos_Vendidos";
            retorno = cnx.ejecutarConsultaSQL(sql);
            return retorno;
        }
        public void modificarFactura(string pNombreCliente, string pNumeroFactura)
        {

            string sql = "UPDATE Factura SET   nombreCliente = :nombreCliente WHERE id_Factura  = :id_Factura";
            //mismo procedimiento que el metódo agregar ,lo que cambia es la consulta update para editar sobre los elementos existentes ,con valores parámetrizados
            OracleParameter[] Parametros = new OracleParameter[2];

            Parametros[0] = new OracleParameter();
            Parametros[0].OracleType = OracleType.VarChar;
            Parametros[0].ParameterName = ":nombreCliente";
            Parametros[0].Value = pNombreCliente;

            Parametros[1] = new OracleParameter();
            Parametros[1].OracleType = OracleType.VarChar;
            Parametros[1].ParameterName = ":id_Factura";
            Parametros[1].Value = pNumeroFactura;

            this.cnx.ejecutarSQL(sql, Parametros);
            this.error = this.cnx.IsError;
            this.errorDescripcion = this.cnx.ErrorDescripcion;
        }
        public void registroFactura(string pNumeroFactura,string pCedula, string pNombreCliente, string pNumeroCliente, string pDireccionCliente, string pTelefonoCliente, string pTipoVenta, string pTotalNeto, string pCantidad, string pFechaCompra, DateTime pDescuento) //se recibe por parámetros los valores de NuevoUsuario
        {
            string sql = "Insert into Factura(id_NumeroFactura,nombreCliente,cedula,numeroCliente,direccionCliente,telefonoCliente,tipoVenta,descuento,totalNeto,fechaCompra)" +
                                    " Values(:id_NumeroFactura,:nombreCliente,:cedula,:numeroCliente,:direccionCliente,:telefonoCliente,:tipoVenta,:descuento,:totalNeto,:fechaCompra)";//consulta basica para insertar valores a la base de datos parámetrizada
            OracleParameter[] parametros = new OracleParameter[10];

            parametros[0] = new OracleParameter();
            parametros[0].OracleType = OracleType.VarChar;
            parametros[0].ParameterName = ":id_NumeroFactura";
            parametros[0].Value = pNumeroFactura;

            parametros[1] = new OracleParameter();
            parametros[1].OracleType = OracleType.VarChar;
            parametros[1].ParameterName = ":nombreCliente";
            parametros[1].Value = pNombreCliente;

            parametros[2] = new OracleParameter();
            parametros[2].OracleType = OracleType.VarChar;
            parametros[2].ParameterName = ":cedula";
            parametros[2].Value = pCedula;

            parametros[3] = new OracleParameter();
            parametros[3].OracleType = OracleType.VarChar;
            parametros[3].ParameterName = ":numeroCliente";
            parametros[3].Value = pNumeroCliente;

            parametros[4] = new OracleParameter();
            parametros[4].OracleType = OracleType.VarChar;
            parametros[4].ParameterName = ":direccionCliente";
            parametros[4].Value = pDireccionCliente;

            parametros[5] = new OracleParameter();
            parametros[5].OracleType = OracleType.VarChar;
            parametros[5].ParameterName = ":telefonoCliente";
            parametros[5].Value = pTelefonoCliente;

            parametros[6] = new OracleParameter();
            parametros[6].OracleType = OracleType.VarChar;
            parametros[6].ParameterName = ":tipoVenta";
            parametros[6].Value = pTipoVenta;

            parametros[7] = new OracleParameter();
            parametros[7].OracleType = OracleType.VarChar;
            parametros[7].ParameterName = ":descuento";
            parametros[7].Value = pDescuento;

            parametros[8] = new OracleParameter();
            parametros[8].OracleType = OracleType.VarChar;
            parametros[8].ParameterName = ":totalNeto";
            parametros[8].Value = pTotalNeto;

            parametros[9] = new OracleParameter();
            parametros[9].OracleType = OracleType.DateTime;
            parametros[9].ParameterName = ":fechaCompra";
            parametros[9].Value = pFechaCompra;

            this.cnx.ejecutarConsultaSQL(sql,"Factura", parametros);
            this.error = this.cnx.IsError;
            this.errorDescripcion = this.cnx.ErrorDescripcion;
        }
        public void borrarHistorialFactura(string pIDFactura)
        {

            string sql = "DELETE FROM Factura WHERE id_NumeroFactura = :id_NumeroFactura";//consulta delete hacia la base de datos por medio de la llave primaria
            OracleParameter[] parametro = new OracleParameter[1];
            parametro[0] = new OracleParameter();
            parametro[0].OracleType = OracleType.VarChar;
            parametro[0].ParameterName = ":id_NumeroFactura";
            parametro[0].Value = pIDFactura;
            this.cnx.ejecutarConsultaSQL(sql, "Factura", parametro);
            if (this.cnx.IsError)
            {
                this.errorDescripcion = cnx.ErrorDescripcion;
            }
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
