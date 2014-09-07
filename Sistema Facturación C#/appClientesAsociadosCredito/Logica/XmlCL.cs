using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestorArchivos;
using System.IO;
using System.Windows.Forms;
using System.Data;
using Estructuras;

namespace Logica
{
    public class XmlCL
    {
        private AccesoDatosXml accesoDatos;
        private string nomFile;
        private string error;
        public XmlCL(string pNombreArchivo)
        {
            nomFile = pNombreArchivo;
            error = "";
            accesoDatos = new AccesoXml(pNombreArchivo);
        }
        public List<EstructuraXml> ObtenerDatosXml()
        {
            AccesoDatosXml accesoDatos = new AccesoXml(nomFile);
            DataSet config = accesoDatos.CargarArchivoConfiguracion(ref error, nomFile);
            List<EstructuraXml> listConfig = new List<EstructuraXml>();
            if (listConfig.Count == 0) {
                if (File.Exists(Application.StartupPath + "\\" + nomFile + ".xml"))
                {
                    if (error == "")
                    {
                        try
                        {
                            listConfig.Add(new EstructuraXml()
                            {
                                Servidor = config.Tables[0].Rows[0]["Server"].ToString(),
                                Puerto = config.Tables[0].Rows[0]["Port"].ToString(),
                                BaseDatos = config.Tables[0].Rows[0]["DataBase"].ToString(),
                                Usuario = config.Tables[0].Rows[0]["Usuario"].ToString(),
                                Contrasenna = config.Tables[0].Rows[0]["Password"].ToString(),
                                Esquema = config.Tables[0].Rows[0]["Schema"].ToString()
                            });
                        }
                        catch { }

                    }
                    else
                    {
                        MessageBox.Show("Error al intentar leer el archivo de configuración, por favor verifique de que el archivo exista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            return listConfig;
        }
        public void modificarXml() 
        {

        }
    }
}
