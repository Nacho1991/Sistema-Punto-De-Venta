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
    public partial class frmSeleccionBaseDatos : Form
    {
        private string seleccion;
        private bool aceptar;
        private string ruta;
        private TxtCL oTxt;
        public frmSeleccionBaseDatos()
        {
            InitializeComponent();
            ruta = Application.StartupPath + "\\" + "configForm.txt";
            seleccion = "";
            aceptar = false;
            oTxt = new TxtCL();
        }
        public void escribirEstado()
        {
            string hilera = "Mostrar," + chkOcultarForm.Checked.ToString() + ",MySQL";
            oTxt.Escribir(hilera);
            if (oTxt.isError)
            {
                MessageBox.Show("Error al intentar establecer la configuración de ocultar el formulario." + oTxt.errorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void editarEstado() 
        {
            oTxt.Editar("Mostrar,", "Mostrar," + chkOcultarForm.Checked.ToString() + ",MySQL");
            if (oTxt.isError) 
            {
                MessageBox.Show("Error al intentar establecer la configuración de ocultar el formulario." + oTxt.errorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            string estado = "";
            if (!chkOcultarForm.Checked)
            {
                if (lblMySql.Text == "")
                {
                    MessageBox.Show("Por favor seleccione una de las Bases de Datos para iniciar la aplicación.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    aceptar = true;
                    Close();
                }
            }
            else
            {
                StreamReader sr = new StreamReader(ruta);
                string linea;
                if ((linea = sr.ReadLine()) == null)
                {
                    sr.Close();
                    escribirEstado();
                }
                else 
                {
                    sr.Close();
                    editarEstado();
                }
                MessageBox.Show("Ha solicitado no volver a mostrar éste formulario, si desea cambiar los parametros, lo puede hacer desde la ventana principal en la pestaña Sistema/Configuración", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                aceptar = true;
                Close();
            }
        }
        public string Seleccion
        {
            get { return lblMySql.Text; }
            set { lblMySql.Text = value; }
        }
        public bool Aceptar
        {
            get { return aceptar; }
            set { aceptar = value; }
        }

        private void lnkOpcionesAvanzadas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmConfiguracionBaseDatos oConfig = new frmConfiguracionBaseDatos(lblMySql.Text);
            oConfig.ShowDialog();
        }
    }
}
