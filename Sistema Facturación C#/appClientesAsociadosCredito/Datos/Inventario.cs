using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using System.Data;
using AccesoDatos;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Datos
{
    class Inventario
    {

        AccesoDatosMySql cnx;
        private bool error = false;
        private string errorDescripcion;

        public Inventario(AccesoDatosMySql pCnx) 
        {
            errorDescripcion = "";
            this.cnx = pCnx;
            error = false;
        }
        public string ErrorDescripcion
        {
            get { return errorDescripcion; }

        }
        public bool Error
        {
            get { return error; }
        }
        public DataSet ObtenerProductos()
        {
            DataSet retorno = new DataSet();
            string sql = "SELECT * FROM inventario";
            retorno = cnx.ejecutarConsultaSQL(sql);
            return retorno;
        }
        //Metodo encargado de filtrar datos desde la base datos MySql
        public DataSet FiltrarDatos(string pFiltro,string pTabla)
        {
            DataSet retorno = new DataSet();
            string sql = "SELECT * FROM inventario WHERE" + " " + pTabla + " LIKE '%" + pFiltro + "%'";
            retorno = cnx.ejecutarConsultaSQL(sql);
            return retorno;
        }
        public void agregarProductos(string pId_CodigoProducto, string pNombre, string pMarca, string pDescripcion, double pPrecioCompra, double pPrecioVenta, bool pExistencia,int pCantidad,DateTime pFechaEntrada) //se recibe por parámetros los valores de NuevoUsuario
        {
            string sql = "INSERT INTO inventario(id_producto,Nombre,Marca,Descripcion,Precio_Compra,Precio_Venta,Existencia,Cantidad,fecha_entrada)" +
                " VALUES(@id_producto,@Nombre,@Marca,@Descripcion,@Precio_Compra,@Precio_Venta,@Existencia,@Cantidad,@fecha_entrada)";//consulta basica para insertar valores a la base de datos parámetrizada
            MySqlParameter[] parametros = new MySqlParameter[9];
            parametros[0] = new MySqlParameter();
            parametros[0].MySqlDbType = MySqlDbType.VarChar;
            parametros[0].ParameterName = "@id_producto";
            parametros[0].Value = pId_CodigoProducto;

            parametros[1] = new MySqlParameter();
            parametros[1].MySqlDbType = MySqlDbType.VarChar;
            parametros[1].ParameterName = "@Nombre";
            parametros[1].Value = pNombre;

            parametros[2] = new MySqlParameter();
            parametros[2].MySqlDbType = MySqlDbType.VarChar;
            parametros[2].ParameterName = "@Marca";
            parametros[2].Value = pMarca;

            parametros[3] = new MySqlParameter();
            parametros[3].MySqlDbType = MySqlDbType.VarChar;
            parametros[3].ParameterName = "@Descripcion";
            parametros[3].Value = pDescripcion;

            parametros[4] = new MySqlParameter();
            parametros[4].MySqlDbType = MySqlDbType.Double;
            parametros[4].ParameterName = "@Precio_Compra";
            parametros[4].Value = pPrecioCompra;

            parametros[5] = new MySqlParameter();
            parametros[5].MySqlDbType = MySqlDbType.Double;
            parametros[5].ParameterName = "@Precio_Venta";
            parametros[5].Value = pPrecioVenta;

            parametros[6] = new MySqlParameter();
            parametros[6].MySqlDbType = MySqlDbType.VarChar;
            parametros[6].ParameterName = "@Existencia";
            parametros[6].Value = pExistencia;

            parametros[7] = new MySqlParameter();
            parametros[7].MySqlDbType = MySqlDbType.Int32;
            parametros[7].ParameterName = "@Cantidad";
            parametros[7].Value = pCantidad;

            parametros[8] = new MySqlParameter();
            parametros[8].MySqlDbType = MySqlDbType.DateTime;
            parametros[8].ParameterName = "@fecha_entrada";
            parametros[8].Value = pFechaEntrada;

            this.cnx.ejecutarConsultaSQL(sql,"Inventario",parametros);
            this.error = this.cnx.IsError;
            this.errorDescripcion = this.cnx.ErrorDescripcion;
        }

        public void modificarProducto(string pId_CodigoProducto, string pNombre, string pMarca, string pDescripcion, double pPrecioVenta, double pPrecioCompra, bool pExistencia, int pCantidad, DateTime pFechaEntrada)
        {

            string sql = "UPDATE inventario SET Nombre = @Nombre,Marca = @Marca,Descripcion = @Descripcion,Precio_Compra = @Precio_Compra,Precio_Venta = @Precio_Venta,Existencia = @Existencia,Cantidad =@Cantidad,fecha_entrada =@fecha_entrada where id_producto = @id_producto";
            //mismo procedimiento que el metódo agregar ,lo que cambia es la consulta update para editar sobre los elementos existentes ,con valores parámetrizados
            MySqlParameter[] parametros = new MySqlParameter[9];

            parametros[0] = new MySqlParameter();
            parametros[0].MySqlDbType = MySqlDbType.VarChar;
            parametros[0].ParameterName = "@id_producto";
            parametros[0].Value = pId_CodigoProducto;

            parametros[1] = new MySqlParameter();
            parametros[1].MySqlDbType = MySqlDbType.VarChar;
            parametros[1].ParameterName = "@Nombre";
            parametros[1].Value = pNombre;

            parametros[2] = new MySqlParameter();
            parametros[2].MySqlDbType = MySqlDbType.VarChar;
            parametros[2].ParameterName = "@Marca";
            parametros[2].Value = pMarca;

            parametros[3] = new MySqlParameter();
            parametros[3].MySqlDbType = MySqlDbType.VarChar;
            parametros[3].ParameterName = "@Descripcion";
            parametros[3].Value = pDescripcion;

            parametros[4] = new MySqlParameter();
            parametros[4].MySqlDbType = MySqlDbType.Double;
            parametros[4].ParameterName = "@Precio_Compra";
            parametros[4].Value = pPrecioCompra;

            parametros[5] = new MySqlParameter();
            parametros[5].MySqlDbType = MySqlDbType.Double;
            parametros[5].ParameterName = "@Precio_Venta";
            parametros[5].Value = pPrecioVenta;

            parametros[6] = new MySqlParameter();
            parametros[6].MySqlDbType = MySqlDbType.VarChar;
            parametros[6].ParameterName = "@Existencia";
            parametros[6].Value = pExistencia.ToString();

            parametros[7] = new MySqlParameter();
            parametros[7].MySqlDbType = MySqlDbType.Int32;
            parametros[7].ParameterName = "@Cantidad";
            parametros[7].Value = pCantidad;

            parametros[8] = new MySqlParameter();
            parametros[8].MySqlDbType = MySqlDbType.DateTime;
            parametros[8].ParameterName = "@fecha_entrada";
            parametros[8].Value = pFechaEntrada;

            this.cnx.ejecutarSQL(sql, parametros);
            this.error = this.cnx.IsError;
            this.errorDescripcion = this.cnx.ErrorDescripcion;
        }


        public void borrarProducto(string pIdProducto)
        {
            string sql = "DELETE FROM inventario WHERE id_producto = @id_producto";//consulta delete hacia la base de datos por medio de la llave primaria
            MySqlParameter[] parametro = new MySqlParameter[1];
            parametro[0] = new MySqlParameter();
            parametro[0].MySqlDbType = MySqlDbType.VarChar;
            parametro[0].ParameterName = "@id_producto";
            parametro[0].Value = pIdProducto;
            this.cnx.ejecutarConsultaSQL(sql, "inventario", parametro);
            if (this.cnx.IsError)
            {
                this.errorDescripcion = cnx.ErrorDescripcion;
            }
        }
    }
}
