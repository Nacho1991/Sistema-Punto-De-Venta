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
    public partial class frmClientesAsociadosCredito : Form
    {
        AccesoDatosMySql cnx;
        string fechaModificacion;

        public frmClientesAsociadosCredito(AccesoDatosMySql pCnx)
        {
            InitializeComponent();
            fechaModificacion = "";
            cnx = pCnx;
            cargarGrid();
        }

        public bool buscadorCliente(string pCliente)
        {
            bool encontrado = false;

            int fila = dgvRegistroClientes.RowCount - 1;
            for (int fil = 0; fil < fila; fil++)
            {
                string datos = dgvRegistroClientes[0, fil].Value.ToString();
                if (datos == pCliente)
                {
                    encontrado = true;
                }

            }
            return encontrado;
        }

        public void cargarGrid()
        {
            try
            {
                RegistroClientesCredito registroCredito = new RegistroClientesCredito(cnx);
                DataSet datos = registroCredito.ObtenerRegistroClientesCredito().Copy();
                this.dgvRegistroClientes.DataSource = datos.Tables[0];
                if (registroCredito.Error)
                {
                    MessageBox.Show("Error cargando los datos.\n" + registroCredito.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error cargando los datos.\nDetalles técnicos: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void agregarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void actualizarDatosDelClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmActualizadorDatos oUpdate = new frmActualizadorDatos();
            oUpdate.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                frmAgregarCliente oAgree = new frmAgregarCliente(cnx);
                oAgree.ShowDialog();
                if (oAgree.Aceptar == true)
                {
                    frmPrincipal oPrin = new frmPrincipal(cnx);
                    RegistroClientesCredito oReg = new RegistroClientesCredito(cnx);
                    string habilitado = "Habilitado";
                    oReg.agregarAsociadoCredito(oAgree.Codigo, habilitado, oAgree.Cedula, oAgree.Nombre, oAgree.ApellidoUno, oAgree.ApellidoDos, oAgree.Direccion, oAgree.Telefono, oAgree.MontoAcreditar, "0", DateTime.Now, oPrin.TipoAcceso, oPrin.NombreEmpleado);
                    if (oReg.Error)
                    {
                        MessageBox.Show("Error al agregar en la base de datos.\n" + oReg.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Cliente agregado exitosamente en la base de datos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.cargarGrid();
                    }
                }
            }
            catch 
            {
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int fila = this.dgvRegistroClientes.CurrentRow.Index;
                if (this.dgvRegistroClientes.RowCount > 1)
                {
                    if (MessageBox.Show("¿Realmente desea eliminar el cliente seleccionado?", "Confirmación",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        RegistroClientesCredito oClientDelete = new RegistroClientesCredito(cnx);
                        string IdCkiente = this.dgvRegistroClientes[0, fila].Value.ToString();
                        oClientDelete.borrarCliente(IdCkiente);
                        if (oClientDelete.ErrorDescripcion != "")
                        {
                            MessageBox.Show(oClientDelete.ErrorDescripcion);
                            return;
                        }
                        this.cargarGrid();
                        MessageBox.Show("El registro del cliente se ha borrado satisfactoriamente.", "Borrado",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {
                    MessageBox.Show("No hay registro en la tabla", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch 
            {
                MessageBox.Show("Error no se ha seleccionado ninguna fila.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargarGrid();
        }

        private void btnEdicion_Click(object sender, EventArgs e)
        {
            try
            {
                fechaModificacion = Convert.ToString(DateTime.Now);
                int fila = dgvRegistroClientes.CurrentRow.Index;
                frmEditarClieteCredito oUpDate = new frmEditarClieteCredito(dgvRegistroClientes[0, fila].Value.ToString(), dgvRegistroClientes[1, fila].Value.ToString(), dgvRegistroClientes[3, fila].Value.ToString(), dgvRegistroClientes[4, fila].Value.ToString(), dgvRegistroClientes[5, fila].Value.ToString(), dgvRegistroClientes[6, fila].Value.ToString(), dgvRegistroClientes[7, fila].Value.ToString(), dgvRegistroClientes[8, fila].Value.ToString());
                oUpDate.ShowDialog();
                if (oUpDate.Aceptar == true)
                {
                    frmPrincipal oPrin = new frmPrincipal(cnx);
                    RegistroClientesCredito oReg = new RegistroClientesCredito(cnx);
                    DateTime fechaCreacion = Convert.ToDateTime(dgvRegistroClientes[11, fila].Value.ToString());
                    oReg.modificarCliente(oUpDate.Cedula, oUpDate.Nombre, oUpDate.EstadoCliente, oUpDate.PrimerApellido, oUpDate.SegundoApellido, oUpDate.Direccion, oUpDate.Telefono, oUpDate.LimiteCredito, "0", fechaCreacion, oUpDate.Codigo, DateTime.Now, oPrin.NombreEmpleado);
                    cargarGrid();
                }
            }
            catch
            {
                MessageBox.Show("Error no se ha seleccionado ninguna fila.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscador o = new frmBuscador(cnx);
            o.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realemnte desea cerrar sesion?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                Close();
            }
        }

        private void historialDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHistorialFacturacion oHis = new frmHistorialFacturacion(cnx);
            oHis.ShowDialog();
        }
        public string FechaModificacion
        {
            get { return fechaModificacion; }
            set { fechaModificacion = value; }
        }

        private void dgvRegistroClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int columna = dgvRegistroClientes.CurrentCell.ColumnIndex;
            MessageBox.Show("" + columna);
        }

        private void dgvRegistroClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
