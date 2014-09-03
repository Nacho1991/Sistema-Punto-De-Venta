using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;
using Datos;
using Logica;

namespace GUI
{
    public partial class frmControlGeneralClientes : Form
    {
        Cliente oCliente;
        ClienteD oClienteD;
        public frmControlGeneralClientes(AccesoDatosMySql pCnx)
        {
            InitializeComponent();
            oCliente = new Cliente(pCnx);
            oClienteD = new ClienteD(pCnx);
            cargarGrid();
            crearCodigoRegistros();
        }
        public void crearCodigoRegistros() 
        {
            byte[] bytes1 = new byte[100];
            Random rnd1 = new Random();
            txtNumeroRegistroAgregar.Text = (rnd1.Next(1, 100000000)).ToString();
        }
        public void cargarGrid()
        {
            try
            {
                DataSet datos = oCliente.ObtenerClientes().Copy();
                this.dgvRegistros.DataSource = datos.Tables[0];
                if (oCliente.IsError)
                {
                    MessageBox.Show("Error cargando los datos.\n" + oCliente.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error cargando los datos.\nDetalles técnicos: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Realmente desea eliminar el cliente selccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int index = dgvRegistros.CurrentRow.Index;
                    oCliente.borrarCliente(dgvRegistros[0, index].Value.ToString());
                    if (oCliente.IsError)
                    {
                        MessageBox.Show("Error al intentar eliminar al cliente seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        cargarGrid();
                        MessageBox.Show("Cliente eliminado satisfactoriamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch 
            {

            }
        }

        private void btnRegistrarAgregar_Click(object sender, EventArgs e)
        {
            if ((txtCedulaAgregar.Text == "") || (txtNombreAgregar.Text == "") || (txtApellidosAgregar.Text == "") || (txtDireccionAgregar.Text == "") || (cmbEstadoAgregar.Text == "") || (cmbPeriodoPagoAgregar.Text == "") || (txtMontoAcreditarAgregar.Text == ""))
            {
                MessageBox.Show("Imposible agregar datos, por favor rellene los campos respécticvos para continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    oCliente.agregarClienteCredito(txtCedulaAgregar.Text, txtNombreAgregar.Text, txtApellidosAgregar.Text, cmbTipoClienteAgregar.Text, txtTelefonoAgregar.Text, txtCelularAgregar.Text, txtDireccionAgregar.Text, appClientesAsociadosCredito.Program.oUsuarioLogueado.Nombre + " " + appClientesAsociadosCredito.Program.oUsuarioLogueado.Apellidos, cmbEstadoAgregar.Text);
                    if (oCliente.IsError)
                    {
                        MessageBox.Show("Error al agregar el producto en la base de datos.\n" + oCliente.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        cargarGrid();
                        oCliente.asignarCreditio(txtCedulaAgregar.Text, txtNumeroRegistroAgregar.Text, txtMontoAcreditarAgregar.Text, txtMontoActualAgregar.Text, cmbPeriodoPagoAgregar.Text,dtpFechaInicioCreditoEditar.Value);
                        lblNumeroClientes.Text = (dgvRegistros.RowCount).ToString();
                        txtCedulaAgregar.Text = "";
                        txtNombreAgregar.Text = "";
                        txtApellidosAgregar.Text = "";
                        txtDireccionAgregar.Text = "";
                        txtCelularAgregar.Text = "";
                        txtTelefonoAgregar.Text = "";
                        txtMontoAcreditarAgregar.Text = "";
                        MessageBox.Show("Cliente registrado y crédito asignado exitosamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBox.Show("Error en los datos, por favor corrija para continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtBuscarEditar_TextChanged(object sender, EventArgs e)
        {
            if (cmbOpcionesBusqueda.Text != "")
            {
                if (txtFiltrarDatos.Text == "")
                {
                    cargarGrid();
                }
                else
                {
                    string opcion = "";
                    if (cmbOpcionesBusqueda.SelectedIndex == 0)
                    {
                        opcion = "id_cedula";
                    }
                    else if (cmbOpcionesBusqueda.SelectedIndex == 1)
                    {
                        opcion = "Apellidos";
                    }
                    else if (cmbOpcionesBusqueda.SelectedIndex == 2)
                    {
                        opcion = "Estado_Cliente";
                    }
                    DataSet oDatos = oCliente.FiltrarDatos(txtFiltrarDatos.Text, opcion).Copy();
                    try
                    {
                        this.dgvRegistros.DataSource = oDatos.Tables[0];
                    }
                    catch 
                    {

                    }
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargarGrid();
        }

        private void dgvRegistros_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int index = dgvRegistros.CurrentRow.Index;
                List<ClienteL> respuesta = oClienteD.obtenerDetalles(dgvRegistros[0, index].Value.ToString());
                lblFechaEstablecidaEditar.Text = respuesta[0].InicioCredito;
                lblMontoDisponibleEditar.Text = respuesta[0].MontoActual;
                lblPeriodoPagoEditar.Text = respuesta[0].PeriodoPago;
                lblMontoCreditoEditar.Text = respuesta[0].MontoAcreditado;
                lblMontoDisponibleEditar.Text = respuesta[0].MontoActual;
                lblNumRegistro.Text = respuesta[0].Registro;
                lblEstadoClienteEditar.Text = dgvRegistros[2, index].Value.ToString();
                txtCedulaEditar.Text = dgvRegistros[0, index].Value.ToString();
                txtNombreEditar.Text = dgvRegistros[3, index].Value.ToString();
                txtApellidosEditar.Text = dgvRegistros[4, index].Value.ToString();
                txtDireccionEditar.Text = dgvRegistros[5, index].Value.ToString();
                cmbTipoClienteEditar.Text = dgvRegistros[1, index].Value.ToString();
                txtCelularEditar.Text = dgvRegistros[7, index].Value.ToString();
                txtTelefonoEditar.Text = dgvRegistros[6, index].Value.ToString();
            }
            catch 
            {

            }
        }
    }
}
