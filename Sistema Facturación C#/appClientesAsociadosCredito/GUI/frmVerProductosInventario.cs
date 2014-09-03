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
    public partial class frmVerProductosInventario : Form
    {
        AccesoDatosMySql cnx;

        public frmVerProductosInventario(AccesoDatosMySql pCnx)
        {
            InitializeComponent();
            cnx = pCnx;
            cargarDataGrid();
        }

        public void cargarDataGrid()
        {
            try
            {
                Inventario oProd = new Inventario(cnx);
                DataSet datos = oProd.ObtenerProductosInventario().Copy();
                this.dgvProductosInventario.DataSource = datos.Tables[0];
                if (oProd.Error)
                {
                    MessageBox.Show("Error cargando los datos.\n" + oProd.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error cargando los datos.\nDetalles técnicos: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
