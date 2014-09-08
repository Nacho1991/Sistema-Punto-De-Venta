using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using GUI;
using MySql.Data.MySqlClient;
using AccesoDatos;
using GestorArchivos;
using Criptografia;


namespace appClientesAsociadosCredito
{
    static class Program
    {
        public static UsuarioL oUsuarioLogueado;
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Encriptacion oE = new Encriptacion();
            string error = "";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            TxtCL oTxt = new TxtCL();
            if ((oTxt.ValidarEstado("Mostrar")))
            {
                DataSet config = cargarArchivoConfiguracionMySQL(ref error, oTxt.tipoBaseDatos);
                if (error == "")
                {
                    //Variables que almacenan los parametros de conexión
                    string server = config.Tables[0].Rows[0]["Server"].ToString();
                    string port = config.Tables[0].Rows[0]["Port"].ToString();
                    string database = config.Tables[0].Rows[0]["DataBase"].ToString();
                    string user = config.Tables[0].Rows[0]["Usuario"].ToString();
                    string pass = config.Tables[0].Rows[0]["Password"].ToString();

                    //Esta variable alamcena la cadena de conexion con los parametros extraidos
                    string cadenaConexion = "Server=" + server + ";" + "database=" + database + ";" + "Uid=" + user + ";" + " pwd=" + pass + ";" + "port=" + 3306 + ";";
                    //Se envia por parametro la cadena de conexion
                    AccesoDatosMySql conexion = new AccesoDatosMySql(cadenaConexion);
                    //Si el estado de conexion es correcta
                    if (conexion.estado())
                    {
                        frmLogin oLogin = new frmLogin(conexion);
                        oLogin.ShowDialog();
                        if (oLogin.Aceptar)
                        {
                            oUsuarioLogueado = oLogin.OUsuario;
                            Application.Run(new frmPrincipal(conexion, conexion.estado()));
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error conectando, detalle: " + conexion.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                frmSeleccionBaseDatos oSeleccion = new frmSeleccionBaseDatos();
                oSeleccion.ShowDialog();
                if (oSeleccion.Aceptar)
                {
                    DataSet config = cargarArchivoConfiguracionMySQL(ref error, oSeleccion.Seleccion);
                    if (error == "")
                    {
                        //Variables que almacenan los parametros de conexión
                        string server = config.Tables[0].Rows[0]["Server"].ToString();
                        string port = config.Tables[0].Rows[0]["Port"].ToString();
                        string database = config.Tables[0].Rows[0]["DataBase"].ToString();
                        string user = config.Tables[0].Rows[0]["Usuario"].ToString();
                        string pass = config.Tables[0].Rows[0]["Password"].ToString();

                        //Esta variable alamcena la cadena de conexion con los parametros extraidos
                        string cadenaConexion = "Server=" + server + ";" + "database=" + database + ";" + "Uid=" + user + ";" + " pwd=" + pass + ";" + "port=" + 3306 + ";";
                        //Se envia por parametro la cadena de conexion
                        AccesoDatosMySql conexion = new AccesoDatosMySql(cadenaConexion);
                        //Si el estado de conexion es correcta
                        if (conexion.estado())
                        {
                            frmLogin oLogin = new frmLogin(conexion);
                            oLogin.ShowDialog();
                            if (oLogin.Aceptar)
                            {
                                oUsuarioLogueado = oLogin.OUsuario;
                                Application.Run(new frmPrincipal(conexion, conexion.estado()));
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error conectando, detalle: " + conexion.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        //Metodo encargado de leer el archivo XML
        public static DataSet cargarArchivoConfiguracionMySQL(ref string estado, string pTipoBaseDatos)
        {
            DataSet dsetConf = new DataSet();
            estado = "";
            try
            {
                string archivoXML = Application.StartupPath + "\\" + pTipoBaseDatos + ".xml";
                System.IO.FileStream fsReadXml =
                                 new System.IO.FileStream(archivoXML, System.IO.FileMode.Open);
                dsetConf.ReadXml(fsReadXml);
                fsReadXml.Close();
            }
            catch (Exception e)
            {
                estado = "Ha ocurrido un error cargando los parámetros de conexión " +
                         "a la base de datos, detalle técnico: " + e.Message;
            }
            return dsetConf;
        }

    }
}

