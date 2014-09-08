using Estructuras;
using GestorArchivos;
using Logica;
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
            try
            {
                XmlCL oXml = new XmlCL(tipoBaseDatos);
                List<EstructuraXml> respuesta = oXml.ObtenerDatosXml();
                if (respuesta.Count > 0)
                {
                    txtServidor.Text = respuesta[0].Servidor;
                    txtPuerto.Text = respuesta[0].Puerto;
                    txtBaseDatos.Text = respuesta[0].BaseDatos;
                    txtUsuario.Text = respuesta[0].Usuario;
                    txtContrasenna.Text = respuesta[0].Contrasenna;
                    txtEsquema.Text = respuesta[0].Esquema;
                }
            }
            catch 
            {
            }
        }
        private void btnAplicar_Click(object sender, EventArgs e)
        {
            AccesoDatosXml oXml = new AccesoXml(tipoBaseDatos);
            oXml.Conectar(tipoBaseDatos, txtUsuario.Text, txtContrasenna.Text, txtServidor.Text, txtBaseDatos.Text, txtEsquema.Text, txtPuerto.Text);
            if (oXml.isError)
            {
                MessageBox.Show(oXml.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                MessageBox.Show("Parametros de configuración cambiados con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnProbarConexion_Click(object sender, EventArgs e)
        {
            PruebaConexion oPrueba = new PruebaConexion();
            if (oPrueba.isError)
            {
                MessageBox.Show("Se ha producido un error inesperado durante la prueba de conexión. Detalle técnico: " + oPrueba.errroDescription, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (oPrueba.probarConexion(txtServidor.Text, txtBaseDatos.Text, txtUsuario.Text, txtContrasenna.Text, txtPuerto.Text) == true)
                {
                    MessageBox.Show("La conexión y los parametros se han establecido correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La conexión no se ha logrado establecer con los parametros establecidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
