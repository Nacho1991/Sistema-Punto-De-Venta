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
using Datos;

namespace GUI
{
    public partial class frmCalculadora : Form
    {
        private double numUno;
        private double numDos;
        private string tipoOperacion;
        private Calculadora oCN;
        private bool operacionAnterior;

        public frmCalculadora()
        {
            InitializeComponent();
            operacionAnterior = false;
            tipoOperacion = "";
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            if (txtMonitor.Text == "0")
            {
                txtMonitor.Text = "";
            } 
            else if (operacionAnterior == true)
            {
                txtMonitor.Text = "";
                operacionAnterior = false;
            }
            txtMonitor.Text += 1;
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            if (txtMonitor.Text == "0")
            {
                txtMonitor.Text = "";
            }
            else if (operacionAnterior == true)
            {
                txtMonitor.Text = "";
                operacionAnterior = false;
            }
            txtMonitor.Text += 2;
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            if (txtMonitor.Text == "0")
            {
                txtMonitor.Text = "";
            }
            else if (operacionAnterior == true)
            {
                txtMonitor.Text = "";
                operacionAnterior = false;
            }
            txtMonitor.Text += 3;
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            if (txtMonitor.Text == "0")
            {
                txtMonitor.Text = "";
            }
            else if (operacionAnterior == true)
            {
                txtMonitor.Text = "";
                operacionAnterior = false;
            }
            txtMonitor.Text += 4;
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            if (txtMonitor.Text == "0")
            {
                txtMonitor.Text = "";
            }
            else if (operacionAnterior == true)
            {
                txtMonitor.Text = "";
                operacionAnterior = false;
            }
            txtMonitor.Text += 5;
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            if (txtMonitor.Text == "0")
            {
                txtMonitor.Text = "";
            }
            else if (operacionAnterior == true)
            {
                txtMonitor.Text = "";
                operacionAnterior = false;
            }
            txtMonitor.Text += 6;
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            if (txtMonitor.Text == "0")
            {
                txtMonitor.Text = "";
            }
            else if (operacionAnterior == true)
            {
                txtMonitor.Text = "";
                operacionAnterior = false;
            }
            txtMonitor.Text += 7;
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            if (txtMonitor.Text == "0")
            {
                txtMonitor.Text = "";
            }
            else if (operacionAnterior == true)
            {
                txtMonitor.Text = "";
                operacionAnterior = false;
            }
            txtMonitor.Text += 8;
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            if (txtMonitor.Text == "0")
            {
                txtMonitor.Text = "";
            }
            else if (operacionAnterior == true)
            {
                txtMonitor.Text = "";
                operacionAnterior = false;
            }
            txtMonitor.Text += 9;
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            if (txtMonitor.Text == "0")
            {
                txtMonitor.Text = "";
            }
            else if (operacionAnterior == true)
            {
                txtMonitor.Text = "";
                operacionAnterior = false;
            }
            txtMonitor.Text += 0;
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (txtMonitor.Text == "0")
            {
                txtMonitor.Text = "";
            }            else if (operacionAnterior == true)
            {
                txtMonitor.Text = "";
                operacionAnterior = false;
            }
            txtMonitor.Text += ".";
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            tipoOperacion = "+";
            if (esNumeroEntero(txtMonitor.Text) == true)
            {
                numUno = Convert.ToInt32(txtMonitor.Text);
                txtMonitor.Text = "";
            }
            else if (esNumeroDecimal(txtMonitor.Text) == true) 
            {
                numUno = Convert.ToDouble(txtMonitor.Text);
                txtMonitor.Text = "";
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            int resultado = 0;
            switch (tipoOperacion) 
            {
                case "%":
                    if (esNumeroEntero(txtMonitor.Text))
                    {
                        try
                        {
                            numDos = Convert.ToInt32(txtMonitor.Text);
                            Calculadora oCN = new Calculadora(numUno, numDos);
                            resultado = Convert.ToInt32(oCN.calculaPorcentaje());
                            txtMonitor.Text = "" + resultado+" %";
                            operacionAnterior = true;
                        }
                        catch (Exception t)
                        {
                            MessageBox.Show(t.ToString());
                        }
                    }
                    break;
                case "+":
                    if (esNumeroEntero(txtMonitor.Text))
                    {
                        try
                        {
                            numDos = Convert.ToInt32(txtMonitor.Text);
                            Calculadora oCN = new Calculadora(numUno, numDos);
                            resultado = Convert.ToInt32(oCN.calculaSuma());
                            txtMonitor.Text = "" + resultado;
                            operacionAnterior = true;
                        }
                        catch (Exception t)
                        {
                            MessageBox.Show(t.ToString());
                        }
                    }
                    else if (esNumeroDecimal(txtMonitor.Text))
                    {
                        numDos = Convert.ToDouble(txtMonitor.Text);
                        Calculadora oCN = new Calculadora(numUno, numDos);
                        txtMonitor.Text = "" + oCN.calculaSuma();
                        operacionAnterior = true;
                    }
                    break;
                case "*":
                    if (esNumeroEntero(txtMonitor.Text))
                    {
                        try
                        {
                            numDos = Convert.ToInt32(txtMonitor.Text);
                            Calculadora oCN = new Calculadora(numUno, numDos);
                            resultado = Convert.ToInt32(oCN.calculaMultiplicacion());
                            txtMonitor.Text = "" + resultado;
                            operacionAnterior = true;
                        }
                        catch (Exception y) 
                        {
                            MessageBox.Show(y.ToString());
                        }
                    }
                    else if (esNumeroDecimal(txtMonitor.Text))
                    {
                        numDos = Convert.ToDouble(txtMonitor.Text);
                        Calculadora oCN = new Calculadora(numUno, numDos);
                        txtMonitor.Text = "" + oCN.calculaMultiplicacion();
                        operacionAnterior = true;
                    }
                    
                    break;
                case "-":
                    if (esNumeroEntero(txtMonitor.Text))
                {
                    numDos = Convert.ToInt32(txtMonitor.Text);
                    Calculadora oCN = new Calculadora(numUno, numDos);
                    resultado = Convert.ToInt32(oCN.calculaResta());
                    txtMonitor.Text = "" + resultado;
                    operacionAnterior = true;
                }
                else if (esNumeroDecimal(txtMonitor.Text))
                {
                    numDos = Convert.ToDouble(txtMonitor.Text);
                    Calculadora oCN = new Calculadora(numUno, numDos);
                    txtMonitor.Text = "" + oCN.calculaResta();
                    operacionAnterior = true;
                }
                    break;
                case "/":
                     if (esNumeroEntero(txtMonitor.Text))
                {
                    numDos = Convert.ToInt32(txtMonitor.Text);
                    Calculadora oCN = new Calculadora(numUno, numDos);
                    resultado = Convert.ToInt32(oCN.calculaDivision());
                    txtMonitor.Text = "" + resultado;
                    operacionAnterior = true;
                }
                else if (esNumeroDecimal(txtMonitor.Text))
                {
                    numDos = Convert.ToDouble(txtMonitor.Text);
                    Calculadora oCN = new Calculadora(numUno, numDos);
                    txtMonitor.Text = "" + oCN.calculaDivision();
                    operacionAnterior = true;
                }
                    break;
            }
        }

        public bool esNumeroDecimal(string num) 
        {
            bool numEntero;
            try
            {
                Convert.ToDouble(num);
                numEntero = true;

            }
            catch 
            {
                numEntero = false;
            }
            return numEntero;
        }

        public bool esNumeroEntero(string num) 
        {
            bool numEntero;
            try
            {
                Convert.ToInt32(num);
                numEntero = true;
            }
            catch 
            {
                numEntero = false;
            }
            return numEntero;
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            tipoOperacion = "*";
            if (esNumeroEntero(txtMonitor.Text) == true)
            {
                numUno = Convert.ToInt32(txtMonitor.Text);
                txtMonitor.Text = "";
            }
            else if (esNumeroDecimal(txtMonitor.Text) == true)
            {
                numUno = Convert.ToDouble(txtMonitor.Text);
                txtMonitor.Text = "";
            }
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            tipoOperacion = "-";
            if (operacionAnterior == true || txtMonitor.Text == "0")
            {
                txtMonitor.Text = "";
                txtMonitor.Text += "-";
            }
            else if (esNumeroEntero(txtMonitor.Text) == true)
            {
                numUno = Convert.ToInt32(txtMonitor.Text);
                txtMonitor.Text = "";
            }
            else if (esNumeroDecimal(txtMonitor.Text) == true)
            {
                numUno = Convert.ToDouble(txtMonitor.Text);
                txtMonitor.Text = "";
            }
        }

        private void btnPorcentaje_Click(object sender, EventArgs e)
        {
            tipoOperacion = "%";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            tipoOperacion = "/";
            if (esNumeroEntero(txtMonitor.Text) == true)
            {
                numUno = Convert.ToInt32(txtMonitor.Text);
                txtMonitor.Text = "";
            }
            else if (esNumeroDecimal(txtMonitor.Text) == true)
            {
                numUno = Convert.ToDouble(txtMonitor.Text);
                txtMonitor.Text = "";
            }
        }

        private void btnBinario_Click(object sender, EventArgs e)
        {
            try
            {
                int valor = Convert.ToInt32(txtMonitor.Text);
                txtMonitor.Text = Convert.ToString(valor, 2);
            }
            catch 
            {
                MessageBox.Show("El valor a convertir a octal es demasiado grande para calcular o está fuera de los parametros permitidos.");
            }
        }

        private void btnOctal_Click(object sender, EventArgs e)
        {
            try
            {
                int valor = Convert.ToInt32(txtMonitor.Text);
                txtMonitor.Text = Convert.ToString(valor, 8);
            }
            catch (Exception y) 
            {
                MessageBox.Show("El valor a convertir a octal es demasiado grande para calcular o está fuera de los parametros permitidos.\nDetalle técnico: "+y.Message);
            }
        }

        private void btnExadecimal_Click(object sender, EventArgs e)
        {
            try
            {
                int valor = Convert.ToInt32(txtMonitor.Text);
                txtMonitor.Text = Convert.ToString(valor, 16);
            }
            catch 
            {
                MessageBox.Show("El valor a convertir está fuera de los parametros permitido o el rango es demasiado grande.");
            }
        }

        private void txtMonitor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.NumPad1))
            {
                if (txtMonitor.Text == "0")
                {
                    txtMonitor.Text = "";
                }
                txtMonitor.Text += 1;
            }
            else if (e.KeyChar == Convert.ToChar(Keys.NumPad2))
            {
                if (txtMonitor.Text == "0")
                {
                    txtMonitor.Text = "";
                }
                txtMonitor.Text += 2;
            }
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcercaDe oAD = new frmAcercaDe();
            oAD.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
