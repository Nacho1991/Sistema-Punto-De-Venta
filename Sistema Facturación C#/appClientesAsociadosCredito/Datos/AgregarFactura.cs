using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using System.Data;

namespace Logica
{
    class AgregarFacturas
    {
        AccesoDatosOracle cnx;
        private bool error = false;
        private string errorDescripcion;

        public AgregarFacturas(AccesoDatosOracle pCnx) 
        {
            errorDescripcion = "";
            this.cnx = pCnx;
            error = false;
        }
        public DataSet obtenerFacturas()
        {
            DataSet retorno = new DataSet();
            string sql = "select * from Factura";
            retorno = cnx.ejecutarConsultaSQL(sql);
            return retorno;
        }
        public void modificarFactura(string pNombreCliente, string pNumeroFactura)
        {

            string sql = "Update Factura set   nombreCliente = :nombreCliente where id_Factura  = :id_Factura";
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
        public void registroFactura(string pIdFactura,string pNombreCliente, string pDireccionCliente,string pTelefono, string pTipoCliente, string pCodigoProducto, string pDescripcion, string pCantidad, string pCostoUnitario, string pDescuento,string pCostoTotal) //se recibe por parámetros los valores de NuevoUsuario
        {
            string sql = "Insert into Factura(id_FacturaCliente,nombreCliente,direccionCliente,telefonoCliente,tipoCliente,codigoProductoCliente,descripcionProductoCliente,cantidadProductoCliente,costoProductoCliente,descuentoCliente,costoTotalCliente)" +
                                    " Values(:id_FacturaCliente,:nombreCliente,:direccionCliente,:telefonoCliente,:tipoCliente,:codigoProductoCliente,:descripcionProductoCliente,:cantidadProductoCliente,:costoProductoCliente,:descuentoCliente,:costoTotalCliente)";//consulta basica para insertar valores a la base de datos parámetrizada
            OracleParameter[] parametros = new OracleParameter[11];

            parametros[0] = new OracleParameter();
            parametros[0].OracleType = OracleType.VarChar;
            parametros[0].ParameterName = ":id_FacturaCliente";
            parametros[0].Value = pIdFactura;

            parametros[1] = new OracleParameter();
            parametros[1].OracleType = OracleType.VarChar;
            parametros[1].ParameterName = ":nombreCliente";
            parametros[1].Value = pNombreCliente;

            parametros[2] = new OracleParameter();
            parametros[2].OracleType = OracleType.VarChar;
            parametros[2].ParameterName = ":direccionCliente";
            parametros[2].Value = pDireccionCliente;

            parametros[3] = new OracleParameter();
            parametros[3].OracleType = OracleType.VarChar;
            parametros[3].ParameterName = ":telefonoCliente";
            parametros[3].Value = pTelefono;

            parametros[4] = new OracleParameter();
            parametros[4].OracleType = OracleType.VarChar;
            parametros[4].ParameterName = ":tipoCliente";
            parametros[4].Value = pTipoCliente;

            parametros[5] = new OracleParameter();
            parametros[5].OracleType = OracleType.VarChar;
            parametros[5].ParameterName = ":codigoProductoCliente";
            parametros[5].Value = pCodigoProducto;

            parametros[6] = new OracleParameter();
            parametros[6].OracleType = OracleType.VarChar;
            parametros[6].ParameterName = ":descripcionProductoCliente";
            parametros[6].Value = pDescripcion;

            parametros[7] = new OracleParameter();
            parametros[7].OracleType = OracleType.VarChar;
            parametros[7].ParameterName = ":cantidadProductoCliente";
            parametros[7].Value = pCantidad;

            parametros[8] = new OracleParameter();
            parametros[8].OracleType = OracleType.VarChar;
            parametros[8].ParameterName = ":costoProductoCliente";
            parametros[8].Value = pCostoUnitario;

            parametros[9] = new OracleParameter();
            parametros[9].OracleType = OracleType.VarChar;
            parametros[9].ParameterName = ":descuentoCliente";
            parametros[9].Value = pDescuento;

            parametros[10] = new OracleParameter();
            parametros[10].OracleType = OracleType.VarChar;
            parametros[10].ParameterName = ":costoTotalCliente";
            parametros[10].Value = pCostoTotal;

            this.cnx.ejecutarConsultaSQL(sql,"Factura", parametros);
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
