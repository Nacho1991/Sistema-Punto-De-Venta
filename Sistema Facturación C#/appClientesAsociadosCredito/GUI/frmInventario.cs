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
    public partial class frmAgregarProductosInventario : Form
    {
        AccesoDatosMySql cnx;
        private bool agregar;
        private bool isFacturacion;

        public frmAgregarProductosInventario(AccesoDatosMySql pCnx, bool pIsFacturacion)
        {
            InitializeComponent();
            this.cnx = pCnx;
            agregar = false;
            isFacturacion = pIsFacturacion;
            cargarDataGrid();

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
                Inventario oProd = new Inventario(cnx);
                DataSet datos = oProd.ObtenerProductosInventario().Copy();
                this.dgvProductosInventario.DataSource = datos.Tables[0];
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

        private void btnProducto_Click(object sender, EventArgs e)
        {

            if (this.dgvProductosInventario.RowCount > 1)
            {
                int fila = this.dgvProductosInventario.CurrentRow.Index;
                //Vallida si el que desean borrar es usuario y si la cantidad de Administradores son mayor a uno
                if (MessageBox.Show("¿Realmente desea eliminar el producto seleccionado?", "Confirmación",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Inventario oBorrarProducto = new Inventario(this.cnx);
                    int IdProducto = Convert.ToInt32(dgvProductosInventario[0, fila].Value.ToString());
                    oBorrarProducto.borrarProducto(IdProducto);
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
            if ((txtCantidad.Text == "") || (txtCodigoArticulo.Text == "") || (txtMarca.Text == "") || (txtPrecioCompra.Text == ""|| (txtNombreProducto.Text == "")))
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
                    int cantidad = Convert.ToInt32(txtCantidad.Text);
                    double precioCompra = Convert.ToDouble(txtPrecioCompra.Text);
                    double precioVenta = Convert.ToDouble(txtPrecioVenta.Text);
                    int codigo = Convert.ToInt32(txtCodigoArticulo.Text);
                    Inventario oProducto = new Inventario(cnx);
                    oProducto.agregarProductos(codigo, txtNombreProducto.Text, txtMarca.Text, txtDescripcion.Text, precioCompra, precioVenta, true, cantidad, DateTime.Now);
                    if (oProducto.Error)
                    {
                        MessageBox.Show("Error al agregar el producto en la base de datos.\n" + oProducto.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Producto agregado exitosamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.cargarDataGrid();
                        txtCantidad.Text = "";
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
            if (this.dgvProductosInventario.RowCount == 0)
            {
                int filaSeleccionada = dgvProductosInventario.CurrentRow.Index;
                if (this.dgvProductosInventario.RowCount > 0)
                {
                    if (MessageBox.Show("¿Realmente desea eliminar el producto seleccionado?", "Confirmación",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Inventario DeleteProduct = new Inventario(cnx);
                        int IdCkiente = Convert.ToInt32(dgvProductosInventario[0, filaSeleccionada].Value.ToString());
                        DeleteProduct.borrarProducto(IdCkiente);
                        if (DeleteProduct.ErrorDescripcion != "")
                        {
                            MessageBox.Show(DeleteProduct.ErrorDescripcion);
                            return;
                        }
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
        

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            if ((txtCantidad.Text == "") || (txtCodigoArticulo.Text == "") || (txtMarca.Text == "") || (txtPrecioCompra.Text == ""))
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
            get { return txtCantidad.Text; }
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
            if (txtBuscar.Text == "")
            {
                cargarDataGrid();
            }
            else
            {
                Inventario oInventario = new Inventario(cnx);
                DataSet oDatos = oInventario.FiltrarDatos(txtBuscar.Text).Copy();
                dgvProductosInventario.DataSource = oDatos.Tables[0];

                if (oInventario.Error)
                {
                    MessageBox.Show(oInventario.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dgvProductosInventario_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();
                m.MenuItems.Add(new MenuItem("Eliminar"));
                m.MenuItems.Add(new MenuItem("Editar"));
                int currentMouseOverRow = dgvProductosInventario.HitTest(e.X, e.Y).RowIndex;
                m.Show(dgvProductosInventario, new Point(e.X, e.Y));

            }
        }
    }
}


