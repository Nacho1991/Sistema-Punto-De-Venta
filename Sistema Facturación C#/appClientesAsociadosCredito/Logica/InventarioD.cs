using AccesoDatos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    class InventarioD
    {
        private AccesoDatosMySql cnx;
        private bool error = false;
        private string errorDescription = "";

        public InventarioD(AccesoDatosMySql pCnx)
        {
            this.cnx = pCnx;
        }

        public bool Error
        {
            get { return error; }
        }
       
        public string ErrorDescription
        {
            get { return errorDescription; }
        }
        public List<InventarioL> obtenerProducto(InventarioL pInventario)
        {
            List<InventarioL> retorno = new List<InventarioL>();
            try
            {
                MySqlParameter[] parametros = new MySqlParameter[1];

                parametros[0] = new MySqlParameter();
                parametros[0].MySqlDbType = MySqlDbType.VarChar;
                parametros[0].ParameterName = "@ID_PRODUCTO";
                parametros[0].Value = pInventario.IdProducto;

                DataSet datos = this.cnx.ejecutarConsultaSQL("SELECT * FROM INVENTARIO WHERE ID_PRODUCTO = @ID_PRODUCTO", "INVENTARIO", parametros);
                
                if (this.cnx.IsError == false)
                {
                    foreach (DataRow fila in datos.Tables[0].Rows)
                    {
                        retorno.Add(
                                    new InventarioL(
                                               fila["Id_Producto"].ToString(),
                                               fila["Nombre"].ToString(),
                                               fila["Marca"].ToString(),
                                               fila["Descripcion"].ToString(),
                                               fila["Precio_Compra"].ToString(),
                                               fila["Precio_Venta"].ToString(),
                                               fila["Existencia"].ToString(),
                                               fila["Cantidad"].ToString(),
                                               fila["fecha_entrada"].ToString()
                                               ));
                    }
                }
                else
                {
                    this.error = true;
                    this.errorDescription = "Error al obtener los productos: " +
                                            this.cnx.ErrorDescripcion;
                }
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error al obetner los productos: " + e.Message;
            }
            return retorno;
        }
        public List<InventarioL> obtenerFiltro(string pFiltro)
        {
            List<InventarioL> retorno = new List<InventarioL>();
            try
            {
                MySqlParameter[] parametros = new MySqlParameter[1];

                parametros[0] = new MySqlParameter();
                parametros[0].MySqlDbType = MySqlDbType.VarChar;
                parametros[0].ParameterName = "@descripcion";
                parametros[0].Value = pFiltro;

                DataSet datos = this.cnx.ejecutarConsultaSQL("select * from inventario where descripcion = @descripcion", "inventario", parametros);
                if (this.cnx.IsError == false)
                {
                    foreach (DataRow fila in datos.Tables[0].Rows)
                    {
                        retorno.Add(
                                    new InventarioL(
                                               fila["Id_Producto"].ToString(),
                                               fila["Nombre"].ToString(),
                                               fila["Marca"].ToString(),
                                               fila["Descripcion"].ToString(),
                                               fila["Precio_Compra"].ToString(),
                                               fila["Precio_Venta"].ToString(),
                                               fila["Existencia"].ToString(),
                                               fila["Cantidad"].ToString(),
                                               fila["fecha_entrada"].ToString()
                                               ));
                    }
                }
                else {
                    this.error = true;
                    this.errorDescription = "Error al obtener los prodcutos: " +
                                            this.cnx.ErrorDescripcion;
                }
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error al obtener los productos: " + e.Message;
            }
            return retorno;
        }
    }
}
