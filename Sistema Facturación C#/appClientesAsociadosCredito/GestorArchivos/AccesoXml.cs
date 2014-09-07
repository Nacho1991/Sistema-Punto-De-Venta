using GestorArchivos;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace GestorArchivos
{
    public class AccesoXml : AccesoDatosXml
    {
        private string ruta;
        private string error;
        private string nomFile;
        private XmlDocument documento;
        public AccesoXml(string pNomFile) 
        {
            nomFile = pNomFile;
            error = "";
            documento = new XmlDocument();
            ruta = Application.StartupPath +"\\"+ pNomFile + ".xml";
        }
        //ruta en la cual vamos a guardar nuestro documento de texto con los candidatos registrados

        /*Metodo que nos ayudara a conectarnos al sistema. Si el archivo existe nos emitira un mensaje de error,
        pues nos creara un nuevo documento de texto*/
        public void Conectar(string pTipo, string pUsuario, string pContrasenna, string pServidor, string pBaseDatos, string pEsquema, string pPuerto)
        {
            try
            {
                XDocument configuracion = new XDocument(
                       new XDeclaration("1.0", "utf-8", "yes"),
                       new XComment("Configuración"),
                       new XElement("Parametros",
                                           new XElement("Conexion",
                                               new XElement("Tipo", nomFile),
                                               new XElement("Usuario", pUsuario),
                                               new XElement("Password", pContrasenna),
                                               new XElement("Server", pServidor),
                                               new XElement("DataBase", pBaseDatos),
                                               new XElement("Schema", pEsquema),
                                               new XElement("Port", pPuerto))
                              )
                              );
                configuracion.Save(ruta);

            }
            catch (Exception xp)
            {
                isError = true;
                ErrorDescripcion = xp.Message;
            }
        }
        public DataSet CargarArchivoConfiguracion(ref string pEstado, string pTipoBaseDatos) 
        {
            DataSet dsetConf = new DataSet();
            if (File.Exists(ruta))
            {
                pEstado = "";
                try
                {
                    string archivoXML = ruta;
                    System.IO.FileStream fsReadXml =
                                     new System.IO.FileStream(archivoXML, System.IO.FileMode.Open);
                    dsetConf.ReadXml(fsReadXml);
                    fsReadXml.Close();
                }
                catch (Exception e)
                {
                    pEstado = "Ha ocurrido un error cargando los parámetros de conexión " +
                             "a la base de datos, detalle técnico: " + e.Message;
                }

            }
            else 
            {
                if (MessageBox.Show("El archivo de configuración no existe dentro del directorio. ¿Desea crear el archivo de configuración?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Conectar(" ", " ", " ", " ", " ", " ", " ");
                }
            }
            return dsetConf;
        
        }

        //Metodo que nos ayudara a setear o obtener el error.
        public bool isError
        {
            set;
            get;
        }

        //Metodo que nos ayudara a obtener o establecer una descripcion de algun error mostrado.
        public string ErrorDescripcion
        {
            set;
            get;
        }
    }
}
