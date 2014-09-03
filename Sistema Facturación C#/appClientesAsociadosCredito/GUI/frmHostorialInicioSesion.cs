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
using System.Diagnostics;
using AccesoDatos;
using Datos;

namespace GUI
{
    public partial class frmHostorialInicioSesion : Form
    {
        AccesoDatosMySql cnx;
        private UsuarioL oUsuarioL;

        public frmHostorialInicioSesion(AccesoDatosMySql pCnx)
        {
            InitializeComponent();
            cnx = pCnx;
            cargarDataGrid();
        }

        public void cargarDataGrid()
        {
            try
            {
                RegistroInicioSesion oInicio = new RegistroInicioSesion(cnx);
                DataSet datos = oInicio.ObtenerRegistrosInicioSesion().Copy();
                this.dgvRegistroInicioSesion.DataSource = datos.Tables[0];
                if (oInicio.Error)
                {
                    MessageBox.Show("Error cargando los datos.\n" + oInicio.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error cargando los datos.\nDetalles técnicos: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void dgvRegistroInicioSesion_MouseClick(object sender, MouseEventArgs e)
        {
            int fila = dgvRegistroInicioSesion.CurrentRow.Index;
            ObtenerDatosEmpleado oDate = new ObtenerDatosEmpleado(cnx);
            oDate.extractor(txtCodigoEmpleado.Text);
            txtCodigoEmpleado.Text = dgvRegistroInicioSesion[1, fila].Value.ToString();
            txtNombreEmpleado.Text = oDate.Nombre;
            txtApellidos.Text = oDate.Apellidos;
            txtCedula.Text = oDate.Cedula;
            txtDepartamento.Text = oDate.Departamento;
            txtEdad.Text = oDate.Edad;
            txtFechaCreacion.Text = oDate.FechaCreacion;
            txtDepartamento.Text = oDate.Departamento;
            txtSalario.Text = oDate.SalarioMensual;
            txtTelefono.Text = oDate.Telefono;
            txtCelular.Text = oDate.Celular;
            txtTipoCargo.Text = oDate.TipoCargo;
        }
    }
}
