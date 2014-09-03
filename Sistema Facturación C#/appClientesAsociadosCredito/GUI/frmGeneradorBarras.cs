using CodigoBarras;
using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmGeneradorBarras : Form
    {
        public frmGeneradorBarras()
        {
            InitializeComponent();
        }
        public bool validarExistencia()
        {
            bool existe = false;
            this.ptbBarras.Image = null;
            if (System.IO.File.Exists("c:\\Código de barras\\" + txtCodigo.Text + ".png")) 
            {
                existe = true;
            }
            try
            {
                System.IO.File.Delete("c:\\Código de barras\\" + txtCodigo.Text + ".png");
            }
            catch 
            {

            }
            return existe;
        }
        public void crearDirectorio()
        {
            string ruta = "C:\\Código de barras";

            if (!Directory.Exists(ruta))
            {
                Directory.CreateDirectory(ruta);
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "" || txtDescripcion.Text == "" || txtMarca.Text == "" || txtNombre.Text == "" || numCantidad.Value == 0 || numPrecioCompra.Value == 0 || numPorcentaje.Value == 0)
            {
                MessageBox.Show("Faltan datos importantes por favor ingreselos para continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (rbtnPrimerTipo.Checked)
                {
                    try
                    {
                        crearDirectorio();
                        if (!validarExistencia())
                        {
                            string ruta = "C:\\Código de barras\\" + txtCodigo.Text + ".png";
                            GeneradorBarras code = new GeneradorBarras();
                            System.Drawing.Graphics g = Graphics.FromImage(new Bitmap(1, 1));
                            System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(1, 1, PixelFormat.Format32bppArgb);

                            g = Graphics.FromImage(bmp);
                            code.DrawCode128(g, txtCodigo.Text, 0, 0).Save((ruta), ImageFormat.Png);
                            ptbBarras.LoadAsync(ruta);
                            MessageBox.Show("Código de barras generado satisfactoriamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("El código que intenta generar ya existe entre los archivos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                    catch (Exception xp)
                    {
                        MessageBox.Show("Error inesperado al intentar generar el código de barras.\nDetalle técnico: " + xp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (rbtnSegundoTipo.Checked)
                {
                    try
                    {
                        crearDirectorio();
                        if (!validarExistencia())
                        {
                            string ruta = "C:\\Código de barras\\" + txtCodigo.Text + ".png";
                            System.Drawing.Graphics g = Graphics.FromImage(new Bitmap(1, 1));
                            txtCodigo.Text = txtCodigo.Text.ToUpper();
                            Code39 code = new Code39(txtCodigo.Text);
                            code.Paint().Save((ruta), ImageFormat.Png);
                            ptbBarras.LoadAsync(ruta);
                            MessageBox.Show("Código de barras generado satisfactoriamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("El código que intenta generar ya existe entre los archivos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                    catch (Exception xp)
                    {
                        MessageBox.Show("Error inesperado al intentar generar el código de barras.\nDetalle técnico: " + xp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (rbtnTercerTipo.Checked)
                {
                    try
                    {
                        txtCodigo.Text = sf.Doble(txtCodigo.Text).ToString();
                        if (txtCodigo.Text.Length > 12)
                            txtCodigo.Text = sf.Left(txtCodigo.Text, 12);
                        if (txtCodigo.Text.Length != 12)
                        {
                            while (txtCodigo.Text.Length < 12)
                            {
                                txtCodigo.Text = txtCodigo.Text + "1";
                            }
                        }
                        if (txtCodigo.Text.Length == 12)
                        {
                            crearDirectorio();
                            if (!validarExistencia())
                            {
                                string ruta = "C:\\Código de barras\\" + txtCodigo.Text + ".png"; ;
                                txtCodigo.Text = txtCodigo.Text + Ean13.CalculateChecksum(txtCodigo.Text);
                                Ean13 barcode = new Ean13(txtCodigo.Text, null);
                                barcode.Paint().Save((ruta), ImageFormat.Png);
                                ptbBarras.LoadAsync(ruta);
                                MessageBox.Show("Código de barras generado satisfactoriamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("El código que intenta generar ya existe entre los archivos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }

                    }
                    catch
                    {
                        MessageBox.Show("Error inesperado al intentar obtener el código de barras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnVerGenerados_Click(object sender, EventArgs e)
        {
            frmListaArchivos oList = new frmListaArchivos();
            oList.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
