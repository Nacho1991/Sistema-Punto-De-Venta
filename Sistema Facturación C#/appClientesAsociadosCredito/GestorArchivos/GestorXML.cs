using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace GestorArchivos
{
    class GestorXML
    {
        private bool error;
        private string errorDescripcion;
        private XmlDocument documento = new XmlDocument();
        public GestorXML() 
        {
            error = false;
            errorDescripcion = "";
        }
        public void conectarArchivoXml(string pTipoBaseDatos)
        {
            try
            {

                XDocument configuracion = new XDocument(
                            new XDeclaration("1.0", "utf-8", "yes"),
                            new XComment("Configuración"),
                            new XElement("Parametros",
                                                new XElement("Conexion",
                                                    new XElement("Tipo", pTipoBaseDatos),
                                                    new XElement("Usuario", " "),
                                                    new XElement("Password", " "),
                                                    new XElement("Server", " "),
                                                    new XElement("DataBase", " "),
                                                    new XElement("Schema", " "),
                                                    new XElement("Port", " "))
                                   )
                                   );
                configuracion.Save(Application.StartupPath + "\\" + pTipoBaseDatos + ".xml");


            }
            catch
            {

            }
        }
        public void manipularXML(string pTipo, string pUsuario, string pContrasenna, string pServidor, string pBaseDatos, string pEsquema, string pPuerto,string pTipoBaseDatos)
        {
            try
            {
                //Cargamos el documento XML.
                documento.Load(Application.StartupPath + "\\" + pTipoBaseDatos + ".xml");
                //Obtenemos el nodo raiz del documento.
                XmlElement conexion = documento.DocumentElement;
                //Obtenemos la lista de todos los empleados.
                XmlNodeList listaParametros = documento.SelectNodes("Parametros/Conexion");
                //Recorremos el archivo xml
                foreach (XmlNode item in listaParametros)
                {
                    //Determinamos el nodo a modificar por medio del tipod de servidor.
                    if (item.FirstChild.InnerText == pTipo)
                    {
                        //Nodo sustituido.
                        XmlNode nodoOld = item;

                        //Nodo nuevo.
                        XmlNode nodoNew = CrearNodoXml(pTipo, pUsuario, pContrasenna, pServidor, pBaseDatos, pEsquema, pPuerto);

                        //Remplazamos el nodo.
                        conexion.ReplaceChild(nodoNew, nodoOld);
                    }
                }
                try
                {
                    //Salvamos el documento.
                    documento.Save(Application.StartupPath + "\\" + pTipoBaseDatos + ".xml");
                }
                catch (Exception e)
                {
                    error = true;
                    errorDescripcion = "Error al intentar guardar el archivo, detalle técnico: " + e.Message;
                }
            }
            catch (Exception e)
            {
                error = true;
                errorDescripcion = "Error al intentar leer el archivo, detalle técnico: " + e.Message;
            }

        }
        private XmlNode CrearNodoXml(string pTipo, string pUsuario, string pContrasenna, string pServidor, string pBaseDatos, string pEsquema,string pPuerto)
        {
            //Creamos el nodo que deseamos insertar.
            XmlElement conexion = documento.CreateElement("Conexion");

            //Creamos el elemento Tipo.
            XmlElement tipo = documento.CreateElement("Tipo");
            tipo.InnerText = pTipo;
            conexion.AppendChild(tipo);

            //Creamos el elemento Usuario.
            XmlElement usuario = documento.CreateElement("Usuario");
            usuario.InnerText = pUsuario;
            conexion.AppendChild(usuario);

            //Creamos el elemento Contraseña.
            XmlElement contrasenna = documento.CreateElement("Password");
            contrasenna.InnerText = pContrasenna;
            conexion.AppendChild(contrasenna);

            //Creamos el elemento Servidor.
            XmlElement servidor = documento.CreateElement("Server");
            servidor.InnerText = pServidor;
            conexion.AppendChild(servidor);

            //Creamos el elemento Base De Datos.
            XmlElement baseDatos = documento.CreateElement("DataBase");
            baseDatos.InnerText = pBaseDatos;
            conexion.AppendChild(baseDatos);

            //Creamos el elemento Esquema.
            XmlElement esquema = documento.CreateElement("Schema");
            esquema.InnerText = pEsquema;
            conexion.AppendChild(esquema);

            //Creamos el elemento Puerto.
            XmlElement puerto = documento.CreateElement("Port");
            puerto.InnerText = pPuerto;
            conexion.AppendChild(puerto);

            return conexion;
        }
        public bool Error
        {
            get { return error; }
            set { error = value; }
        }
        public string ErrorDescripcion
        {
            get { return errorDescripcion; }
            set { errorDescripcion = value; }
        }
    }
}
