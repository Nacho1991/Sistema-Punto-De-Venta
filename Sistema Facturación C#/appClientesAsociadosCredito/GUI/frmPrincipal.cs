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
using System.Diagnostics;
using AccesoDatos;
using Datos;

namespace GUI
{
    public partial class frmPrincipal : Form
    {
        AccesoDatosMySql cnx;
        private bool exit;
        public static UsuarioL oUsuarioLogueado;
        private string adminCajas;
        private string adminClientes;
        private string adminInventario;
        private string adminFacturas;
        private string adminEmpleado;
        private bool bloqueado;
        public frmPrincipal(AccesoDatosMySql pCnx, bool pEstadoConexion)
        {
            InitializeComponent();
            exit = false;
            this.lblTipoUsuario.Text = appClientesAsociadosCredito.Program.oUsuarioLogueado.Departamento;
            this.lblNombreUsuario.Text = appClientesAsociadosCredito.Program.oUsuarioLogueado.Nombre + " " + appClientesAsociadosCredito.Program.oUsuarioLogueado.Apellidos;
            this.cnx = pCnx;
            timer1.Start();
            establecerEstadoConexion(pEstadoConexion);
            obtenerPrivilegios();
        }
        public void obtenerPrivilegios()
        {
            try
            {
                PrivilegiosD oPRivilegio = new PrivilegiosD(cnx);
                List<PrivilegiosL> respuesta = oPRivilegio.obtenerPrivilegios(new PrivilegiosL(appClientesAsociadosCredito.Program.oUsuarioLogueado.Cedula, "", "", "", "", ""));
                adminCajas = respuesta[0].AdministracionCajas.ToString();
                adminClientes = respuesta[0].AdministracionClientes.ToString();
                adminInventario = respuesta[0].AdministracionInventario.ToString();
                adminFacturas = respuesta[0].AdministracionFacturas.ToString();
                adminEmpleado = respuesta[0].AdministracionEmpleados.ToString();
                bloqueado = false;
            }
            catch
            {
                MessageBox.Show("Error al intentar obtener los privilegios de acceso. La aplicación quedará bloqueada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bloqueado = true;
            }
        }
        public void establecerEstadoConexion(bool pEstado) 
        {
            if (pEstado == true)
            {
                lblEstadoConexion.Text = "Conectado";
            }
            else 
            {
                lblEstadoConexion.Text = "No conectado";
            }
        }
        public bool Exit
        {
            get { return exit; }
            set { exit = value; }
        }
        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Exit = true;
            //if (MessageBox.Show("¿Realmente desea salir de la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            //{
            //    //Impedir que el formulario se cierre pulsando X o Alt + F4 
            //    switch (e.CloseReason)
            //    {
            //        case CloseReason.UserClosing:
            //            e.Cancel = true;
            //            break;
            //    }
            //}
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHoraSistema.Text = DateTime.Now.ToLongTimeString();
        }

