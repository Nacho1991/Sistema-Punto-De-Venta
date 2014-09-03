using AccesoDatos;
using Datos;
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
    public partial class frmControlGeneralInventario : Form
    {
        AccesoDatosMySql cnx;
        Inventario oInventario;
        public frmControlGeneralInventario(AccesoDatosMySql pCnx)
        {
            InitializeComponent();
            oInventario = new Inventario(pCnx);
            cargarDataGrid();
            lblInfoCantidad.Text = (dgvProductosInventario.RowCount).ToString();
            numPrecioVentaAgregar.Enabled = false;
        }
        public bool buscadorCodigo()
        {
            bool encontrado = false;
            int fil = dgvProductosInventario.RowCount;
            for (int fila = 0; fila < fil - 1; fila++)
            {
                string codigo = this.dgvProductosInventario[0, fila].Value.ToString();
                if (codigo == txtCodigoArticuloAgregar.Text)
                {
                    encontrado = true;
                }
            }
            return encontrado;
        }
        public void cargarDataGrid()
        {
            try
            {
                DataSet datos = oInventario.ObtenerProductos().Copy();
                this.dgvProductosInventario.DataSource = datos.Tables[0];
                if (oInventario.Error)
                {
                    MessageBox.Show("Error cargando los datos.\n" + oInventario.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error cargando los datos.\nDetalles técnicos: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if ((numCantidadAgregar.Value == 0) || (txtCodigoArticuloAgregar.Text == "") || (txtMarcaAgregar.Text == "") || ((txtNombreProductoAgregar.Text == "")))
            {
                MessageBox.Show("Imposible agregar datos, por favor rellene los campos respécticvos para continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (this.buscadorCodigo() == true)
            {
                MessageBox.Show("El código que intenta agregar ya existe en la base de datos por favor corrija para continuar.", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    double precioCompra = Convert.ToDouble(numPrecioCompraAgregar.Value);
                    double precioVenta = Convert.ToDouble(numPrecioVentaAgregar.Value);
                    oInventario.agregarProductos(txtCodigoArticuloAgregar.Text, txtNombreProductoAgregar.Text, txtMarcaAgregar.Text, txtDescripcionAgregar.Text, precioCompra, precioVenta, ckbExistenciaAgregar.Checked, Convert.ToInt32(numCantidadAgregar.Value), DateTime.Now);
                    if (oInventario.Error)
                    {
                        MessageBox.Show("Error al agregar el producto en la base de datos.\n" + oInventario.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Producto agregado exitosamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.cargarDataGrid();
                        numCantidadAgregar.Value = 0;
                        txtCodigoArticuloAgregar.Text = "";
                        txtMarcaAgregar.Text = "";
                        numPrecioVentaAgregar.Value = 0;
                        txtNombreProductoAgregar.Text = "";
                        txtDescripcionAgregar.Text = "";
                        numPrecioCompraAgregar.Value = 0;
                        ckbExistenciaAgregar.Checked = false;
                    }
                }
                catch
                {
                    MessageBox.Show("Error en los datos, por favor corrija para continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void dgvProductosInventario_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int index = dgvProductosInventario.CurrentRow.Index;
                txtCodigoProductoEditar.Text = dgvProductosInventario[0, index].Value.ToString();
                txtNombreEditar.Text = dgvProductosInventario[1, index].Value.ToString();
                txtMarcaEditar.Text = dgvProductosInventario[2, index].Value.ToString();
                txtDescripcionEditar.Text = dgvProductosInventario[3, index].Value.ToString();
                txtPrecioCompraEditar.Text = dgvProductosInventario[4, index].Value.ToString();
                txtPrecioVentaEditar.Text = dgvProductosInventario[5, index].Value.ToString();
                numCantidadEditar.Text = dgvProductosInventario[7, index].Value.ToString();
                ckbExistenciaEditar.Checked = Convert.ToBoolean(dgvProductosInventario[6, index].Value.ToString());
                if (Convert.ToBoolean(dgvProductosInventario[6, index].Value.ToString()) == true)
                {
                    lblDisponible.Visible = true;
                    lblNoDisponible.Visible = false;
                }
                else if (Convert.ToBoolean(dgvProductosInventario[6, index].Value.ToString()) == false)
                {
                    lblDisponible.Visible = false;
                    lblNoDisponible.Visible = true;
                }
            }
            catch
            {

            }
        }
        private void btnCancelarAgregar_Click(object sender, EventArgs e)
        {

        }

        private void txtFiltrarDatos_TextChanged(object sender, EventArgs e)
        {
            if (cmbOpcionesBusqueda.Text != "")
            {
                if (txtFiltrarDatos.Text == "")
                {
                    cargarDataGrid();
                }
                else
                {
                    string opcion = "";
                    if (cmbOpcionesBusqueda.SelectedIndex == 0)
                    {
                        opcion = "id_producto";
                    }
                    else if (cmbOpcionesBusqueda.SelectedIndex == 1)
                    {
                        opcion = "descripcion";
                    }
                    else if (cmbOpcionesBusqueda.SelectedIndex == 2)
                    {
                        opcion = "marca";
                    }

                    DataSet oDatos = oInventario.FiltrarDatos(txtFiltrarDatos.Text, opcion).Copy();
                    try
                    {
                        dgvProductosInventario.DataSource = oDatos.Tables[0];
                    }
                    catch
                    {
                        cargarDataGrid();
                    }
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvProductosInventario.CurrentRow.Index;
                if (MessageBox.Show("¿Realmente desea eliminar el producto seleccionado.?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    oInventario.borrarProducto(dgvProductosInventario[0, index].Value.ToString());
                    if (oInventario.Error)
                    {
                        MessageBox.Show("Error inesperado al intentar borrar el registro seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        cargarDataGrid();
                        lblInfoCantidad.Text = (dgvProductosInventario.RowCount).ToString();
                        MessageBox.Show("Producto eliminado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch 
            {

            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            try
            {
                int index = dgvProductosInventario.CurrentRow.Index;
                oInventario.modificarProducto(
                    txtCodigoProductoEditar.Text, 
                    txtNombreEditar.Text,
                    txtMarcaEditar.Text,
                    txtDescripcionEditar.Text,
                    Convert.ToDouble(txtPrecioVentaEditar.Text),
                    Convert.ToDouble(txtPrecioCompraEditar.Text),
                    ckbExistenciaEditar.Checked,
                    Convert.ToInt32(numCantidadEditar.Value),
                    Convert.ToDateTime(dgvProductosInventario[8, index].Value.ToString()));
                if (oInventario.Error)
                {
                    MessageBox.Show("Se ha creado un error al intentar editar el producto.\nDetalle técnico: " + oInventario.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cargarDataGrid();
                    MessageBox.Show("Se ha modificado exitosamente el producto.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch 
            {

            }
        }

        private void numPorcentajeEditar_ValueChanged(object sender, EventArgs e)
        {
            calculaPrecioVenta();
        }
        public void calculaPrecioVenta()
        {
            try
            {
                float precioCompra = float.Parse(numPrecioVentaAgregar.Value.ToString());
                float porcentaje = (float)numPorcentajeAgregar.Value;
                numPrecioVentaAgregar.Text = (precioCompra + (precioCompra * (porcentaje / 100))).ToString();

            }
            catch
            {
                MessageBox.Show("Posible dato numerico incorrecto por favor verique para continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void numPorcentajeAgregar_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                float precioCompra = float.Parse(numPrecioCompraAgregar.Text);
                float porcentaje = (float)numPorcentajeAgregar.Value;
                numPrecioVentaAgregar.Text = (precioCompra + (precioCompra * (porcentaje / 100))).ToString();
            }
            catch
            {
                MessageBox.Show("Posible dato numerico incorrecto por favor verique para continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargarDataGrid();
        }
        private string valorCelda = String.Empty;
        private void dgvRegistros_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Preguntamos si el boton pulsado del Mouse es el Derecho
            //si no lo es no salimos sin hacer nada mas
            if (e.Button != MouseButtons.Right)
            {
                return;
            }
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }
            dgvProductosInventario.Rows[e.RowIndex].Selected = true;
            //enviamos el valor de la celda a la variable _cellValue
            valorCelda = dgvProductosInventario[e.ColumnIndex, e.RowIndex].Value.ToString();
            //Definimos el lugar donde aparecera el scontextMenuStrip
            menuClickDerecho.Show(MousePosition);
        }

        private void menuClickDerecho_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                int index = dgvProductosInventario.CurrentRow.Index;
                //Preguntamos por el nombre del item pulsado
                switch (e.ClickedItem.Name)
                {
                    case "itmCopiarCelda":
                        menuClickDerecho.Visible = false;
                        //Copiamos el valor de la variable valorCelda al ClipBoard
                        Clipboard.SetText(valorCelda);
                        break;

                    case "itmEliminar":
                        try
                        {
                            menuClickDerecho.Visible = false;
                            if (MessageBox.Show("¿Realmente desea eliminar el producto seleccionado.?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                oInventario.borrarProducto(dgvProductosInventario[0, index].Value.ToString());
                                if (oInventario.Error)
                                {
                                    MessageBox.Show("Error inesperado al intentar borrar el registro seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    cargarDataGrid();
                                    lblInfoCantidad.Text = (dgvProductosInventario.RowCount).ToString();
                                    MessageBox.Show("Producto eliminado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                        catch
                        {

                        }
                        break;
                    case "itmDetalles":
                        break;
                    case "itmEditar":
                        menuClickDerecho.Visible = false;
                        frmEditarProducto oEdit = new frmEditarProducto
                            (
                                dgvProductosInventario[0,index].Value.ToString(),
                                dgvProductosInventario[1,index].Value.ToString(),
                                dgvProductosInventario[2,index].Value.ToString(),
                                dgvProductosInventario[3,index].Value.ToString(),
                                dgvProductosInventario[4,index].Value.ToString(),
                                dgvProductosInventario[5,index].Value.ToString(),
                                dgvProductosInventario[7, index].Value.ToString(),
                                Convert.ToBoolean(dgvProductosInventario[6,index].Value.ToString()));
                        oEdit.ShowDialog();
                        if (oEdit.Aplicar == true) 
                        {
                            oInventario.modificarProducto(oEdit.Codigo, oEdit.Nombre,oEdit.Marca, oEdit.Descripcion,Convert.ToDouble(oEdit.PrecioVenta), Convert.ToDouble(oEdit.PrecioCompra), oEdit.Existencia, Convert.ToInt32(oEdit.Cantida), Convert.ToDateTime(dgvProductosInventario[8, index].Value.ToString()));
                            if (oInventario.Error)
                            {
                                MessageBox.Show("Error inesperado al intentar modificar el producto seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else 
                            {
                                cargarDataGrid();
                                MessageBox.Show("Producto modificado satisfactoriamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        break;
                    case "itmPrivilegios":
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Error inesperado al intentar indexar la fila seleccionada, si el problema persiste comuniquese con TI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
