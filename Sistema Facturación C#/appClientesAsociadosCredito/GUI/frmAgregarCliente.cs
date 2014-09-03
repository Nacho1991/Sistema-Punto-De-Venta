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
    public partial class frmAgregarCliente : Form
    {
        private bool aceptar;
        AccesoDatosMySql cnx;

        public frmAgregarCliente(AccesoDatosMySql pCnx)
        {
            InitializeComponent();
            cnx = pCnx;
            aceptar = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            BuscadorCliente oBusc = new BuscadorCliente(cnx);
            if (oBusc.compararCedulaCliente(txtCedula.Text))
            {
                MessageBox.Show("El número de cédula del cliente que está intentando registrar ya se encuentra en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (oBusc.comparaCodigoCliente(txtCodigo.Text) == true) 
            {
                MessageBox.Show("El número de código del cliente que está intentando registrar ya se encuentra en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txtCodigo.Text == "" || txtDireccion.Text == "" || txtMontoAcreditar.Text == "" || txtNombre.Text == "" || txtPrimerApellido.Text == "" || txtSegundoApellido.Text == "")
            {
                MessageBox.Show("Datos insuficientes, por favor agregue los datos necesarios para continuar.", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    this.aceptar = true;
                    this.Close();
                }
                catch (Exception y)
                {
                    MessageBox.Show("Error a la hora de registrarse en la base de datos. \nDetalles: " + y.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public bool Aceptar
        {
            get { return aceptar; }
            set { aceptar = value; }
        }
        public string Nombre
        {
            get { return txtNombre.Text; }
        }
        public string Cedula
        {
            get { return txtCedula.Text; }
        }
        public string Codigo
        {
            get { return txtCodigo.Text; }
        }
        public string ApellidoUno
        {
            get { return txtPrimerApellido.Text; }
        }
        public string ApellidoDos
        {
            get { return txtSegundoApellido.Text; }
        }
        public string Telefono
        {
            get { return txtTelefono.Text; }
        }
        public string Direccion
        {
            get { return txtDireccion.Text; }
        }
        public string MontoAcreditar
        {
            get { return txtMontoAcreditar.Text; }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
            aceptar = false;
        }
    }
}
