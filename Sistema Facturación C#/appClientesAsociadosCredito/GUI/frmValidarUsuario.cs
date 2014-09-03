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
    public partial class frmValidarUsuario : Form
    {
        private bool aceptar;
        public frmValidarUsuario()
        {
            aceptar = false;
            InitializeComponent();
        }

        private void bitnValidar_Click(object sender, EventArgs e)
        {
            aceptar = true;
            Close();
        }
        public bool Aceptar
        {
            get { return aceptar; }
            set { aceptar = value; }
        }
        public string NombreUsuario
        {
            get { return txtNombreUsuario.Text; }
            set { txtNombreUsuario.Text = value; }
        }
        public string Contrasenna 
        {
            get { return txtContrasenna.Text; }
            set { txtContrasenna.Text = value; }
        }
    }
}
