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
    public partial class frmBuscarProductos : Form
    {
        AccesoDatosMySql cnx;
        Inventario oInventario;
        private bool agregar;
        private string codigo;
        private string nombre;
        private string marca;
        private string descripcion;
        private string precioCompra;
        private string precioVenta;
        private string existencia;
        private string porcentaje;
        private string cantidad;
        private string fechaEntrada;
        public frmBuscarProductos(AccesoDatosMySql pCnx)
        {
            InitializeComponent();
            agregar = false;
            cnx = pCnx;
            oInventario = new Inventario(cnx);
            cargarDataGrid();
        }
        public void cargarDataGrid()
        {
            try
            {
                Inventario oProd = new Inventario(cnx);
                DataSet datos = oProd.ObtenerProductos().Copy();
                this.dgvProductos.DataSource = datos.Tables[0];
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
        private string valorCelda = String.Empty;
        private void dgvProductos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
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
            dgvProductos.Rows[e.RowIndex].Selected = true;
            //enviamos el valor de la celda a la variable _cellValue
            valorCelda = dgvProductos[e.ColumnIndex, e.RowIndex].Value.ToString();
            //Definimos el lugar donde aparecera el scontextMenuStrip
            menuClickDerecho.Show(MousePosition);
        }

        private void menuClickDerecho_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                int index = dgvProductos.CurrentRow.Index;
                menuClickDerecho.Visible = false;
                //Preguntamos por el nombre del item pulsado
                switch (e.ClickedItem.Name)
                {

                    case "itmAgregarProducto":
                        try
                        {
                            agregar = true;
                            codigo = dgvProductos[0, index].Value.ToString();
                            nombre = dgvProductos[1, index].Value.ToString();
                            marca = dgvProductos[2, index].Value.ToString();
                            descripcion = dgvProductos[3, index].Value.ToString();
                            precioCompra = dgvProductos[4, index].Value.ToString();
                            precioVenta = dgvProductos[5, index].Value.ToString();
                            existencia = dgvProductos[6, index].Value.ToString();
                            cantidad = dgvProductos[7, index].Value.ToString();
                            fechaEntrada = dgvProductos[8, index].Value.ToString();
                            Close();
                        }
                        catch
                        {

                        }
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Error inesperado al intentar indexar la fila seleccionada, si el problema persiste comuniquese con TI (Técnico Informatico).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvProductos.CurrentRow.Index;
                agregar = true;
                codigo = dgvProductos[0, index].Value.ToString();
                nombre = dgvProductos[1, index].Value.ToString();
                marca = dgvProductos[2, index].Value.ToString();
                descripcion = dgvProductos[3, index].Value.ToString();
                precioCompra = dgvProductos[4, index].Value.ToString();
                precioVenta = dgvProductos[5, index].Value.ToString();
                existencia = dgvProductos[6, index].Value.ToString();
                cantidad = dgvProductos[7, index].Value.ToString();
                fechaEntrada = dgvProductos[8, index].Value.ToString();
                Close();
            }
            catch 
            {

            }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public string Existencia
        {
            get { return existencia; }
            set { existencia = value; }
        }
        public bool Agregar
        {
            get { return agregar; }
            set { agregar = value; }
        }
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Porcentaje
        {
            get { return porcentaje; }
            set { porcentaje = value; }
        }
        public string PrecioVenta
        {
            get { return precioVenta; }
            set { precioVenta = value; }
        }
        public string PrecioCompra
        {
            get { return precioCompra; }
            set { precioCompra = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public string Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        public string FechaEntrada
        {
            get { return fechaEntrada; }
            set { fechaEntrada = value; }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtFiltro.Text == "")
                {
                    cargarDataGrid();
                }
                else
                {
                    string opcion = "descripcion";
                    DataSet oDatos = oInventario.FiltrarDatos(txtFiltro.Text, opcion).Copy();
                    try
                    {
                        dgvProductos.DataSource = oDatos.Tables[0];
                    }
                    catch
                    {
                        cargarDataGrid();
                    }
                }
            }
            catch 
            {

            }
        }
    }
}
