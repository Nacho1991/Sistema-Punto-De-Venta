using AccesoDatos;
using Datos;
using Logica;
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
    public partial class frmEditarProducto : Form
    {
        private bool aplicar;
        AccesoDatosMySql cnx;
        private bool dashBoard;
        private string fechaEntrada;
        public frmEditarProducto(bool pDashBoard,AccesoDatosMySql pCnx) 
        {
            InitializeComponent();
            cnx = pCnx;
            dashBoard = pDashBoard;
            if (pDashBoard == true)
            {
                txtCodigoArticulo.Enabled = true;
                txtCodigoArticulo.ReadOnly = false;
            }
        }
        public frmEditarProducto(string pCodigo,string pNombre,string pMarca,string pDescripcion,string pPrecioCompra,string pPrecioVenta,string pCantidad,bool pExistencia)
        {
            InitializeComponent();
            txtCodigoArticulo.Text = pCodigo;
            txtNombreProducto.Text = pNombre;
            txtMarca.Text = pMarca;
            txtDescripcion.Text = pDescripcion;
            numPrecioCompra.Value = Convert.ToInt32(pPrecioCompra);
            numPrecioVenta.Text = pPrecioVenta;
            numCantidad.Value = Convert.ToInt32(pCantidad);
            ckbExistencia.Checked = pExistencia;
            aplicar = false;
            btnBuscar.Visible = false;
            btnLimpiar.Visible = false;
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            if (dashBoard == true)
            {
                Inventario oInventario = new Inventario(cnx);
                oInventario.modificarProducto(txtCodigoArticulo.Text, txtNombreProducto.Text, txtMarca.Text, txtDescripcion.Text,
                    Convert.ToDouble(numPrecioVenta.Value), Convert.ToDouble(numPrecioCompra.Value), ckbExistencia.Checked, Convert.ToInt32(numCantidad.Value), Convert.ToDateTime(fechaEntrada));
                if (oInventario.Error)
                {
                    MessageBox.Show("Error inesperado al intentar editar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    if (MessageBox.Show("Producto satisfactoriamente modificado.\n¿Desea modificar otro producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        Close();
                    }
                    else 
                    {
                        txtCodigoArticulo.Text = "";
                        txtDescripcion.Text = "";
                        txtMarca.Text = "";
                        txtNombreProducto.Text = "";
                        numPrecioCompra.Value = 0;
                        numPrecioVenta.Value = 0;
                        numPorcentaje.Value = Convert.ToDecimal(0.0);
                        numCantidad.Value = 0;
                        ckbExistencia.Checked = false;
                    }
                }
            }
            else
            {
                aplicar = true;
                Close();
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarProductos oSearch = new frmBuscarProductos(cnx);
            oSearch.ShowDialog();
            if (oSearch.Agregar)
            {
                txtCodigoArticulo.Text = oSearch.Codigo;
                txtDescripcion.Text = oSearch.Descripcion;
                txtMarca.Text = oSearch.Marca;
                txtNombreProducto.Text = oSearch.Nombre;
                ckbExistencia.Checked = Convert.ToBoolean(oSearch.Existencia);
                numPrecioCompra.Value = Convert.ToDecimal(oSearch.PrecioCompra);
                numPrecioVenta.Value = Convert.ToDecimal(oSearch.PrecioVenta);
                numCantidad.Value = Convert.ToInt32(oSearch.Cantidad);
                numPorcentaje.Value = Convert.ToDecimal(oSearch.Porcentaje);
                fechaEntrada = oSearch.FechaEntrada;
                txtCodigoArticulo.Enabled = false;
                txtCodigoArticulo.ReadOnly = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigoArticulo.Text = "";
            txtDescripcion.Text = "";
            txtMarca.Text = "";
            txtNombreProducto.Text = "";
            numPrecioCompra.Value = 0;
            numPrecioVenta.Value = 0;
            numPorcentaje.Value = Convert.ToDecimal(0.0);
            numCantidad.Value = 0;
            ckbExistencia.Checked = false;
            txtCodigoArticulo.ReadOnly = false;
            txtCodigoArticulo.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        public bool Aplicar
        {
            get { return aplicar; }
            set { aplicar = value; }
        }
        public string Codigo 
        {
            get { return txtCodigoArticulo.Text; }
            set { txtCodigoArticulo.Text = value; }
        }
        public string Nombre 
        {
            get { return txtNombreProducto.Text; }
            set { txtNombreProducto.Text = value; }
        }
        public string Marca 
        {
            get { return txtMarca.Text; }
            set { txtMarca.Text = value; }
        }

        public string FechaEntrada
        {
            get { return fechaEntrada; }
            set { fechaEntrada = value; }
        }
        public string Descripcion 
        {
            get { return txtDescripcion.Text; }
            set { txtDescripcion.Text = value; }
        }
        public string PrecioCompra 
        {
            get { return numPrecioCompra.Value.ToString(); }
        }
        public string PrecioVenta 
        {
            get { return numPrecioVenta.Value.ToString(); }
        }
        public string Cantida 
        {
            get { return numCantidad.Value.ToString(); }
        }
        public string Porcentaje 
        {
            get { return numPorcentaje.Value.ToString(); }
        }
        public bool Existencia 
        {
            get { return ckbExistencia.Checked; }
            set { ckbExistencia.Checked = value; }
        }

        private void txtCodigoArticulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    InventarioD oInventario = new InventarioD(cnx);
                    List<InventarioL> respuesta = oInventario.obtenerProducto(new InventarioL(txtCodigoArticulo.Text, "", "", "", "", "", "", "", ""));
                    if (oInventario.Error) 
                    {
                        MessageBox.Show("Error inesperado al intentar obtener los registros solicitados.\nDetalle técnico: "+oInventario.ErrorDescription, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (respuesta.Count == 1)
                    {
                        txtNombreProducto.Text = respuesta[0].Nombre.ToString();
                        txtMarca.Text = respuesta[0].Marca.ToString();
                        txtDescripcion.Text = respuesta[0].Descripcion.ToString();
                        numPrecioCompra.Value = Convert.ToDecimal(respuesta[0].PrecioCompra.ToString());
                        numPrecioVenta.Value = Convert.ToDecimal(respuesta[0].PrecioVenta.ToString());
                        numCantidad.Value = Convert.ToDecimal(respuesta[0].Cantidad.ToString());
                        ckbExistencia.Checked = Convert.ToBoolean(respuesta[0].Existencia.ToString());
                        txtCodigoArticulo.Enabled = false;
                        txtCodigoArticulo.ReadOnly = true;
                    }
                    else
                    {
                        MessageBox.Show("No se han econtrado datos referentes al siguiente código: " + txtCodigoArticulo.Text, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch 
            {
                MessageBox.Show("Error inesperado al intentar obtener los registros solicitados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
