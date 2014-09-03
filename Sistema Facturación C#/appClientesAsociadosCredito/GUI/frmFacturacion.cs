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
using MySql.Data.MySqlClient;

namespace GUI
{
    public partial class frmFacturacion : Form
    {
        AccesoDatosMySql cnx;
        private int numeroFactura;
        private string tipoCliente;
        private int fila;
        private int col;
        private string cantidad;
        private int posEncontrado;
        private string codProducto;
        private string descripcionProducto;
        private string costoProducto;
        private string costoTotal;
        private int numItems;

        public frmFacturacion(AccesoDatosMySql pCnx)
        {
            InitializeComponent();
            this.cnx = pCnx;
            this.numeroFactura = 0;
            this.tipoCliente = "";
            this.fila = 0;
            txtNombreEmpleado.Text = appClientesAsociadosCredito.Program.oUsuarioLogueado.Nombre;
            this.col = 0;
            numItems = 0;
            timer1.Start();
            this.cantidad = "";
            this.posEncontrado = 0;
            this.codProducto = "";
            this.descripcionProducto = "";
            this.costoProducto = "";
            this.costoProducto = "";
        }
        public frmFacturacion()
        {
            InitializeComponent();
        }
        public bool buscador(string pCodigo)
        {
            bool encontrado = false;
            int fil = dgvFactura.RowCount;
            for (int fila = 0; fila < fil - 1; fila++)
            {
                string codigo = this.dgvFactura[0, fila].Value.ToString();
                if (codigo == pCodigo)
                {
                    encontrado = true;
                    posEncontrado = fila;
                }
            }
            return encontrado;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmBuscarProductos oInv = new frmBuscarProductos(cnx);
            oInv.ShowDialog();

        }
        private void btnFacturar_Click(object sender, EventArgs e)
        {
        }

        public bool buscadorCierre()
        {
            bool encontrado = false;
            int fil = dgvFactura.RowCount;
            int col = dgvFactura.ColumnCount;
            for (int fila = 0; fila < fil - 1; fila++)
            {
                for (int columna = 0; columna < col - 1; columna++)
                {
                    if (dgvFactura[columna, fila].Value != null)
                    {
                        encontrado = true;
                    }
                    else
                    {
                        encontrado = false;
                    }
                }
            }
            return encontrado;
        }

        private void frmFacturacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (buscadorCierre() == true)
            {
                if (MessageBox.Show("Si cierra la aplicación se perderan todos los datos en la tabla, ¿Desea continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                }
                else
                {
                    //Impedir que el formulario se cierre pulsando X o Alt + F4 
                    switch (e.CloseReason)
                    {
                        case CloseReason.UserClosing:
                            e.Cancel = true;
                            break;
                    }
                }
            }
        }

        private void dgvFactura_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int fila = dgvFactura.CurrentRow.Index;
            int columna = dgvFactura.CurrentCell.ColumnIndex;

            MessageBox.Show("Columna: " + columna + "\n" + "Fila: " + fila);
        }

        private void txtNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {

                e.Handled = true;
                BuscadorCliente oReg = new BuscadorCliente(cnx);
                oReg.extractorDatosClientesPorNombre(txtNombreCliente.Text);
                txtDireccion.Text = oReg.Direccion;
                txtTelefono.Text = oReg.Telefono;
                txtLimiteCredito.Text = oReg.Limite;
                //txtCodigoCliente.Text = oReg.Codigo;
                txtCedulaCliente.Text = oReg.Cedula;
            }
        }

