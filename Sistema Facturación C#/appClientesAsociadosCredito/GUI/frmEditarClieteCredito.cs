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
    public partial class frmEditarClieteCredito : Form
    {
        private bool aceptar;
        private string estadoCliente;

        public frmEditarClieteCredito(string codigo, string cedula,string nombre, string primerApellido, string segundoApellido,string direccion,string telefono,string limite)
        {
            InitializeComponent();
            aceptar = false;
            estadoCliente = "Deshabilitado";
            txtCodigo.Text = codigo;
            txtCedula.Text = cedula;
            txtNombre.Text = nombre;
            txtPrimerApellido.Text = primerApellido;
            txtSegundoApellido.Text = segundoApellido;
            txtDireccion.Text = direccion;
            txtTelefono.Text = telefono;
            txtLimiteCredito.Text = limite;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (chBoxHabilitar.Checked != true)
                {
                    if (MessageBox.Show("La casilla de habilitación del cliente está quedando desmarcada, si se procede el cliente quedará totalmente deshabilitado. ¿Desea continuar sin éste dato?", "Confirmacón", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        aceptar = true;
                        Close();
                    }
                }
                else 
                {
                    aceptar = true;
                    Close();
                }
            }
            catch 
            {
                MessageBox.Show("Error al intentar modificar los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public string EstadoCliente
        {
            get { return estadoCliente; }
            set { estadoCliente = value; }
        }

        public bool Aceptar
        {
            get { return aceptar; }
            set { aceptar = value; }
        }

        public string Codigo
        {
            get { return txtCodigo.Text; }
        }
        public string Cedula
        {
            get { return txtCedula.Text; }
        }
        public string Nombre
        {
            get { return txtNombre.Text; }
        }
        public string PrimerApellido
        {
            get { return txtPrimerApellido.Text; }
        }
        public string SegundoApellido
        {
            get { return txtSegundoApellido.Text; }
        }
        public string Direccion
        {
            get { return txtDireccion.Text; }
        }
        public string Telefono
        {
            get { return txtTelefono.Text; }
        }
        public string LimiteCredito
        {
            get { return txtLimiteCredito.Text; }
        }

        private void btnCacelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chBoxHabilitar_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxHabilitar.Checked)
            {
                estadoCliente = "Habilitado";
            }
            else if(chBoxHabilitar.Checked != true)
            {
                estadoCliente = "Deshabilitado";
            }
        }
    }
}
