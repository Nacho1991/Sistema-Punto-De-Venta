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
    public partial class frmBuscarEmpleado : Form
    {
        AccesoDatosMySql cnx;
        Empleadocs oEmpleado;
        List<UsuarioL> retorno;
        private bool aceptar;

        public frmBuscarEmpleado(AccesoDatosMySql pCnx)
        {
            InitializeComponent();
            cnx = pCnx;
            aceptar = false;
            oEmpleado = new Empleadocs(cnx);
            carcargGrid();
        }
        public void carcargGrid() 
        {
            try
            {
                DataSet datos = oEmpleado.obtenerEmpleados().Copy();
                this.dgvEmpleados.DataSource = datos.Tables[0];
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
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvEmpleados.CurrentRow.Index;
                retorno = new List<UsuarioL>();
                retorno.Add(new UsuarioL(dgvEmpleados[3, index].Value.ToString(), dgvEmpleados[4, index].Value.ToString(), dgvEmpleados[5, index].Value.ToString(),
                    dgvEmpleados[6, index].Value.ToString(), dgvEmpleados[7, index].Value.ToString(), dgvEmpleados[11, index].Value.ToString(),dgvEmpleados[12, index].Value.ToString(),
                    dgvEmpleados[13, index].Value.ToString(),dgvEmpleados[14, index].Value.ToString(),dgvEmpleados[15, index].Value.ToString(),
                    dgvEmpleados[8, index].Value.ToString(), dgvEmpleados[9, index].Value.ToString(), dgvEmpleados[10, index].Value.ToString(), dgvEmpleados[0, index].Value.ToString(), dgvEmpleados[16, index].Value.ToString(),
                    dgvEmpleados[1, index].Value.ToString(),dgvEmpleados[2, index].Value.ToString()));
                aceptar = true;
                Close();
            }
            catch 
            {

            }
        }

        private void txtFiltroEmpleado_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtFiltroEmpleado.Text == "")
                {
                    carcargGrid();
                }
                else
                {
                    string opcion = "Id_Cedula";
                    DataSet oDatos = oEmpleado.FiltrarDatos(txtFiltroEmpleado.Text, opcion).Copy();
                    try
                    {
                        dgvEmpleados.DataSource = oDatos.Tables[0];
                    }
                    catch
                    {
                        carcargGrid();
                    }
                }
            }
            catch
            {

            }
        }
        public bool Aceptar
        {
            get { return aceptar; }
            set { aceptar = value; }
        }
        public List<UsuarioL> Retorno
        {
            get { return retorno; }
            set { retorno = value; }
        }
    }
}