        private void numCantidadProducto_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numDescuento_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                double precio = 0;
                double descuento = 0;
                double descuentoTotal = 0;
                int fila = this.dgvFactura.CurrentRow.Index;
                precio = Convert.ToDouble(txtTotal.Text);
                //descuento = Convert.ToDouble(numDescuento.Value);
                descuentoTotal = (descuento / 100) * precio;
                txtTotalNeto.Text = (precio - descuentoTotal).ToString();
                lblTotalEtiqueta.Text = txtTotalNeto.Text;
            }
            catch
            {

            }

        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (dgvFactura.Rows.Count > 1)
            {
                if (MessageBox.Show("¿Realmente desea salir del sistema de facturación, si continua se perderán los datos en la tabla de facturación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Close();
                }
            }
        }
        public int NumeroFactura
        {
            get { return numeroFactura; }
            set { numeroFactura = value; }
        }
        public string CostoProducto
        {
            get { return costoProducto; }
            set { costoProducto = value; }
        }
        public string DescripcionProducto
        {
            get { return descripcionProducto; }
            set { descripcionProducto = value; }
        }
        public string CodProducto
        {
            get { return codProducto; }
            set { codProducto = value; }
        }

        //public string Descuento
        //{
        //    get { return numDescuento.Value.ToString(); }
        //}
        public string NombreCliente
        {
            get { return txtNombreCliente.Text; }
            set { txtNombreCliente.Text = value; }
        }
        public string DireccionCliente
        {
            get { return txtDireccion.Text; }
            set { txtDireccion.Text = value; }
        }
        public string Telefono
        {
            get { return txtTelefono.Text; }
            set { txtTelefono.Text = value; }
        }
        public int Fila
        {
            get { return fila; }
            set { fila = value; }
        }
        public string CostoTotal
        {
            get { return costoTotal; }
            set { costoTotal = value; }
        }

        public string TipoCliente
        {
            get { return tipoCliente; }
            set { tipoCliente = value; }
        }

        public int Col
        {
            get { return col; }
            set { col = value; }
        }
        public string Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        private void txtCedulaCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
                string datoIngresado = txtCedulaCliente.Text;
                if (txtCedulaCliente.Text == "")
                {
                    MessageBox.Show("No se ha encontrado ningún cliente asociado al siguiente dato: " + datoIngresado, "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHoraSistem.Text = DateTime.Now.ToLongTimeString();
        }

        private void frmFacturacion_Load(object sender, EventArgs e)
        {
            totyTelefono.SetToolTip(this.txtTelefono, "Se ingresa el número del cliente al que se desea facturar");
            totyTelefono.SetToolTip(this.txtNombreCliente, "Se ingresa el nombre del cliente al que se desea facturar");
            totyTelefono.SetToolTip(this.txtLimiteCredito, "Se muestrar el límite del crédito asignado según el registro");
            totyTelefono.SetToolTip(this.txtNombreEmpleado, "Se muestar el nombre del empleado del que inició la sesión");
            totyTelefono.SetToolTip(this.txtObservacion, "Se dígita el detalle de la factura");
            totyTelefono.SetToolTip(this.txtDireccion, "Se ingresa la dirección del cliente");
            //totyTelefono.SetToolTip(this.txtCodigoCliente,"Se muestar el código del cliente según el registro");
            totyTelefono.SetToolTip(this.txtCedulaCliente, "Se ingresa el número de cédula del cliente");
            totyTelefono.SetToolTip(this.txtTotal, "Se muestar el total de la comprar realizada (Sin impuesto asignado)");
            totyTelefono.SetToolTip(this.txtTotalNeto, "Se muestar el total de la compra realizada (Con impuesto incluído)");
        }

        private void btnVerCalculadora_Click(object sender, EventArgs e)
        {
            frmCalculadora oCal = new frmCalculadora();
            oCal.Show();
        }
        public bool buscaProductos(string pCodigo) 
        {
            bool existe = false;
            for (int pos = 0; pos < dgvFactura.RowCount; pos++) 
            {
                if (pCodigo == dgvFactura[0, pos].Value.ToString()) 
                {
                    existe = true;
                }
            }
            return existe;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuscarProductos oSearch = new frmBuscarProductos(cnx);
                oSearch.ShowDialog();
                if (buscaProductos(oSearch.Codigo) == true)
                {
                    dgvFactura.Rows.Add(oSearch.Codigo, 1, oSearch.PrecioVenta);
                }
                else 
                {
                    dgvFactura.Rows.Add(oSearch.Codigo,oSearch.Descripcion, 0, oSearch.PrecioVenta);
                }
            }
            catch (Exception xp)
            {
                MessageBox.Show("Error inesperado a la hora listar el producto seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Realmente desea eliminar el articulo seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dgvFactura.Rows.RemoveAt(dgvFactura.CurrentRow.Index);
                }
            }
            catch (Exception xp) 
            {
                MessageBox.Show("Error inesperado al intentar eliminar el producto seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {

        }
    }
}


