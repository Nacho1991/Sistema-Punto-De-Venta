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
    public partial class frmVerDetallesCliente : Form
    {
        public frmVerDetallesCliente(string pCedula,string pNombre,string pApellidos, string pFechaNacimiento,
                                     string pTelefono,string pCelular,string pEdad,string pSexo,string pDepartamento,string pCorreo)
        {
            InitializeComponent();
            try
            {
                lblCedula.Text = pCedula;
                lblNombre.Text = pNombre;
                lblApellidos.Text = pApellidos;
                lblFechaNacimiento.Text = pFechaNacimiento;
                lblTelefono.Text = pTelefono;
                if (pTelefono == "") 
                {
                    lblTelefono.Text = "Sin registros";
                }
                lblCelular.Text = pCelular;
                lblEdad.Text = pEdad;
                lblSexo.Text = pSexo;
                lblDepartamento.Text = pDepartamento;
                lblCorreoElectronico.Text = pCorreo;
            }
            catch 
            {

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
