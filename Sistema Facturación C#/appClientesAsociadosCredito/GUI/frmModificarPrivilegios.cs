using AccesoDatos;
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
    public partial class frmModificarPrivilegios : Form
    {
        AccesoDatosMySql cnx;
        private bool aceptar;
        private string cedula;
        private string adminFacturas;
        private string adminCajas;
        private string adminInventario;
        private string adminEmpleados;
        private string adminClientes;
        public frmModificarPrivilegios(AccesoDatosMySql pCnx, string pCedula)
        {
            InitializeComponent();
            aceptar = false;
            cnx = pCnx;
            cedula = pCedula;
            obtenerPrivilegios(pCedula);
        }
        public void extraerPrivilegios()
        {
            adminCajas = "false";
            adminFacturas = "false";
            adminInventario = "false";
            adminEmpleados = "false";
            adminClientes = "false";
            if (chkAdministrarFacturas.Checked)
            {
                adminFacturas = "true";
            }
            if (chkAdministrarClientes.Checked)
            {
                adminClientes = "true";
            }
            if (chkAdministrarEmpleados.Checked)
            {
                adminEmpleados = "true";
            }
            if (chkAdministrarInventario.Checked)
            {
                adminInventario = "true";
            }
            if (chkAdministrarCajas.Checked)
            {
                adminCajas = "true";
            }
        }

        private void ckbAdministrarFacturas_MouseMove(object sender, MouseEventArgs e)
        {
            txtDetalles.Text = "Administra las facturas de forma general, abarcando la eliminación, edición y modifiación de las facturas que se encuentran registradas en la base de datos.";
        }
        public void obtenerPrivilegios(string pCedula)
        {
            try
            {
                PrivilegiosD oPRivilegio = new PrivilegiosD(cnx);
                List<PrivilegiosL> respuesta = oPRivilegio.obtenerPrivilegios(new PrivilegiosL(pCedula, "", "", "", "", ""));
                if (oPRivilegio.Error)
                {
                    MessageBox.Show("Error inesperado al intentar obtener los privilegios del empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    chkAdministrarCajas.Checked = Convert.ToBoolean(respuesta[0].AdministracionCajas.ToString());
                    chkAdministrarClientes.Checked = Convert.ToBoolean(respuesta[0].AdministracionClientes.ToString());
                    chkAdministrarInventario.Checked = Convert.ToBoolean(respuesta[0].AdministracionInventario.ToString());
                    chkAdministrarFacturas.Checked = Convert.ToBoolean(respuesta[0].AdministracionFacturas.ToString());
                    chkAdministrarEmpleados.Checked = Convert.ToBoolean(respuesta[0].AdministracionEmpleados.ToString());
                }
            }
            catch
            {
                MessageBox.Show("Error inesperado al intentar obtener los privilegios del empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            aceptar = true;
            extraerPrivilegios();
            Close();
        }

        private void grbPrivilegios_MouseHover(object sender, EventArgs e)
        {
            txtDetalles.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        public string AdminFacturas
        {
            get { return adminFacturas; }
            set { adminFacturas = value; }
        }
        public string AdminCajas
        {
            get { return adminCajas; }
            set { adminCajas = value; }
        }
        public string AdminInventario
        {
            get { return adminInventario; }
            set { adminInventario = value; }
        }

        public string AdminEmpleados
        {
            get { return adminEmpleados; }
            set { adminEmpleados = value; }
        }
        public string AdminClientes
        {
            get { return adminClientes; }
            set { adminClientes = value; }
        }
        public bool Aceptar
        {
            get { return aceptar; }
            set { aceptar = value; }
        }
        public string Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }
    }
}
