using GestorArchivos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmConfiguracionBaseDatos : Form
    {
        private string error;
        private string tipoBaseDatos;
        GestorXML oG;
        public frmConfiguracionBaseDatos(string pTipoBaseDatos)
        {
            InitializeComponent();
            oG = new GestorXML();
            tipoBaseDatos = pTipoBaseDatos;
            lblTipoBaseDatos.Text = pTipoBaseDatos;
            mostrarCarga();
        }
        public void mostrarCarga() 
        {
            if (File.Exists(Application.StartupPath + "\\" + tipoBaseDatos + ".xml"))
            {
                DataSet config = cargarArchivoConfiguracion(ref error,tipoBaseDatos);
                if (error == "")
                {
                    txtServidor.Text = config.Tables[0].Rows[0]["Server"].ToString();
                    txtPuerto.Text = config.Tables[0].Rows[0]["Port"].ToString();
                    txtBaseDatos.Text = config.Tables[0].Rows[0]["DataBase"].ToString();
                    txtUsuario.Text = config.Tables[0].Rows[0]["Usuario"].ToString();
                    txtContrasenna.Text = config.Tables[0].Rows[0]["Password"].ToString();
                    txtEsquema.Text = config.Tables[0].Rows[0]["Schema"].ToString();
                }
                else
                {
                    MessageBox.Show("Error al intentar leer el archivo de configuración, por favor verifique de que el archivo exista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (MessageBox.Show("El archivo de configuración no existe. ¿Desea crear el archivo de configuración?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    Close();
                }
                else
                {
                    oG.conectarArchivoXml(tipoBaseDatos);
                }
            }
        }
        public static DataSet cargarArchivoConfiguracion(ref string estado,string pTipoBaseDatos)
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
        private void btnAplicar_Click(object sender, EventArgs e)
        {
            frmValidarUsuario oValidate = new frmValidarUsuario();
            oValidate.ShowDialog();
            if (oValidate.Aceptar == true)
            {
                oG.manipularXML(lblTipoBaseDatos.Text, txtUsuario.Text, txtContrasenna.Text, txtServidor.Text,
                    txtBaseDatos.Text, txtEsquema.Text, txtPuerto.Text, lblTipoBaseDatos.Text);
                if (oG.Error)
                {
                    MessageBox.Show(oG.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Parametros modificados satisfactoriamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
