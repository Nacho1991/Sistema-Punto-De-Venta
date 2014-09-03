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
    class PrivilegiosD
    {
        private AccesoDatosMySql cnx;
        private bool error = false;
        private string errorDescription = "";

        public PrivilegiosD(AccesoDatosMySql pCnx)
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

        public List<PrivilegiosL> obtenerPrivilegios(PrivilegiosL pPrivilegios)
        {
            List<PrivilegiosL> retorno = new List<PrivilegiosL>();
            try
            {
                MySqlParameter[] parametros = new MySqlParameter[1];

                parametros[0] = new MySqlParameter();
                parametros[0].MySqlDbType = MySqlDbType.VarChar;
                parametros[0].ParameterName = "@Login_Id_Cedula";
                parametros[0].Value = pPrivilegios.Cedula;

                DataSet datos = this.cnx.ejecutarConsultaSQL("SELECT * FROM Privilegios WHERE Login_Id_Cedula = @Login_Id_Cedula", "Privilegios", parametros);
                if (this.cnx.IsError == false)
                {
                    foreach (DataRow fila in datos.Tables[0].Rows)
                    {
                        retorno.Add(
                                    new PrivilegiosL(
                                               fila["Login_Id_Cedula"].ToString(),
                                               fila["Administracion_Cajas"].ToString(),
                                               fila["Administracion_Clientes"].ToString(),
                                               fila["Administracion_Inventario"].ToString(),
                                               fila["Administracion_Empleados"].ToString(),
                                               fila["Administracion_Facturas"].ToString()
                                               ));
                    }
                }
                else {
                    this.error = true;
                    this.errorDescription = "Error al obtener los privilegios del empleado: " +
                                            this.cnx.ErrorDescripcion;
                }
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error validando usuario:" + e.Message;
            }
            return retorno;
        }
    }
}
