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
    public partial class frmBuscador : Form
    {
        AccesoDatosMySql cnx;

        public frmBuscador(AccesoDatosMySql pCnx)
        {
            InitializeComponent();
            cnx = pCnx;
        }

        public bool buscadorCliente(string datos)
        {
            bool encontrado = false;
            try
            {
                int fila = dgvResultBusqueda.RowCount - 1;
                int columna = dgvResultBusqueda.ColumnCount - 1;
                string datosAlmacenados = "";
                for (int col = 0; col < columna; col++)
                {
                    for (int fil = 0; fil < fila; fil++)
                    {
                        datosAlmacenados = dgvResultBusqueda[col, fil].Value.ToString();
                        if (datosAlmacenados == datos)
                        {
                            encontrado = true;
                        }
                    }
                }
            }
            catch 
            {
                MessageBox.Show("El metodo del buscador posee problemas para encontrar resultados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return encontrado;
        }

        public void btnBuscar_Click(object sender, EventArgs e)
        {
            if (rbtnNumCedula.Checked == true) 
            {
                try
                {
                    if (buscadorCliente(txtNumeroBuscar.Text) == false)
                    {
                        int filas = dgvResultBusqueda.RowCount - 1;
                        int col = dgvResultBusqueda.ColumnCount;
                        BuscadorCliente oSearch = new BuscadorCliente(cnx);
                        oSearch.extractorDatosClientesPorCedula(txtNumeroBuscar.Text);
                        if (oSearch.Cedula == "" && oSearch.Nombre == "" && oSearch.PrimerApellido == "" && oSearch.SegundoApellido == "" && oSearch.Direccion == "" && oSearch.Telefono == "" && oSearch.Limite == "" && oSearch.SaldoActual == "")
                        {
                            MessageBox.Show("No se encontraron datos con el número de cédula ingresada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            dgvResultBusqueda.Rows.Insert(0, oSearch.Cedula, oSearch.Codigo, oSearch.Nombre, oSearch.PrimerApellido, oSearch.SegundoApellido, oSearch.Direccion, oSearch.Telefono, oSearch.Limite, oSearch.SaldoActual);
                            txtNumeroBuscar.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("El empleado que intenta buscar ya se encuentra dentro de la lista de resultados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                catch 
                {
                    MessageBox.Show("Error de sintaxis, no se logró encontrar por medio del número de cédula ingresado.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else if (rbtnNumUsuario.Checked == true) 
            {
                try
                {
                    if (buscadorCliente(txtNumeroBuscar.Text) == false)
                    {
                        int filas = dgvResultBusqueda.RowCount - 1;
                        int col = dgvResultBusqueda.ColumnCount;
                        BuscadorCliente oSearch = new BuscadorCliente(cnx);
                        oSearch.extractorDatosClientesPorCodigo(txtNumeroBuscar.Text);
                        if (oSearch.Cedula == "" && oSearch.Nombre == "" && oSearch.PrimerApellido == "" && oSearch.SegundoApellido == "" && oSearch.Direccion == "" && oSearch.Telefono == "" && oSearch.Limite == "" && oSearch.SaldoActual == "")
                        {
                            MessageBox.Show("No se encontraron datos con el número de cliente ingresada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            dgvResultBusqueda.Rows.Insert(0, oSearch.Cedula, oSearch.Codigo, oSearch.Nombre, oSearch.PrimerApellido, oSearch.SegundoApellido, oSearch.Direccion, oSearch.Telefono, oSearch.Limite, oSearch.SaldoActual);
                            txtNumeroBuscar.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("El empleado que intenta buscar ya se encuentra dentro de la lista de resultados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                catch 
                {
                    MessageBox.Show("Error de sintaxis, no se logró encontrar por medio del número de cliente ingresado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rbtnNombre.Checked == true)
            {
                try
                {
                    if (buscadorCliente(txtNumeroBuscar.Text) == false)
                    {
                        int filas = dgvResultBusqueda.RowCount - 1;
                        int col = dgvResultBusqueda.ColumnCount;
                        BuscadorCliente oSearch = new BuscadorCliente(cnx);
                        oSearch.extractorDatosClientesPorNombre(txtNumeroBuscar.Text);
                        if (oSearch.Cedula == "" && oSearch.Nombre == "" && oSearch.PrimerApellido == "" && oSearch.SegundoApellido == "" && oSearch.Direccion == "" && oSearch.Telefono == "" && oSearch.Limite == "" && oSearch.SaldoActual == "")
                        {
                            MessageBox.Show("No se encontraron datos con el número de cliente ingresada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            dgvResultBusqueda.Rows.Insert(0, oSearch.Cedula, oSearch.Codigo, oSearch.Nombre, oSearch.PrimerApellido, oSearch.SegundoApellido, oSearch.Direccion, oSearch.Telefono, oSearch.Limite, oSearch.SaldoActual);
                            txtNumeroBuscar.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("El empleado que intenta buscar ya se encuentra dentro de la lista de resultados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                catch 
                {
                    MessageBox.Show("Error de sintaxis, no se logró encontrar por medio del nombre del cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void rbtnNumUsuario_CheckedChanged(object sender, EventArgs e)
        {
            lblNumero.Text = "Por favor ingrese aquí el número de cliente al que desea buscar:";
        }

        private void rbtnNumCedula_CheckedChanged(object sender, EventArgs e)
        {
            lblNumero.Text = "Por favor ingrese aquí el número de cédula al que desea buscar:";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lblNumero.Text = "Por favor ingrese aquí el nombre del cliente al que desea buscar:";
        }

        private void txtNumeroBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
                btnBuscar.PerformClick();
            }
        }
    }
}
