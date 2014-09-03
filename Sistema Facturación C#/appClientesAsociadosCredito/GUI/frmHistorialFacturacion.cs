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
    public partial class frmHistorialFacturacion : Form
    {
        AccesoDatosMySql cnx;

        public frmHistorialFacturacion(AccesoDatosMySql pCnx)
        {
            InitializeComponent();
            cnx = pCnx;
            cargarDataGrid();
            cargarComboBox();
            lblNumeroRegistro.Text = (dgvTablaHistorial.RowCount - 1).ToString();
        }

        public void cargarComboBox() 
        {
            try
            {
                RegistrarFactura oProd = new RegistrarFactura(cnx);
                DataSet datos = oProd.obtenerFacturas().Copy();
                cmbClinete.DataSource = datos.Tables[0].DefaultView; //Cargar el comboBox
                cmbClinete.ValueMember = "nombreCliente"; //Se selecciona que contenido de la columna se mostrara...
                if (oProd.Error)
                {
                    MessageBox.Show("Error cargando los datos.\n" + oProd.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error cargando los datos.\nDetalles técnicos: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cargarDataGrid()
        {
            try
            {
                RegistrarFactura oProd = new RegistrarFactura(cnx);
                DataSet datos = oProd.obtenerFacturas().Copy();
                this.dgvTablaHistorial.DataSource = datos.Tables[0];
                if (oProd.Error)
                {
                    MessageBox.Show("Error cargando los datos.\n" + oProd.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public void verificadorCantResultados() 
        {
            int numItems = dgvTablaHistorial.RowCount - 1;
            if (numItems == 2)
            {
                lblCantidadItemsBusqueda.Text = numItems.ToString();
                lblInfoBusqueda.Text = "Elementos econtrados";
            }
            else if (numItems > 1)
            {
                lblCantidadItemsBusqueda.Text = numItems.ToString();
                lblInfoBusqueda.Text = "Elementos econtrados";
            }
            else if (numItems == 1)
            {
                lblCantidadItemsBusqueda.Text = numItems.ToString();
                lblInfoBusqueda.Text = "Elemento econtrado";
            }

            else if (numItems == 0)
            {
                lblCantidadItemsBusqueda.Text = numItems.ToString();
                lblInfoBusqueda.Text = "Elementos econtrados";
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cheBoxCedula.Checked)
            {
                this.buscadorDatosPorCedula(txtCedula.Text);
                borradoFilasVacias();
                verificadorCantResultados();
            }
            else if (cheBoxTipoVenta.Checked) 
            {
                this.buscadorDatosPorTipoVenta(cmbBoxTipoVenta.Text);
                borradoFilasVacias();
                verificadorCantResultados();
            }
            else if (cheBoxPorFechas.Checked)
            {
                buscadorDatosPorRangoFechas();
                borradoFilasVacias();
                verificadorCantResultados();
            }
        }
        const int initialSize = 5000000;
        int numberOfRows = initialSize;
        bool newRowNeeded;

        private void dgvTablaHistorial_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (newRowNeeded)
            {
                newRowNeeded = false;
                numberOfRows = numberOfRows + 1;
            }
        }

        private void dgvTablaHistorial_NewRowNeeded(object sender, DataGridViewRowEventArgs e)
        {
            newRowNeeded = true;
        }
        //Metodo encargado de buscar diferencias de tipoCuenta para ser eliminadas
        public void buscadorDatosPorTipoVenta(string pTipo) 
        {
            try
            {
                int cantfila = dgvTablaHistorial.RowCount - 2;
                int catntColum = dgvTablaHistorial.ColumnCount;
                int fila = 0;
                foreach (DataGridViewRow row in dgvTablaHistorial.Rows)
                {
                    if (fila < dgvTablaHistorial.RowCount - 1)
                    {
                        string tipo = dgvTablaHistorial[7, fila].Value.ToString();
                        if (tipo != pTipo)
                        {
                            for (int col = 0; col < catntColum; col++)
                            {
                                this.dgvTablaHistorial[col, fila].Value = DBNull.Value;
                            }
                            fila++;
                        }
                        else
                        {
                            fila++;
                        }
                    }
                }
            }
            catch 
            {
                MessageBox.Show("Error de sintaxis, no se puede mostrar resultados de la búsqueda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void buscadorDatosPorRangoFechas()
        {
            try
            {
                int fila = 0;
                int catntColum = dgvTablaHistorial.ColumnCount;
                int cantfila = dgvTablaHistorial.RowCount - 2;
                DateTime fechaInicio = Convert.ToDateTime(dtpDesde.Text);
                DateTime fechaFinal = Convert.ToDateTime(dtpHasta.Text);

                foreach (DataGridViewRow row in dgvTablaHistorial.Rows)
                {
                    if (fila < dgvTablaHistorial.RowCount - 1)
                    {
                        DateTime fechaRango = Convert.ToDateTime(dgvTablaHistorial[10, fila].Value.ToString());
                        for (int col = 0; col < catntColum; col++)
                        {
                            if ((fechaRango >= fechaInicio) && (fechaRango <= fechaFinal))
                            {
                                break;
                            }
                            else
                            {
                                this.dgvTablaHistorial[col, fila].Value = DBNull.Value;
                            }
                        }
                        fila++;
                    }
                }
            }
            catch 
            {
                MessageBox.Show("Error de sintaxis, no se puede mostrar resultados de la búsqueda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Metodo encargado de buscar diferencias de cédulas para ser eliminadas
        public void buscadorDatosPorCedula(string pCedula) 
        {
            try
            {
                int cantfila = dgvTablaHistorial.RowCount - 1;
                int catntColum = dgvTablaHistorial.ColumnCount;
                int fila = 0;
                foreach (DataGridViewRow row in dgvTablaHistorial.Rows)
                {
                    if (fila < dgvTablaHistorial.RowCount - 1)
                    {
                        string tipoVenta = cmbBoxTipoVenta.Text;
                        string estado = cmbBoxEstado.Text;
                        DateTime fechaDesde = Convert.ToDateTime(dtpDesde.Text);
                        DateTime fechaHasta = Convert.ToDateTime(dtpHasta.Text);
                        string cedula = dgvTablaHistorial[3, fila].Value.ToString();
                        if (cedula != pCedula)
                        {
                            for (int col = 0; col < catntColum; col++)
                            {
                                this.dgvTablaHistorial[col, fila].Value = DBNull.Value;
                            }
                            fila++;
                        }
                        else
                        {
                            fila++;
                        }
                    }
                }
            }
            catch 
            {
                MessageBox.Show("Error de sintaxis, no se puede mostrar resultados de la búsqueda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Metodo encargado de borrar las líneas que se encuentran vacias y reacomoda el DataGridView
        public void borradoFilasVacias()
        {
            try
            {
                for (int n = dgvTablaHistorial.Rows.Count - 2; n >= 0; n += -1)
                {
                    DataGridViewRow row = dgvTablaHistorial.Rows[n];
                    if (row.Cells[1].Value.ToString() == "")
                    {
                        dgvTablaHistorial.Rows.Remove(row);
                    }
                }
            }
            catch 
            {
                MessageBox.Show("Error de sintaxis, no se puede mostrar resultados de la búsqueda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cargarDataGrid();
            verificadorCantResultados();
        }

        private void btnBorrarHistorial_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Si procede se perderan los datos selecccionados sin podersen restaurar, ¿Desea continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    int cantfila = dgvTablaHistorial.RowCount - 2;
                    int catntColum = dgvTablaHistorial.ColumnCount;
                    int fila = 0;
                    foreach (DataGridViewRow row in dgvTablaHistorial.Rows)
                    {
                        if (fila < dgvTablaHistorial.RowCount - 1)
                        {
                            bool cheked = Convert.ToBoolean(dgvTablaHistorial[0, fila].Value);
                            if (cheked)
                            {
                                RegistrarFactura oElimarFact = new RegistrarFactura(cnx);
                                string IDFactura = this.dgvTablaHistorial[1, fila].Value.ToString();
                                oElimarFact.borrarHistorialFactura(IDFactura);
                                if (oElimarFact.ErrorDescripcion != "")
                                {
                                    MessageBox.Show(oElimarFact.ErrorDescripcion);
                                    return;
                                }
                                fila++;
                            }
                            else
                            {
                                fila++;
                            }
                        }
                    }
                    this.borradoFilasVacias();
                    MessageBox.Show("El registro del historial se ha borrado satisfactoriamente.", "Borrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.cargarDataGrid();
                }
            }
            catch 
            {
                MessageBox.Show("Error de sintaxis, no se puede continuar con la eliminación del historial seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAnularVenta_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow rowp in dgvTablaHistorial.Rows)
            {
                int fila = dgvTablaHistorial.CurrentRow.Index;
                dgvTablaHistorial.Rows[fila].DefaultCellStyle.BackColor = Color.Yellow;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            int fila = dgvTablaHistorial.CurrentRow.Index;
            dgvTablaHistorial.Rows[fila].DefaultCellStyle.BackColor = Color.Blue;
        }

        private void btnAbonos_Click(object sender, EventArgs e)
        {
            int fila = dgvTablaHistorial.CurrentRow.Index;
            dgvTablaHistorial.Rows[fila].DefaultCellStyle.BackColor = Color.Olive;
        }
    }
}