        private void gestorDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (adminInventario == "true" && bloqueado == false)
            {
                frmControlGeneralInventario oControlInven = new frmControlGeneralInventario(cnx);
                oControlInven.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tiene permisos para administrar el área del inventario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iniciarFacturaciónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (adminCajas == "true" && bloqueado == false)
            {
                frmFacturacion oFactu = new frmFacturacion(cnx);
                oFactu.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tiene permisos para administrar el área de cajas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void agregarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (adminInventario == "true" && bloqueado == false)
            {
                frmAgregarProductos oInven = new frmAgregarProductos(cnx, cnx.estado());
                oInven.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tiene permisos para administrar el área del inventario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void agregarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (adminEmpleado == "true" && bloqueado == false)
            {
                frmAgregarEmpleado oAgree = new frmAgregarEmpleado(cnx);
                oAgree.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tiene permisos para administrar el área de empleados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gestorDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (adminEmpleado == "true" && bloqueado == false)
            {
                frmControlGeneralEmpleado oControl = new frmControlGeneralEmpleado(cnx);
                oControl.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tiene permisos para administrar el área de empleados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void historialDeVentasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmHistorialVentas oHostory = new frmHistorialVentas(cnx);
            oHostory.ShowDialog();
        }

        private void gestorDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (adminClientes == "true" && bloqueado == false)
            {
                frmControlGeneralClientes oControl = new frmControlGeneralClientes(cnx);
                oControl.ShowDialog();
            }
            else 
            {
                MessageBox.Show("No tiene permisos para administrar el área de clientes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (adminInventario == "true" && bloqueado == false)
            {
                frmGeneradorBarras oGenerador = new frmGeneradorBarras();
                oGenerador.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tiene permisos para administrar el área del inventario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (adminEmpleado == "true" && bloqueado == false)
            {
                frmEditarEmpleado oEdit = new frmEditarEmpleado(true, cnx);
                oEdit.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tiene permisos para administrar el área de empleados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (adminInventario == "true" && bloqueado == false)
            {
                frmEditarProducto oEdit = new frmEditarProducto(true, cnx);
                oEdit.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tiene permisos para administrar el área del inventario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void acercaDeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAcercaDe oAbout = new frmAcercaDe();
            oAbout.ShowDialog();
        }

        private void agregarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (adminClientes == "true" && bloqueado == false)
            {
            }
            else
            {
                MessageBox.Show("No tiene permisos para administrar el área de clientes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (adminClientes == "true" && bloqueado == false)
            {
            }
            else
            {
                MessageBox.Show("No tiene permisos para administrar el área de clientes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void areaDeCréditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (adminClientes == "true" && bloqueado == false)
            {
            }
            else
            {
                MessageBox.Show("No tiene permisos para administrar el área de clientes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void agregarDepartamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            frmAgregarProductos oAgree = new frmAgregarProductos(cnx,false);
            oAgree.ShowDialog();
        }

        private void menuSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea salir de la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                Close();
            }
        }

        private void btnGestorInventario_Click(object sender, EventArgs e)
        {
            frmControlGeneralInventario oGestor = new frmControlGeneralInventario(cnx);
            oGestor.ShowDialog();
        }

        private void btnGenerarCodBarra_Click(object sender, EventArgs e)
        {
            frmGeneradorBarras oGenerador = new frmGeneradorBarras();
            oGenerador.ShowDialog();
        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            frmEditarProducto oEdit = new frmEditarProducto(true, cnx);
            oEdit.ShowDialog();
        }

        private void btnIniciarFacturacion_Click(object sender, EventArgs e)
        {
            frmFacturacion oFact = new frmFacturacion(cnx);
            oFact.ShowDialog();
        }

        private void btnAgregarClientes_Click(object sender, EventArgs e)
        {

        }

        private void btnEditarClientes_Click(object sender, EventArgs e)
        {
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
        }

        private void btnGestorClientes_Click(object sender, EventArgs e)
        {
            frmControlGeneralClientes oGestor = new frmControlGeneralClientes(cnx);
            oGestor.ShowDialog();
        }

        private void btnGestorEmpleado_Click(object sender, EventArgs e)
        {
            frmControlGeneralEmpleado oGestor = new frmControlGeneralEmpleado(cnx);
            oGestor.ShowDialog();
        }

        private void btnEditarEmpleado_Click(object sender, EventArgs e)
        {
            frmEditarEmpleado oEdit = new frmEditarEmpleado(true, cnx);
            oEdit.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea salir de la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnCambiarConfig_Click(object sender, EventArgs e)
        {
            frmConfiguracionBaseDatos oConfig = new frmConfiguracionBaseDatos("MySQL");
            oConfig.ShowDialog();
        }

        private void chkMostrarInicioApp_CheckBoxCheckChanged(object sender, EventArgs e)
        {
            TxtCL oTxt = new TxtCL();
            bool estado = true;
            if (chkMostrarInicioApp.Checked)
            {
                estado = false;
            }
            string hilera = "Mostrar," + estado + ",MySQL";
            oTxt.Editar("Mostrar", hilera);
            if (oTxt.isError)
            {
                MessageBox.Show("Error al intentar establecer la configuración de ocultar el formulario." + oTxt.errorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHistorialVentas_Click(object sender, EventArgs e)
        {
            frmHistorialVentas oVentas = new frmHistorialVentas(cnx);
            oVentas.ShowDialog();
        }
    }
}
