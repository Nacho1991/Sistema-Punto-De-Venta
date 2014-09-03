using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OracleClient;
using AccesoDatos;
using MySql.Data.MySqlClient;

namespace Logica
{
    public class UsuarioD
    {
        private AccesoDatosMySql cnx;
        private bool error = false;
        private string errorDescription = "";

        public UsuarioD(AccesoDatosMySql pCnx)
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
        public List<UsuarioL> obtenerEmpleado(UsuarioL pUsuario)
        {
            List<UsuarioL> retorno = new List<UsuarioL>();
            try
            {
                MySqlParameter[] parametros = new MySqlParameter[1];

                parametros[0] = new MySqlParameter();
                parametros[0].MySqlDbType = MySqlDbType.VarChar;
                parametros[0].ParameterName = "@ID_CEDULA";
                parametros[0].Value = pUsuario.Cedula;

                DataSet datos = this.cnx.ejecutarConsultaSQL("SELECT * FROM LOGIN WHERE ID_CEDULA = @ID_CEDULA", "LOGIN", parametros);

                if (this.cnx.IsError == false)
                {
                    foreach (DataRow fila in datos.Tables[0].Rows)
                    {
                        retorno.Add(
                                    new UsuarioL(
                                               fila["Fecha_Nacimiento"].ToString(),
                                        fila["Telefono"].ToString(),
                                        fila["Celular"].ToString(),
                                        fila["Edad"].ToString(),
                                        fila["Sexo"].ToString(),
                                        fila["Email"].ToString(),
                                        fila["Fecha_Creacion"].ToString(),
                                        fila["Fecha_Modificacion"].ToString(),
                                        fila["Creado_Por"].ToString(),
                                        fila["Modificado_Por"].ToString(),
                                        fila["nombre_usuario"].ToString(),
                                        fila["contrasenna"].ToString(),
                                        fila["Dir_Foto_Perfil"].ToString(),
                                        fila["Id_Cedula"].ToString(),
                                        fila["Deártamento_Id_Departamento"].ToString(),
                                        fila["Nombre"].ToString(),
                                        fila["Apellidos"].ToString()));
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
        public List<UsuarioL> validarLogin(UsuarioL pUsuario)
        {
            List<UsuarioL> retorno = new List<UsuarioL>();
            try
            {
                MySqlParameter[] parametros = new MySqlParameter[2];

                parametros[0] = new MySqlParameter();
                parametros[0].MySqlDbType = MySqlDbType.VarChar;
                parametros[0].ParameterName = "@nombre_usuario";
                parametros[0].Value = pUsuario.NombreUsuario;

                parametros[1] = new MySqlParameter();
                parametros[1].MySqlDbType = MySqlDbType.VarChar;
                parametros[1].ParameterName = "@contrasenna";
                parametros[1].Value = pUsuario.Contrasenna;

                DataSet datos = this.cnx.ejecutarConsultaSQL("SELECT * FROM LOGIN WHERE NOMBRE_USUARIO = @NOMBRE_USUARIO AND CONTRASENNA = @CONTRASENNA", "LOGIN", parametros);
                if (this.cnx.IsError == false)
                {
                    foreach (DataRow fila in datos.Tables[0].Rows)
                    {
                        retorno.Add(
                                    new UsuarioL(
                                        fila["Fecha_Nacimiento"].ToString(),
                                        fila["Telefono"].ToString(),
                                        fila["Celular"].ToString(),
                                        fila["Edad"].ToString(),
                                        fila["Sexo"].ToString(),
                                        fila["Email"].ToString(),
                                        fila["Fecha_Creacion"].ToString(),
                                        fila["Fecha_Modificacion"].ToString(),
                                        fila["Creado_Por"].ToString(),
                                        fila["Modificado_Por"].ToString(),
                                        fila["nombre_usuario"].ToString(),
                                        fila["contrasenna"].ToString(),
                                        fila["Dir_Foto_Perfil"].ToString(),
                                        fila["Id_Cedula"].ToString(),
                                        fila["Deártamento_Id_Departamento"].ToString(),
                                        fila["Nombre"].ToString(),
                                        fila["Apellidos"].ToString()));
                    }
                }
                else {
                    this.error = true;
                    this.errorDescription = "Error validando usuario: " +
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
