using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public frmSeleccionBaseDatos()
        {
            InitializeComponent();
            seleccion = "";
            aceptar = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
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
