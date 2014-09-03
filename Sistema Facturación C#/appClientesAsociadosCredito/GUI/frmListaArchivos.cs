using GestorArchivos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmListaArchivos : Form
    {
        public frmListaArchivos()
        {
            InitializeComponent();
            cargaArchivos();
            dgvArchivos.Columns[0].Visible = false;
        }
        public void cargaArchivos()
        {
            try
            {
                string[] files = System.IO.Directory.GetFiles("C:\\Código de barras");
                List<Archivo> lista = new List<Archivo>();
                foreach (string item in files)
                {
                    lista.Add(new Archivo()
                    {
                        Nombre = item
                    });
                }
                dgvArchivos.DataSource = lista;
                if (dgvArchivos.RowCount == 0) 
                {
                    lblFechaCreacion.Text = "Sin datos";
                    lblInfo.Text = "Sin datos";
                    lblNombreArchivo.Text = "Sin datos";
                    lblTamanno.Text = "Sin datos";
                    lblTipoExtension.Text = "Sin datos";
                }
            }
            catch 
            {
                
            }
        }

        private void dgvArchivos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int index = dgvArchivos.CurrentRow.Index;
                string ruta = dgvArchivos[1, index].Value.ToString();
                DirectoryInfo file = new DirectoryInfo(Path.Combine(ruta));
                FileInfo infoArchivo = new FileInfo(file.FullName);

                lblNombreArchivo.Text = infoArchivo.Name;
                lblFechaCreacion.Text = infoArchivo.CreationTime.ToString();
                lblTipoExtension.Text = infoArchivo.Extension;
                lblTamanno.Text = infoArchivo.Length + " kB";
                if (lblTipoExtension.Text == ".png")
                {
                    ptbVistaPrevia.LoadAsync(ruta);
                    lblInfo.Visible = false;
                }
                else
                {
                    ptbVistaPrevia.Visible = false;
                    lblInfo.Visible = true;
                }
            }
            catch
            {
                
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ptbVistaPrevia_MouseClick(object sender, MouseEventArgs e)
        {
            //Preguntamos si el boton pulsado del Mouse es el Derecho
            //si no lo es no salimos sin hacer nada mas
            if (e.Button != MouseButtons.Right)
            {
                return;
            }
            //Definimos el lugar donde aparecera el scontextMenuStrip
            menuClickDerechoImagen.Show(MousePosition);
        }
        private string valorCelda = String.Empty;
        private void menuClickDerecho_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                int index = dgvArchivos.CurrentRow.Index;
                switch (e.ClickedItem.Name)
                {
                    case "itmAbrir":
                        menuClickDerechoImagen.Visible = false;
                        try
                        {
                            System.Diagnostics.Process.Start(dgvArchivos[1, index].Value.ToString());
                        }
                        catch
                        {
                            MessageBox.Show("Error inesperado al intentar abrir la imagen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case "itmEliminar":
                        menuClickDerechoImagen.Visible = false;
                        try
                        {
                            if (MessageBox.Show("¿Realemente desea eliminar éste código de barras?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                File.Delete(dgvArchivos[1, index].Value.ToString());
                                cargaArchivos();
                                ptbVistaPrevia.Image = null;
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Error al intentar eliminar el archivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        Clipboard.SetText(valorCelda);
                        break;
                    case "itmCopiar":
                        try
                        {
                            menuClickDerechoImagen.Visible = false;
                            if (fbdBuscador.ShowDialog() == DialogResult.OK)
                            {
                                System.IO.File.Copy(dgvArchivos[1, index].Value.ToString(), lblNombreArchivo.Text, true);
                                if (System.IO.Directory.Exists(fbdBuscador.SelectedPath))
                                {
                                    System.IO.File.Copy(dgvArchivos[1, index].Value.ToString(), fbdBuscador.SelectedPath+"\\"+lblNombreArchivo.Text, true);
                                    if (MessageBox.Show("Imagen copiada satisfactoriamente en la ruta: " + fbdBuscador.SelectedPath+"\\"+lblNombreArchivo.Text + "\n¿Desea abrir la imagen?","Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
                                    {
                                        System.Diagnostics.Process.Start(fbdBuscador.SelectedPath+"\\"+lblNombreArchivo.Text);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("El directorio seleccionado no existe o no tiene permisos administrativos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }

                        }
                        catch 
                        {
                            MessageBox.Show("Error inesperado al iniciar el proceso de copiado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                }
            }
            catch
            {

            }
        }
        private void menuClickDerechoOpciones_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                switch (e.ClickedItem.Name)
                {
                    case "itmEliminarMarcados":
                        menuClickDerechoOpciones.Visible = false;
                        for (int fil = 0; fil <= dgvArchivos.RowCount - 1; fil++)
                        {

                        }
                        cargaArchivos();
                        break;
                    case "itmEliminarSeleccionado":
                        menuClickDerechoOpciones.Visible = false;
                        int index = dgvArchivos.CurrentRow.Index;
                        dgvArchivos[0, index].Value = true;
                        break;
                    case "itmCancelarSeleccion":
                        menuClickDerechoOpciones.Visible = false;
                        for (int pos = 0; pos <= dgvArchivos.RowCount - 1; pos++)
                        {
                            bool marcado = Convert.ToBoolean(dgvArchivos[0, pos].Value.ToString());
                            if (marcado == true)
                            {
                                dgvArchivos[0, pos].Value = false;
                            }
                        }
                        dgvArchivos.Columns[0].Visible = false;
                        break;

                    case "itmMarcarVarios":
                        menuClickDerechoOpciones.Visible = false;
                        dgvArchivos.Columns[0].Visible = true;
                        break;
                    case "itmMarcarTodos":
                        menuClickDerechoOpciones.Visible = false;
                        this.dgvArchivos.Columns[0].Visible = true;
                        for (int pos = 0; pos <= dgvArchivos.RowCount - 1; pos++)
                        {
                            dgvArchivos[0, pos].Value = true;
                        }
                        break;
                    case "itmMarcarSeleccionado":
                        menuClickDerechoOpciones.Visible = false;
                        this.dgvArchivos.Columns[0].Visible = true;
                        index = dgvArchivos.CurrentRow.Index;
                        dgvArchivos[0, index].Value = true;
                        break;
                }
            }
            catch
            {

            }
        }

        private void dgvArchivos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
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
                dgvArchivos.Rows[e.RowIndex].Selected = true;
                //enviamos el valor de la celda a la variable _cellValue
                valorCelda = dgvArchivos[e.ColumnIndex, e.RowIndex].Value.ToString();
                //Definimos el lugar donde aparecera el scontextMenuStrip
                menuClickDerechoOpciones.Show(MousePosition);
                if (dgvArchivos.Columns[0].Visible == true)
                {
                    itmCancelarSeleccion.Visible = true;
                    itmEliminarMarcados.Visible = true;
                    itmEliminarMarcados.Visible = true;
                    itmMarcarSeleccionado.Visible = false;
                    itmMarcarTodos.Visible = false;
                    itmMarcarVarios.Visible = false;
                }
                else
                {
                    itmCancelarSeleccion.Visible = false;
                    itmEliminarMarcados.Visible = false;
                    itmEliminarMarcados.Visible = false;
                    itmMarcarSeleccionado.Visible = true;
                    itmMarcarTodos.Visible = true;
                    itmMarcarVarios.Visible = true;
                }
            }
            catch 
            {

            }
        }
    }
}
