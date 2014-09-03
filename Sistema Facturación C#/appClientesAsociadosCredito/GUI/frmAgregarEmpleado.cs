using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using AccesoDatos;
using Datos;

namespace GUI
{
    public partial class frmAgregarEmpleado : Form
    {
        private AccesoDatosMySql cnx;
        private Empleadocs oEmpleado;
        private bool aceptar;
        private string usuarioLogeado;

        public frmAgregarEmpleado(AccesoDatosMySql pCnx)
        {
            InitializeComponent();
            oEmpleado = new Empleadocs(pCnx);
            usuarioLogeado = appClientesAsociadosCredito.Program.oUsuarioLogueado.Nombre + " " + appClientesAsociadosCredito.Program.oUsuarioLogueado.Apellidos;
            cnx = pCnx;
            lblDetalle.Text = "";
            aceptar = false;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {

        }

        public bool validarCorreoElectronico()
        {
            string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";//Valida que tenga los caracteres de punto y el arroba

            if (Regex.IsMatch(txtCorreoElectronico.Text, expresion))//Si la expresion del correo electronico es valida entra al if
            {
                if (Regex.Replace(txtCorreoElectronico.Text, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool compararContraseña()
        {
            bool valido = txtContraseña.Text.Equals(txtVerificadorContrasenna.Text, StringComparison.Ordinal);
            return valido;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (oEmpleado.compararCedulaEmpleado(txtCedula.Text) == false)
                {
                    Empleadocs oEdit = new Empleadocs(cnx);
                    oEdit.agregarEmpleado(txtNombre.Text, txtApellidos.Text, txtCedula.Text, Convert.ToDateTime(dtpFechaNacimiento.Value), txtEdad.Text, cmbSexo.Text, txtTelefono.Text, txtCelular.Text, txtCorreoElectronico.Text, txtContraseña.Text, txtNombreUsuario.Text, cmbDepartamento.Text, DateTime.Now, UsuarioLogeado, UsuarioLogeado);
                    oEdit.agregarPrivilegios("false", "false", "false", "false", "false", "false");
                    if (oEdit.Error)
                    {
                        MessageBox.Show("Error al intentar agregar el empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (MessageBox.Show("Empleado agregado con éxito. ¿Desea asignar privilegios?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            frmModificarPrivilegios oPrvilegios = new frmModificarPrivilegios(cnx, txtCedula.Text);
                            oPrvilegios.ShowDialog();
                            if (MessageBox.Show("¿Desea registrar otro empleado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                            {
                                Close();
                            }
                            else
                            {
                                txtCedula.Text = "";
                                txtNombre.Text = "";
                                txtApellidos.Text = "";
                                dtpFechaNacimiento.Value = DateTime.Now;
                                txtTelefono.Text = "";
                                txtCelular.Text = "";
                                txtContraseña.Text = "";
                                txtVerificadorContrasenna.Text = "";
                                txtNombreUsuario.Text = "";
                                txtCorreoElectronico.Text = "";
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El código del empleado que intenta registrar ya se encuentra en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Error de datos por favor verifique los datos introducidos para continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txtNumeroEmpleado_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            lblNombre.ForeColor = System.Drawing.Color.Black;
        }

        private void txtApellidos_TextAlignChanged(object sender, EventArgs e)
        {
            lblApellidos.ForeColor = System.Drawing.Color.Black;
        }

        private void txtCorreoElectronico_TextChanged(object sender, EventArgs e)
        {
            lblCorreoElectronico.ForeColor = System.Drawing.Color.Black;
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            lblTelefono.ForeColor = System.Drawing.Color.Black;
        }

        private void numSalarioMensual_ValueChanged(object sender, EventArgs e)
        {
        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {
            lblApellidos.ForeColor = System.Drawing.Color.Black;
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            lblContrasenna.ForeColor = System.Drawing.Color.Black;
        }

        private void txtVerificadorContrasenna_TextChanged(object sender, EventArgs e)
        {
            lblVerifcarContraseña.ForeColor = System.Drawing.Color.Black;
        }

        private void txtNombreUsuario_TextChanged(object sender, EventArgs e)
        {
            lblNombreUsuario.ForeColor = System.Drawing.Color.Black;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSalarioMensual_TextChanged(object sender, EventArgs e)
        {
        }

        private void cmbTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                int annoActual = DateTime.Now.Year;
                int annoNacimiento = dtpFechaNacimiento.Value.Year;
                txtEdad.Text = (annoActual - annoNacimiento).ToString();
            }
            catch 
            {

            }
        }
        public string UsuarioLogeado
        {
            get { return usuarioLogeado; }
            set { usuarioLogeado = value; }
        }
        public bool Aceptar
        {
            get { return aceptar; }
            set { aceptar = value; }
        }
        public string Cedula
        {
            get { return txtCedula.Text; }
            set { txtCedula.Text = value; }
        }
        public string Nombre
        {
            get { return txtNombre.Text; }
            set { txtNombre.Text = value; }
        }
        public string Apellidos
        {
            get { return txtApellidos.Text; }
            set { txtApellidos.Text = value; }
        }
        public string FechaNacimiento 
        {
            set { dtpFechaNacimiento.Value.ToString(); }
            get { return dtpFechaNacimiento.Value.ToString(); }
        }
        public string Telefono
        {
            get { return txtTelefono.Text; }
            set { txtTelefono.Text = value; }
        }
        public string Celular 
        {
            get { return txtCelular.Text; }
            set { txtCelular.Text = value; }
        }
        public string Contrasenna
        {
            get { return txtContraseña.Text; }
            set { txtContraseña.Text = value; }
        }
        public string NombreUsuario
        {
            get { return txtNombreUsuario.Text; }
            set { txtNombreUsuario.Text = value; }
        }
        public string CorreoElectronico
        {
            get { return txtCorreoElectronico.Text; }
            set { txtCorreoElectronico.Text = value; }
        }
        public string Edad
        {
            get { return txtEdad.Text; }
            set { txtEdad.Text = value; }
        }
        public string Sexo
        {
            get { return cmbSexo.Text; }
            set { cmbSexo.Text = value; }
        }
        public string Departamento
        {
            get { return cmbDepartamento.Text; }
            set { cmbDepartamento.Text = value; }
        }
    }
}
