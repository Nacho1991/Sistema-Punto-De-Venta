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
    public partial class frmCambiarContrasenna : Form
    {
        private bool aceptar;
        private string contrasenna;
        public frmCambiarContrasenna(string pContrasenna)
        {
            InitializeComponent();
            contrasenna = pContrasenna;
        }
        public bool comprobrarContrasenna()
        {
            bool coinciden = false;
            if (txtContrasennaNueva.Text == txtVerificarContrasenna.Text)
            {
                coinciden = true;
            }
            return coinciden;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (contrasenna == txtContrasennaAnterior.Text)
            {
                if (comprobrarContrasenna() == true)
                {
                    aceptar = true;
                    Close();
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden por favor corrija para continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else 
            {
                MessageBox.Show("La contraseña anterior es incorrecta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        public bool Aceptar
        {
            get { return aceptar; }
            set { aceptar = value; }
        }
        public string ContrasennaNueva 
        {
            get { return txtContrasennaNueva.Text; }
            set { txtContrasennaNueva.Text = value; }
        }
    }
}
