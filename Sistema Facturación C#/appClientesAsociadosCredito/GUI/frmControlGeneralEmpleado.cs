using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;
using Logica;
using Datos;
using System.Text.RegularExpressions;

namespace GUI
{
    public partial class frmControlGeneralEmpleado : Form
    {
        Empleadocs oEmpleado;
        AccesoDatosMySql cnx;
        public static UsuarioL oUsuarioLogueado;
        public frmControlGeneralEmpleado(AccesoDatosMySql pCnx)
        {
            InitializeComponent();
            cnx = pCnx;
            oEmpleado = new Empleadocs(pCnx);
            cargarGrid();
            lblCantidadEmpleados.Text = (dgvRegistros.RowCount).ToString();
        }

        public void obtenerPrivilegios(string pCedula)
        {
            try
            {
                PrivilegiosD oPRivilegio = new PrivilegiosD(cnx);
                List<PrivilegiosL> respuesta = oPRivilegio.obtenerPrivilegios(new PrivilegiosL(pCedula, "", "", "", "", ""));
                chkAdministrarCajasEditar.Checked = Convert.ToBoolean(respuesta[0].AdministracionCajas.ToString());
                chkAdministrarClientesEditar.Checked = Convert.ToBoolean(respuesta[0].AdministracionClientes.ToString());
                chkAdministrarInventarioEditar.Checked = Convert.ToBoolean(respuesta[0].AdministracionInventario.ToString());
                chkAdministrarFacturasEditar.Checked = Convert.ToBoolean(respuesta[0].AdministracionFacturas.ToString());
                chkAdministrarEmpleadoEditar.Checked = Convert.ToBoolean(respuesta[0].AdministracionEmpleados.ToString());
            }
            catch
            {

            }
        }
        public void cargarGrid()
        {
            try
            {
                DataSet datos = oEmpleado.obtenerEmpleados().Copy();
                this.dgvRegistros.DataSource = datos.Tables[0];
                if (oEmpleado.Error)
                {
                    MessageBox.Show("Error cargando los datos.\n" + oEmpleado.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error cargando los datos.\nDetalles técnico: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpFechaNacimientoAgregar_ValueChanged(object sender, EventArgs e)
        {
            txtEdadAgregar.Text = (DateTime.Now.Year - dtpFechaNacimientoAgregar.Value.Year).ToString();
        }
        public void asignarPrivilegiosAgregar()
        {
            string adminCajas = "false";
            string adminFacturas = "false";
            string adminInventario = "false";
            string adminEmpleados = "false";
            string adminClientes = "false";
            if (chkAdministracionFacturasAgregar.Checked)
            {
                adminFacturas = "true";
            }
            if (chkAdministrarClientesAgregar.Checked)
            {
                adminClientes = "true";
            }
            if (chkAdministrarEmpleadosAgregar.Checked)
            {
                adminEmpleados = "true";
            }
            if (chkAdministrarInventarioAgregar.Checked)
            {
                adminInventario = "true";
            }
            if (chkAdministrarCajasAgregar.Checked)
            {
                adminCajas = "true";
            }
            oEmpleado.agregarPrivilegios(txtCedulaAgregar.Text, adminClientes, adminInventario, adminFacturas, adminEmpleados, adminCajas);
            if (oEmpleado.Error)
            {
                MessageBox.Show("Error inesperado a la hora de asignar los privilegios, si el error persiste por favor comuniquese con soporte técnico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void asignarPrivilegiosEditar()
        {
            string adminCajas = "false";
            string adminFacturas = "false";
            string adminInventario = "false";
            string adminEmpleados = "false";
            string adminClientes = "false";
            if (chkAdministrarFacturasEditar.Checked)
            {
                adminFacturas = "true";
            }
            if (chkAdministrarClientesEditar.Checked)
            {
                adminClientes = "true";
            }
            if (chkAdministrarEmpleadoEditar.Checked)
            {
                adminEmpleados = "true";
            }
            if (chkAdministrarInventarioEditar.Checked)
            {
                adminInventario = "true";
            }
            if (chkAdministrarCajasEditar.Checked)
            {
                adminCajas = "true";
            }
            oEmpleado.modificarPrivilegios(txtCedulaEditar.Text, adminClientes, adminInventario, adminFacturas, adminEmpleados, adminCajas);
            if (oEmpleado.Error)
            {
                MessageBox.Show("Error inesperado a la hora de asignar los privilegios, si el error persiste por favor comuniquese con soporte técnico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtFiltrarDatos_TextChanged(object sender, EventArgs e)
        {
            if (cmbOpcionesBusqueda.Text != "")
            {
                if (txtFiltrarDatos.Text == "")
                {
                    cargarGrid();
                }
                else
                {
                    string opcion = "";
                    if (cmbOpcionesBusqueda.SelectedIndex == 0)
                    {
                        opcion = "id_cedula";
                    }
                    else if (cmbOpcionesBusqueda.SelectedIndex == 1)
                    {
                        opcion = "nombre";
                    }
                    else if (cmbOpcionesBusqueda.SelectedIndex == 2)
                    {
                        opcion = "apellidos";
                    }
                    DataSet oDatos = oEmpleado.FiltrarDatos(txtFiltrarDatos.Text, opcion).Copy();
                    this.dgvRegistros.DataSource = oDatos.Tables[0];
                }
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Realmente desea eliminar el empleado seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int index = dgvRegistros.CurrentRow.Index;
                    oEmpleado.borrarEmpleado(dgvRegistros[0, index].Value.ToString());
                    if (oEmpleado.Error)
                    {
                        MessageBox.Show("Error inesperado al intentar borrar el empleado seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        cargarGrid();
                        lblCantidadEmpleados.Text = (dgvRegistros.RowCount).ToString();
                        MessageBox.Show("Empleado borrado satisfactoriamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            {

            }
        }
        public bool validarCorreo(string pCorreo)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(pCorreo, expresion))
            {
                if (Regex.Replace(pCorreo, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            if (validarCorreo(txtCorreoElectronicoAgregar.Text))
            {
                oEmpleado.agregarEmpleado(txtNombreAgregar.Text, txtApellidosAgregar.Text, txtCedulaAgregar.Text, Convert.ToDateTime(dtpFechaNacimientoAgregar.Value), txtEdadAgregar.Text,
                    cmbSexoAgregar.Text, txtTelefonoAgregar.Text, txtCelularAgregar.Text, txtCorreoElectronicoAgregar.Text, txtContraseñaAgregar.Text,
                    txtNombreUsuarioAgregar.Text, cmbDepartamentoAgregar.Text, DateTime.Now, "", appClientesAsociadosCredito.Program.oUsuarioLogueado.Nombre + " " + appClientesAsociadosCredito.Program.oUsuarioLogueado.Apellidos);
                if (oEmpleado.Error)
                {
                    MessageBox.Show("Error inesperado al intentar registrar el empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    asignarPrivilegiosAgregar();
                    cargarGrid();
                    lblCantidadEmpleados.Text = (dgvRegistros.RowCount).ToString();
                    MessageBox.Show("Empleado registrado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("El correo electrónico ingresado no es correcto, por favor corrija para continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void ckbVerCaracteresAgregar_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbVerCaracteresAgregar.Checked == true)
            {
                txtContraseñaAgregar.PasswordChar = '\0';
                txtVerificadorContrasennaAgregar.PasswordChar = '\0';
            }
            else if (txtContraseñaAgregar.Text != "")
            {
                txtContraseñaAgregar.PasswordChar = '●';
                txtVerificadorContrasennaAgregar.PasswordChar = '●';
            }
        }

        private void dgvRegistros_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int index = dgvRegistros.CurrentRow.Index;
                txtCedulaEditar.Text = dgvRegistros[0, index].Value.ToString();
                txtNombreEditar.Text = dgvRegistros[1, index].Value.ToString();
                txtApellidosEditar.Text = dgvRegistros[2, index].Value.ToString();
                dtpFechaNacimientoEditar.Value = Convert.ToDateTime(dgvRegistros[3, index].Value.ToString());
                txtTelefonoEditar.Text = dgvRegistros[4, index].Value.ToString();
                txtCelularEditar.Text = dgvRegistros[5, index].Value.ToString();
                txtEdadEditar.Text = dgvRegistros[6, index].Value.ToString();
                cmbSexoEditar.Text = dgvRegistros[7, index].Value.ToString();
                cmbDepartamentoEditar.Text = dgvRegistros[15, index].Value.ToString();
                txtContrasennaEditar.Text = dgvRegistros[9, index].Value.ToString();
                txtNombreUsuarioEditar.Text = dgvRegistros[8, index].Value.ToString();
                txtCorreoEditar.Text = dgvRegistros[11, index].Value.ToString();
                obtenerPrivilegios(dgvRegistros[0, index].Value.ToString());
            }
            catch
            {

            }
        }

        private void btnEditarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbDepartamentoEditar.Text == "" || txtContrasennaEditar.Text == "" || txtNombreEditar.Text == "" || txtApellidosEditar.Text == "" || txtNombreUsuarioEditar.Text == "" || cmbSexoEditar.Text == "")
                {
                    MessageBox.Show("Faltan datos importantes, por favor corrija para contiuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (validarCorreo(txtCorreoEditar.Text))
                    {
                        int index = dgvRegistros.CurrentRow.Index;
                        oEmpleado.modificarEmpleado(txtNombreEditar.Text, txtApellidosEditar.Text, txtCedulaEditar.Text, dtpFechaNacimientoEditar.Value, txtEdadEditar.Text, cmbSexoEditar.Text, txtTelefonoEditar.Text,
                            txtCelularEditar.Text, txtCorreoEditar.Text, txtContrasennaEditar.Text, txtNombreUsuarioEditar.Text, Convert.ToDateTime(dgvRegistros[12, index].Value.ToString()),
                            cmbDepartamentoEditar.Text, appClientesAsociadosCredito.Program.oUsuarioLogueado.Nombre + " " + appClientesAsociadosCredito.Program.oUsuarioLogueado.Apellidos,
                            dgvRegistros[14, index].Value.ToString());
                        if (oEmpleado.Error)
                        {
                            MessageBox.Show("Error inesperado al intentar modificar al empleado seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            asignarPrivilegiosEditar();
                            cargarGrid();
                            MessageBox.Show("Empleado modificado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El correo electrónico ingresado no es correcto, por favor corrija para continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error inesperado a la hora de modificar el empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargarGrid();
        }

        private void btnCambiarContrasenna_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvRegistros.CurrentRow.Index;
                frmCambiarContrasenna oChange = new frmCambiarContrasenna(dgvRegistros[9, index].Value.ToString());
                oChange.ShowDialog();
                if (oChange.Aceptar == true)
                {
                    oEmpleado.modificarEmpleado(txtNombreEditar.Text, txtApellidosEditar.Text, txtCedulaEditar.Text, dtpFechaNacimientoEditar.Value, txtEdadEditar.Text, cmbSexoEditar.Text, txtTelefonoEditar.Text,
                        txtCedulaEditar.Text, txtCorreoEditar.Text, oChange.ContrasennaNueva, txtNombreUsuarioEditar.Text, Convert.ToDateTime(dgvRegistros[12, index].Value.ToString()),
                        cmbDepartamentoEditar.Text, appClientesAsociadosCredito.Program.oUsuarioLogueado.Nombre + " " + appClientesAsociadosCredito.Program.oUsuarioLogueado.Apellidos,
                        dgvRegistros[14, index].Value.ToString());
                    if (oEmpleado.Error)
                    {
                        MessageBox.Show("Error inesperado al intentar cambiar la contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        asignarPrivilegiosEditar();
                        cargarGrid();
                        MessageBox.Show("Contraseña modificada con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            catch
            {
                MessageBox.Show("Error al intentar cambiar la contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            dgvRegistros.Rows[e.RowIndex].Selected = true;
            //enviamos el valor de la celda a la variable _cellValue
            valorCelda = dgvRegistros[e.ColumnIndex, e.RowIndex].Value.ToString();
            //Definimos el lugar donde aparecera el scontextMenuStrip
            menuClickDerecho.Show(MousePosition);
        }

        private void menuClickDerecho_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                int index = dgvRegistros.CurrentRow.Index;
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
                            if (MessageBox.Show("¿Realmente desea eliminar el empleado seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                oEmpleado.borrarEmpleado(dgvRegistros[0, index].Value.ToString());
                                if (oEmpleado.Error)
                                {
                                    MessageBox.Show("Error inesperado al intentar borrar el empleado seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    cargarGrid();
                                    lblCantidadEmpleados.Text = (dgvRegistros.RowCount).ToString();
                                    MessageBox.Show("Empleado borrado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Error inesperado al intentar eliminar el empleado seleccionado. Por favor si el problema persiste comuniquese con TI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case "itmDetalles":

                        frmVerDetallesEmpleado oDetails =
                            new frmVerDetallesEmpleado(
                                dgvRegistros[0, index].Value.ToString(),
                                dgvRegistros[1, index].Value.ToString(),
                                dgvRegistros[2, index].Value.ToString(),
                                dgvRegistros[3, index].Value.ToString(),
                                dgvRegistros[4, index].Value.ToString(),
                                dgvRegistros[5, index].Value.ToString(),
                                dgvRegistros[6, index].Value.ToString(),
                                dgvRegistros[7, index].Value.ToString(),
                                dgvRegistros[15, index].Value.ToString(),
                                dgvRegistros[10, index].Value.ToString()
                );
                        oDetails.ShowDialog();
                        break;
                    case "itmModificar":
                        frmEditarEmpleado oEdit = new frmEditarEmpleado(
                            dgvRegistros[0, index].Value.ToString(),
                            dgvRegistros[1, index].Value.ToString(),
                            dgvRegistros[2, index].Value.ToString(),
                            dgvRegistros[3, index].Value.ToString(),
                            dgvRegistros[4, index].Value.ToString(),
                            dgvRegistros[5, index].Value.ToString(),
                            dgvRegistros[8, index].Value.ToString(),
                            dgvRegistros[6, index].Value.ToString(),
                            dgvRegistros[7, index].Value.ToString(),
                            dgvRegistros[15, index].Value.ToString(),
                            dgvRegistros[9, index].Value.ToString(),
                            dgvRegistros[10, index].Value.ToString());
                        oEdit.ShowDialog();
                        if (oEdit.Aceptar)
                        {
                            oEmpleado.modificarEmpleado(oEdit.Nombre, oEdit.Apellidos, oEdit.Cedula, oEdit.FechaNacimiento, oEdit.Edad, oEdit.Sexo, oEdit.Telefono,
                            oEdit.Celular, oEdit.Correo, oEdit.Contrasenna, oEdit.NombreUsuario, Convert.ToDateTime(dgvRegistros[12, index].Value.ToString()),
                            oEdit.Departamento, appClientesAsociadosCredito.Program.oUsuarioLogueado.Nombre + " " + appClientesAsociadosCredito.Program.oUsuarioLogueado.Apellidos,
                            dgvRegistros[14, index].Value.ToString());
                            if (oEmpleado.Error)
                            {
                                MessageBox.Show("Error inesperado al intentar cambiar la contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                cargarGrid();
                                MessageBox.Show("Datos del empleado satisfactoriamente modificados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        break;
                    case "itmPrivilegios":
                        frmModificarPrivilegios oPrivilegios = new frmModificarPrivilegios(cnx, dgvRegistros[0, index].Value.ToString());
                        oPrivilegios.ShowDialog();
                        if (oPrivilegios.Aceptar)
                        {
                            oEmpleado.modificarPrivilegios(oPrivilegios.Cedula, oPrivilegios.AdminClientes, oPrivilegios.AdminInventario, oPrivilegios.AdminFacturas, oPrivilegios.AdminEmpleados, oPrivilegios.AdminCajas);
                            if (oEmpleado.Error)
                            {
                                MessageBox.Show("Error inesperado a la hora de asignar los privilegios, si el error persiste por favor comuniquese con soporte técnico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                cargarGrid();
                                MessageBox.Show("Privilegios modificados satisfactoriamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnTomarFoto_Click(object sender, EventArgs e)
        {
            if (txtNombreAgregar.Text == "" || txtApellidosAgregar.Text == "" || txtCedulaAgregar.Text == "")
            {
                MessageBox.Show("Faltan datos importantes, por favor ingreselos para continuar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                frmGestorCamara oWebCam = new frmGestorCamara(txtNombreAgregar.Text+" "+ txtApellidosAgregar.Text, txtCedulaAgregar.Text);
                oWebCam.ShowDialog();
            }
        }
        
    }
}
