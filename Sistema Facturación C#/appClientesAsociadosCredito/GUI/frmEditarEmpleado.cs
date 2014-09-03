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
using Datos;

namespace GUI
{
    public partial class frmEditarEmpleado : Form
    {
        private bool aceptar;
        private string fechaCreacion;
        private string creadoPor;
        AccesoDatosMySql cnx;
        UsuarioL oUsuario;
        Empleadocs oElmpleado;
        public frmEditarEmpleado(bool pDashBoard, AccesoDatosMySql pCnx)
        {
            InitializeComponent();
            oUsuario = new UsuarioL();
            if (pDashBoard == true) 
            {
                txtCedula.Enabled = true;
                txtCedula.ReadOnly = false;
                cnx = pCnx;
                oElmpleado = new Empleadocs(cnx);
                btnCambiarContrasenna.Enabled = false;
            }
            aceptar = false;
        }
        public frmEditarEmpleado(
            string pCedula, string pNombre, string pApellidos, string pFechaNacimiento, 
            string pTelefono, string pCelular, string pNombreUsuario, string pEdad, 
            string pSexo,string pDepartamento, string pContrasenna, string pCorreoElectronico)
        {
            InitializeComponent();
            txtCedula.Text = pCedula;
            txtNombre.Text = pNombre;
            txtApellidos.Text = pApellidos;
            dtpFechaNacimiento.Value = Convert.ToDateTime(pFechaNacimiento);
            txtTelefono.Text = pTelefono;
            txtCelular.Text = pCelular;
            txtNombreUsuario.Text = pNombreUsuario;
            txtEdad.Text = pEdad;
            cmbSexo.Text = pSexo;
            cmbDepartamento.Text = pDepartamento;
            txtContrasenna.Text = pContrasenna;
            txtCorreo.Text = pCorreoElectronico;
            btnBuscar.Visible = false;
            btnLimpiar.Visible = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellidos.Text == "" || txtNombreUsuario.Text == "" || cmbSexo.Text == "" || cmbDepartamento.Text == "" || txtContrasenna.Text == "")
            {
                MessageBox.Show("Faltan datos importantes, por favor corrija para continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                oElmpleado.modificarEmpleado(txtNombre.Text, txtApellidos.Text, txtCedula.Text, dtpFechaNacimiento.Value, txtEdad.Text, cmbSexo.Text, txtTelefono.Text,
                                txtCelular.Text, txtCorreo.Text, txtContrasenna.Text, txtNombreUsuario.Text, Convert.ToDateTime(fechaCreacion),
                                cmbDepartamento.Text, appClientesAsociadosCredito.Program.oUsuarioLogueado.Nombre + " " + appClientesAsociadosCredito.Program.oUsuarioLogueado.Apellidos,
                                creadoPor);
                if (oElmpleado.Error)
                {
                    MessageBox.Show("Error inesperado al intentar modificar los datos del empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    if (MessageBox.Show("Empleado modificado satisfactoriamente.\n¿Desea modificar otro empleado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) 
                    {
                        Close();
                    }
                }
            }
        }

