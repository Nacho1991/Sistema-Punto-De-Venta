using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using AccesoDatos;

namespace GUI
{
    public partial class frmLogin : Form
    {
        AccesoDatosMySql cnxMySql;
        private bool aceptar;
        private UsuarioL oUsuario;
        private bool salir;
        private int i;

        public bool Salir
        {
            get { return salir; }
            set { salir = value; }
        }

        public frmLogin(AccesoDatosMySql pCnx)
        {
            InitializeComponent();
            cnxMySql = pCnx;
            aceptar = false;
            salir = false;
            i = 0;
            btnAcceder.Click += new EventHandler(btnAcceder_Click);
            lblInfo.Visible = false;
        }

        public UsuarioL OUsuario
        {
            get { return oUsuario; }
            set { oUsuario = value; }
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if ((this.txtNombreUsuario.Text != "") && (this.txtContraseña.Text != ""))
            {
                UsuarioD oUsuarioD = new UsuarioD(cnxMySql);
                List<UsuarioL> respuesta = oUsuarioD.validarLogin(new UsuarioL("", "", "", "", "", "", "", "", "", "", this.txtNombreUsuario.Text, this.txtContraseña.Text, "", "", "", "", ""));
                if (oUsuarioD.Error)
                {
                    MessageBox.Show("Error validando login:" + oUsuarioD.ErrorDescription, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    cheBoxMostrarCaracteres.Checked = false;
                    //proBarCargandoDatos.CreateGraphics().DrawString(i.ToString() + "%", new Font("Arial", (float)10.25, FontStyle.Regular), Brushes.Black, new PointF(proBarCargandoDatos.Width / 2 - 10, proBarCargandoDatos.Height / 2 - 7));
                    lblInfo.Text = "Validadando usuario...";
                    if (respuesta.Count == 0)
                    {
                        lblInfo.Text = "";
                        MessageBox.Show("Nombre de usuario o contraseña incorrectos, por favor verifique para continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                try
                {
                    this.oUsuario = new UsuarioL("", "", "", "", "", "", "", "", "", "", this.txtNombreUsuario.Text, this.txtContraseña.Text, "", respuesta[0].Cedula, respuesta[0].Departamento, respuesta[0].Nombre, respuesta[0].Apellidos);
                    this.aceptar = true;
                    this.Close();
                }
                catch
                {
                    txtContraseña.Enabled = true;
                    txtNombreUsuario.Enabled = true;
                    btnAcceder.Enabled = true;
                    lblInfo.Enabled = false;
                    MessageBox.Show("Error al registrar el inicio de sesión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Faltan datos requeridos para el inicio de sesión, por favor corrija para continuar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        
        public bool Aceptar
        {
            get { return aceptar; }
            set { aceptar = value; }
        }
            //proBarCargandoDatos.CreateGraphics().DrawString(i.ToString() + "%", new Font("Arial", (float)10.25, FontStyle.Regular), Brushes.Black, new PointF(proBarCargandoDatos.Width / 2 - 10, proBarCargandoDatos.Height / 2 - 7));
            
        private void cheBoxMostrarCaracteres_CheckedChanged(object sender, EventArgs e)
        {
            if (cheBoxMostrarCaracteres.Checked == true)
            {
                txtContraseña.PasswordChar = '\0';
            }
            else if (txtContraseña.Text != "")
            {
                txtContraseña.PasswordChar = '●';
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtNombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
                btnAcceder.PerformClick();
            }
            return;
        }
        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
                btnAcceder.PerformClick();
            }
        }
    }
}
