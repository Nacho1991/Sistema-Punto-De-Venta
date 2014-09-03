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
    public partial class frmEmpleados : Form
    {
        AccesoDatosMySql cnx;

        public frmEmpleados(AccesoDatosMySql pCnx)
        {
            InitializeComponent();
            cnx = pCnx;
            cargarGrid();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarEmpleado oAgree = new frmAgregarEmpleado(cnx);
            oAgree.ShowDialog();
            if (oAgree.Aceptar == true)
            {
                try
                {
                    Empleadocs oEmpl = new Empleadocs(cnx);
                    oEmpl.agregarEmpleado(oAgree.NumeroEmpleado, oAgree.Nombre, oAgree.Apellidos, oAgree.Cedula,oAgree.FechaNacimiento, oAgree.Edad, oAgree.Sexo, oAgree.Telefono, oAgree.Celular, oAgree.CorreoElectronico, oAgree.Contraseña, oAgree.NombreUsuario, oAgree.SalarioMensual, oAgree.Departamento, oAgree.TipoUsuario, oAgree.UsuarioLogeado,DateTime.Now,"Ignacio");
                    cargarGrid();
                    MessageBox.Show("Empleado agregado éxcitosamente.", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Error al cargar los datos en la base de datos.", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void cargarGrid()
        {
            try
            {
                Empleadocs oRegistroEmpleado = new Empleadocs(cnx);
                DataSet datos = oRegistroEmpleado.obtenerEmpleados().Copy();
                this.dgvEmpleados.DataSource = datos.Tables[0];
                if (oRegistroEmpleado.Error)
                {
                    MessageBox.Show("Error cargando los datos.\n" + oRegistroEmpleado.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error cargando los datos.\nDetalles técnicos: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int verificarAdministradores()
        {
            int contAdministrador = 0;
            try
            {
                for (int fila = 0; fila < dgvEmpleados.RowCount - 1; fila++)
                {
                    if (this.dgvEmpleados[14, fila].Value.ToString() == "Administrador")
                    {
                        contAdministrador += 1;
                    }
                }
            }
            catch 
            {
                MessageBox.Show("Error al verificar la cantidad de administradores en la tabla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return contAdministrador;
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int fila = this.dgvEmpleados.CurrentRow.Index;
                string admi = dgvEmpleados[14, fila].Value.ToString();
                if (this.dgvEmpleados.RowCount > 1)
                {
                    if (admi == "Administrador")
                    {
                        if (verificarAdministradores() > 1)
                        {
                            if (MessageBox.Show("¿Realmente desea eliminar el empleado seleccionado?", "Confirmación",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                Empleadocs oEmpleDelete = new Empleadocs(cnx);
                                string IdCkiente = this.dgvEmpleados[0, fila].Value.ToString();
                                oEmpleDelete.borrarEmpleado(IdCkiente);
                                if (oEmpleDelete.ErrorDescripcion != "")
                                {
                                    MessageBox.Show(oEmpleDelete.ErrorDescripcion,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                                    return;
                                }
                                this.cargarGrid();
                                MessageBox.Show("El registro del empleado se ha borrado satisfactoriamente.", "Borrado",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Imposible borrar un solo administrador, si se procede la aplicación queda totalmente inaccesible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("¿Realmente desea eliminar el empleado seleccionado?", "Confirmación",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Empleadocs oEmpleDelete = new Empleadocs(cnx);
                            string IdCkiente = this.dgvEmpleados[0, fila].Value.ToString();
                            oEmpleDelete.borrarEmpleado(IdCkiente);
                            if (oEmpleDelete.ErrorDescripcion != "")
                            {
                                MessageBox.Show(oEmpleDelete.ErrorDescripcion);
                                return;
                            }
                            this.cargarGrid();
                            MessageBox.Show("El registro del empleado se ha borrado satisfactoriamente.", "Borrado",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("No hay registro en la tabla.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch 
            {
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargarGrid();
        }

        private void btnPlanilla_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                int fila = dgvEmpleados.CurrentRow.Index;
                frmEditarEmpleado oEdit = new frmEditarEmpleado(dgvEmpleados[0, fila].Value.ToString(), dgvEmpleados[1, fila].Value.ToString(),
                    dgvEmpleados[2, fila].Value.ToString(), dgvEmpleados[3, fila].Value.ToString(), Convert.ToDateTime(dgvEmpleados[4, fila].Value.ToString()),
                    dgvEmpleados[7, fila].Value.ToString(), dgvEmpleados[8, fila].Value.ToString(), dgvEmpleados[10, fila].Value.ToString(),
                    dgvEmpleados[9, fila].Value.ToString(), dgvEmpleados[5, fila].Value.ToString(), dgvEmpleados[6, fila].Value.ToString(),
                    dgvEmpleados[12, fila].Value.ToString(), dgvEmpleados[14, fila].Value.ToString(), dgvEmpleados[13, fila].Value.ToString());
                oEdit.ShowDialog();
            }
            catch 
            {
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Empleadocs oEm = new Empleadocs(cnx);
            oEm.buscadorDatos(txtSexo.Text, txtNombre.Text);
            if (oEm.ErrorDescripcion != "")
            {
                MessageBox.Show(oEm.ErrorDescripcion);
                return;
            }
            this.cargarGrid();
        }
    }
}
