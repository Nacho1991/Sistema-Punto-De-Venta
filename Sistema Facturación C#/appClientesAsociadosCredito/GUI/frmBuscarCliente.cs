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

namespace GUI
{
    public partial class frmBuscarCliente : Form
    {
        AccesoDatosMySql cnx;
        public frmBuscarCliente(AccesoDatosMySql pCnx)
        {
            InitializeComponent();
            cnx = pCnx;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
