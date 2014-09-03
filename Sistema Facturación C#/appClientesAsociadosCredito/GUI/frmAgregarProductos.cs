using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Logica;
using AccesoDatos;
using Datos;

namespace GUI
{
    public partial class frmAgregarProductos : Form
    {
        AccesoDatosMySql cnx;
        private bool agregar;
        private bool isFacturacion;
        Inventario oInventario;

        public frmAgregarProductos(AccesoDatosMySql pCnx, bool pIsFacturacion)
        {
            InitializeComponent();
            oInventario = new Inventario(pCnx);
            this.cnx = pCnx;
            isFacturacion = pIsFacturacion;
            inicializarComponentes();

        }
        public void inicializarComponentes()
        {
            try
            {
                cargarDataGrid();
                txtPrecioCompra.Text = "0";
                txtPrecioVenta.Text = "0";
                if (dgvProductosInventario.RowCount == 0)
                {
                    lblSinProductos.Visible = true;
                }
                else 
                {
                    lblSinProductos.Visible = false;
                }

                agregar = false;
                lblNumProductos.Text = (dgvProductosInventario.RowCount).ToString();
            }
            catch 
            {

            }
        }

        public bool buscadorCodigo()
        {
            bool encontrado = false;
            //int col = dgvProductosInventario.ColumnCount;
            int fil = dgvProductosInventario.RowCount;
            for (int fila = 0; fila < fil - 1; fila++)
            {
                string codigo = this.dgvProductosInventario[0, fila].Value.ToString();
                if (codigo == txtCodigoArticulo.Text)
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
                if (dgvProductosInventario.RowCount == 0) 
                {
                    lblNoDisponible.Visible = false;
                    lblDisponible.Visible = false;
                    lblSinProductos.Text = "Sin productos registrados";
                }
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

        private void btnProducto_Click(object sender, EventArgs e)
        {

            if (this.dgvProductosInventario.RowCount > 1)
            {
                int fila = this.dgvProductosInventario.CurrentRow.Index;
                //Vallida si el que desean borrar es usuario y si la cantidad de Administradores son mayor a uno
                if (MessageBox.Show("¿Realmente desea eliminar el producto seleccionado?", "Confirmación",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int filaSeleccionada = dgvProductosInventario.CurrentRow.Index;
                    Inventario oBorrarProducto = new Inventario(this.cnx);
                    oBorrarProducto.borrarProducto(dgvProductosInventario[0, filaSeleccionada].Value.ToString());
                    if (oBorrarProducto.ErrorDescripcion != "")
                    {
                        MessageBox.Show(oBorrarProducto.ErrorDescripcion);
                        return;
                    }
                    MessageBox.Show("El registro se ha borrado satisfactoriamente.", "Borrado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.cargarDataGrid();
                }
            }

            else
            {
                MessageBox.Show("No hay registro en la tabla.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if ((numCantidad.Text == "") || (txtCodigoArticulo.Text == "") || (txtMarca.Text == "") || (txtPrecioCompra.Text == ""|| (txtNombreProducto.Text == "")))
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
                    int cantidad = Convert.ToInt32(numCantidad.Text);
                    double precioCompra = Convert.ToDouble(txtPrecioCompra.Text);
                    double precioVenta = Convert.ToDouble(txtPrecioVenta.Text);
                    Inventario oProducto = new Inventario(cnx);
                    oProducto.agregarProductos(txtCodigoArticulo.Text, txtNombreProducto.Text, txtMarca.Text, txtDescripcion.Text, precioCompra, precioVenta, cbxExistencia.Checked, cantidad, DateTime.Now);
                    if (oProducto.Error)
                    {
                        MessageBox.Show("Error al agregar el producto en la base de datos.\n" + oProducto.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        lblNumProductos.Text = (dgvProductosInventario.RowCount).ToString();
                        this.cargarDataGrid();
                        MessageBox.Show("Producto agregado exitosamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        numCantidad.Value = 0;
                        txtCodigoArticulo.Text = "";
                        txtMarca.Text = "";
                        txtPrecioCompra.Text = "";
                        txtNombreProducto.Text = "";
                        txtDescripcion.Text = "";
                        txtPrecioVenta.Text = "";
                    }
                }
                catch 
                {
                    MessageBox.Show("Error en los datos, por favor corrija para continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvProductosInventario.RowCount > 0)
                {
                    int filaSeleccionada = dgvProductosInventario.CurrentRow.Index;
                    if (this.dgvProductosInventario.RowCount > 0)
                    {
                        if (MessageBox.Show("¿Realmente desea eliminar el producto seleccionado?", "Confirmación",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Inventario DeleteProduct = new Inventario(cnx);
                            DeleteProduct.borrarProducto(dgvProductosInventario[0, filaSeleccionada].Value.ToString());
                            if (DeleteProduct.ErrorDescripcion != "")
                            {
                                MessageBox.Show(DeleteProduct.ErrorDescripcion);
                                return;
                            }
                            lblNumProductos.Text = (dgvProductosInventario.RowCount).ToString();
                            this.cargarDataGrid();
                            MessageBox.Show("El registro del producto se ha borrado satisfactoriamente.", "Borrado",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay productos en la tabla.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("No hay productos en la tabla.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch 
            {

            }
        }
        

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            if ((numCantidad.Text == "") || (txtCodigoArticulo.Text == "") || (txtMarca.Text == "") || (txtPrecioCompra.Text == ""))
            {
                if (MessageBox.Show("No ha seleccionado nigún produto, ¿Desea continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    agregar = false;
                    Close();
                }
            }
            else
            {
                agregar = true;
                Close();
            }
        }

        public string Codigo
        {
            get { return txtCodigoArticulo.Text; }
        }
        public string Descripcion
        {
            get { return txtMarca.Text; }
        }
        public bool IsFacturacion
        {
            get { return isFacturacion; }
            set { isFacturacion = value; }
        }
        public string Cantidad
        {
            get { return numCantidad.Text; }
        }
        public string PrecioUnitario
        {
            get { return txtPrecioCompra.Text; }
        }
        public bool Agregar
        {
            get { return agregar; }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (cmbOpciones.Text != "")
            {
                if (txtBuscar.Text == "")
                {
                    cargarDataGrid();
                }
                else
                {
                    string opcion = "";
                    if (cmbOpciones.Text == "Código")
                    {
                        opcion = "id_producto";
                    }
                    else if (cmbOpciones.Text == "Descripción")
                    {
                        opcion = "descripcion";
                    }
                    else if (cmbOpciones.Text == "Marca")
                    {
                        opcion = "marca";
                    }
                    Inventario oInventario = new Inventario(cnx);
                    DataSet oDatos = oInventario.FiltrarDatos(txtBuscar.Text, opcion).Copy();
                    try
                    {
                        dgvProductosInventario.DataSource = oDatos.Tables[0];
                    }
                    catch 
                    {

                    }
                }
            }
        }

        private void dgvProductosInventario_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void numPorcentaje_ValueChanged(object sender, EventArgs e)
        {
            calculaPrecioVenta();
        }
        public void calculaPrecioVenta() 
        {
            try
            {
                float precioCompra = float.Parse(txtPrecioCompra.Text);
                float porcentaje = (float)numPorcentaje.Value;
                txtPrecioVenta.Text = (precioCompra+(precioCompra*(porcentaje / 100))).ToString();

            }
            catch 
            {
                MessageBox.Show("Posible dato numerico incorrecto por favor verique para continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                                    lblNumProductos.Text = (dgvProductosInventario.RowCount).ToString();
                                    MessageBox.Show("Producto eliminado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                        catch
                        {

                        }
                        break;
                    case "itmEditar":
                        menuClickDerecho.Visible = false;
                        frmEditarProducto oEdit = new frmEditarProducto
                            (
                                dgvProductosInventario[0, index].Value.ToString(),
                                dgvProductosInventario[1, index].Value.ToString(),
                                dgvProductosInventario[2, index].Value.ToString(),
                                dgvProductosInventario[3, index].Value.ToString(),
                                dgvProductosInventario[4, index].Value.ToString(),
                                dgvProductosInventario[5, index].Value.ToString(),
                                dgvProductosInventario[7, index].Value.ToString(),
                                Convert.ToBoolean(dgvProductosInventario[6, index].Value.ToString()));
                        oEdit.ShowDialog();
                        if (oEdit.Aplicar == true)
                        {
                            oInventario.modificarProducto(oEdit.Codigo, oEdit.Nombre,oEdit.Marca, oEdit.Descripcion, Convert.ToDouble(oEdit.PrecioVenta), Convert.ToDouble(oEdit.PrecioCompra), oEdit.Existencia, Convert.ToInt32(oEdit.Cantida), Convert.ToDateTime(dgvProductosInventario[8, index].Value.ToString()));
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
                }
            }
            catch
            {
                MessageBox.Show("Error inesperado al intentar indexar la fila seleccionada, si el problema persiste comuniquese con TI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPrecioCompra_TextChanged(object sender, EventArgs e)
        {
            if (txtPrecioCompra.Text == "") 
            {
                txtPrecioCompra.Text = "0";
                txtPrecioVenta.Text = "0";
            }
            if (numPorcentaje.Value == 0)
            {
                txtPrecioVenta.Text = txtPrecioCompra.Text;
            }
            else 
            {
                calculaPrecioVenta();
            }
        }

        private void dgvProductosInventario_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int index = dgvProductosInventario.CurrentRow.Index;
                if (dgvProductosInventario[6, index].Value.ToString() == "True")
                {
                    lblDisponible.Visible = true;
                    lblNoDisponible.Visible = false;
                }
                else if (dgvProductosInventario[6, index].Value.ToString() == "False")
                {
                    lblNoDisponible.Visible = true;
                    lblDisponible.Visible = false;
                }
            }
            catch { }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargarDataGrid();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int index = dgvProductosInventario.CurrentRow.Index;
            frmEditarProducto oEdit = new frmEditarProducto(
                dgvProductosInventario[0, index].Value.ToString(),
                                dgvProductosInventario[1, index].Value.ToString(),
                                dgvProductosInventario[2, index].Value.ToString(),
                                dgvProductosInventario[3, index].Value.ToString(),
                                dgvProductosInventario[4, index].Value.ToString(),
                                dgvProductosInventario[5, index].Value.ToString(),
                                dgvProductosInventario[7, index].Value.ToString(),
                                Convert.ToBoolean(dgvProductosInventario[6, index].Value.ToString()));
            oEdit.ShowDialog();
            if (oEdit.Aplicar)
            {
                oInventario.modificarProducto(oEdit.Codigo, oEdit.Nombre, oEdit.Marca, oEdit.Descripcion, Convert.ToDouble(oEdit.PrecioVenta), Convert.ToDouble(oEdit.PrecioCompra), oEdit.Existencia, Convert.ToInt32(oEdit.Cantida), Convert.ToDateTime(dgvProductosInventario[8, index].Value.ToString()));
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
        }
    }
}