        private void cheBoxMostrarCaracteres_CheckedChanged(object sender, EventArgs e)
        {
            if (cheBoxMostrarCaracteres.Checked == true)
            {
                txtContrasenna.PasswordChar = '\0';
            }
            else if (txtContrasenna.Text != "")
            {
                txtContrasenna.PasswordChar = '●';
            }
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
        public DateTime FechaNacimiento
        {
            get { return dtpFechaNacimiento.Value; }
            set { dtpFechaNacimiento.Value = value; }
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
        public string NombreUsuario 
        {
            get { return txtNombreUsuario.Text; }
            set { txtNombreUsuario.Text = value; }
        }
        public string Edad 
        {
            get { return txtEdad.Text; }
            set { txtEdad.Text = value; }
        }
        public string CreadoPor
        {
            get { return creadoPor; }
            set { creadoPor = value; }
        }

        public string FechaCreacion
        {
            get { return fechaCreacion; }
            set { fechaCreacion = value; }
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
        public string Contrasenna 
        {
            get { return txtContrasenna.Text; }
            set { txtContrasenna.Text = value; }
        }
        public string Correo 
        {
            get { return txtCorreo.Text; }
            set { txtCorreo.Text = value; }
        }
        public bool Aceptar
        {
            get { return aceptar; }
            set { aceptar = value; }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarEmpleado oSearch = new frmBuscarEmpleado(cnx);
            oSearch.ShowDialog();
            if (oSearch.Aceptar) 
            {

                txtCedula.Text = oSearch.Retorno[0].Cedula;
                txtNombre.Text = oSearch.Retorno[0].Nombre;
                txtApellidos.Text= oSearch.Retorno[0].Apellidos;
                txtEdad.Text = oSearch.Retorno[0].Edad;
                txtTelefono.Text = oSearch.Retorno[0].Telefono;
                txtCelular.Text = oSearch.Retorno[0].Celular;
                txtNombreUsuario.Text = oSearch.Retorno[0].NombreUsuario;
                txtContrasenna.Text = oSearch.Retorno[0].Contrasenna;
                txtCorreo.Text = oSearch.Retorno[0].Email;
                dtpFechaNacimiento.Value = Convert.ToDateTime(oSearch.Retorno[0].FechaNacimiento);
                cmbDepartamento.Text = oSearch.Retorno[0].Departamento;
                cmbSexo.Text = oSearch.Retorno[0].Sexo;
                creadoPor = oSearch.Retorno[0].CreadoPor;
                fechaCreacion = oSearch.Retorno[0].FechaCreacion;
                ptbFotoPerfil.LoadAsync(oSearch.Retorno[0].DirecPerfil);
                if (txtContrasenna.Text != "")
                {
                    btnCambiarContrasenna.Enabled = true;
                }
                else 
                {
                    btnCambiarContrasenna.Visible = false;
                }
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtCedula.Text = "";
            dtpFechaNacimiento.Value = DateTime.Now;
            txtEdad.Text = "";
            cmbSexo.Text = "";
            txtTelefono.Text = "";
            txtCelular.Text = "";
            txtCorreo.Text = "";
            txtContrasenna.Text = "";
            txtNombreUsuario.Text = "";
            cmbDepartamento.Text = "";
            btnCambiarContrasenna.Enabled = false;
            txtCedula.Enabled = true;
            txtCedula.ReadOnly = false;
            ptbFotoPerfil.Image = null;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCambiarContrasenna_Click(object sender, EventArgs e)
        {
            try
            {
                    frmCambiarContrasenna oChange = new frmCambiarContrasenna(txtContrasenna.Text);
                    oChange.ShowDialog();
                    if (oChange.Aceptar == true)
                    {
                        if (txtContrasenna.Text == "")
                        {
                            btnCambiarContrasenna.Enabled = false;
                        }
                        else
                        {
                            oElmpleado.modificarEmpleado(txtNombre.Text, txtApellidos.Text, txtCedula.Text, dtpFechaNacimiento.Value, txtEdad.Text, cmbSexo.Text, txtTelefono.Text,
                                txtCelular.Text, txtCorreo.Text, oChange.ContrasennaNueva, txtNombreUsuario.Text, Convert.ToDateTime(fechaCreacion),
                                cmbDepartamento.Text, appClientesAsociadosCredito.Program.oUsuarioLogueado.Nombre + " " + appClientesAsociadosCredito.Program.oUsuarioLogueado.Apellidos,
                                creadoPor);
                            if (oElmpleado.Error)
                            {
                                MessageBox.Show("Error inesperado al intentar cambiar la contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                txtContrasenna.Text = oChange.ContrasennaNueva;
                                MessageBox.Show("Contraseña modificado satisfactoriamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
            }
            catch
            {
                MessageBox.Show("Error al intentar cambiar la contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    UsuarioD oEmpleado = new UsuarioD(cnx);
                    List<UsuarioL> respuesta = oEmpleado.obtenerEmpleado(new UsuarioL("","","","","","","","","","","","","",txtCedula.Text, "", "", ""));
                    if (oEmpleado.Error)
                    {
                        MessageBox.Show("Error inesperado al intentar obtener los registros solicitados.\nDetalle técnico: " + oEmpleado.ErrorDescription, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (respuesta.Count == 1)
                    {
                        txtNombre.Text = respuesta[0].Nombre;
                        txtApellidos.Text= respuesta[0].Apellidos; 
                        txtCedula.Text= respuesta[0].Cedula;
                        dtpFechaNacimiento.Value=Convert.ToDateTime(respuesta[0].FechaNacimiento);
                        txtEdad.Text= respuesta[0].Edad;
                        cmbSexo.Text= respuesta[0].Sexo;
                        txtTelefono.Text= respuesta[0].Telefono;
                        txtCelular.Text= respuesta[0].Celular; 
                        txtCorreo.Text= respuesta[0].Email; 
                        txtContrasenna.Text= respuesta[0].Contrasenna;
                        txtNombreUsuario.Text= respuesta[0].NombreUsuario; 
                        cmbDepartamento.Text= respuesta[0].Departamento;
                        btnCambiarContrasenna.Enabled = true;
                        txtCedula.Enabled = false;
                        txtCedula.ReadOnly = true;
                        
                    }
                    else
                    {
                        MessageBox.Show("No se han econtrado datos referentes al siguiente número de cédula: " + txtCedula.Text, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch 
            {
                MessageBox.Show("Error al intentar obtener los datos desde la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
