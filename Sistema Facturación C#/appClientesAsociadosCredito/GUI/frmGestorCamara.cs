using AForge.Video;
using AForge.Video.DirectShow;
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
    public partial class frmGestorCamara : Form
    {
        private bool ExisteDispositivo = false;
        private FilterInfoCollection DispositivoDeVideo;
        private VideoCaptureDevice FuenteDeVideo = null;
        public frmGestorCamara(string pNombre,string pCedula)
        {
            InitializeComponent();
            txtNombre.Text = pNombre;
            txtCedula.Text = pCedula;
            BuscarDispositivos();
            lblInfoEstadoCam.Text = "Sin inicializarse";
            btnTomarFoto.Enabled = false;
            Directory.CreateDirectory(@"c:\Carpeta Temporal");
        }
        public void BuscarDispositivos()
        {
            try
            {
                DispositivoDeVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                if (DispositivoDeVideo.Count == 0)
                {
                    ExisteDispositivo = false;
                }
                else
                {
                    ExisteDispositivo = true;
                    CargarDispositivos(DispositivoDeVideo);
                }
            }
            catch (Exception xp)
            {
                MessageBox.Show("Error al intentar buscar los dispositivos WebCam.\n" + "Detalle técnico: " + xp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CargarDispositivos(FilterInfoCollection Dispositivos)
        {
            try
            {
                for (int i = 0; i < Dispositivos.Count; i++) ;
                cbxDispositivo.Items.Add(Dispositivos[0].Name.ToString());
                cbxDispositivo.Text = cbxDispositivo.Items[0].ToString();
            }
            catch
            {
                MessageBox.Show("Error al intentar cargar el dispositivo WebCam o no existe en su equipo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Video_NuevoFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
                EspacioCamara.Image = Imagen;
            }
            catch
            {
                MessageBox.Show("Error al intentar mostrar la imagen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void TerminarFuenteDeVideo()
        {
            try
            {
                if (!(FuenteDeVideo == null))
                    if (FuenteDeVideo.IsRunning)
                    {
                        FuenteDeVideo.SignalToStop();
                        FuenteDeVideo = null;
                    }
            }
            catch
            {
                MessageBox.Show("Error al intentar apagar la WebCam", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnImportarFotoCand_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Title = "Abrir";
                open.Filter = "Imagenes JPG|*.jpg";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(@"C:\\Carpeta Temporal\\" + txtCedula.Text + ".jpg"))
                    {
                        MessageBox.Show("Ya existe una foto de perfil asociada a éste empleado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else 
                    {
                        string ruta = open.FileName;
                        if (Directory.Exists(@"C:\Carpeta Temporal"))
                        {
                            File.Copy(ruta, @"C:\\Carpeta Temporal\\" + txtCedula.Text + ".jpg", true);
                            EspacioCamara.LoadAsync(ruta);
                            EspacioCamara.Image = null;
                        }
                        else 
                        {
                            if (MessageBox.Show("La carpeta de destino ha sido eliminada o no existe. ¿Desea crear el directorio de destino?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
                            {
                                try
                                {
                                    Directory.CreateDirectory(@"C:\\Carpeta Temporal");
                                    MessageBox.Show("Directorio creado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                catch 
                                {
                                    MessageBox.Show("Error inesparado al intentar crear el directorio de destino.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception xp)
            {
                MessageBox.Show("Error al intentar abrir el archivo.\nDetalle técnico: " + xp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTomarFoto_Click(object sender, EventArgs e)
        {
            try
            {
                string ruta = @"C:\Carpeta Temporal\" + txtCedula.Text + ".jpg";
                if (Directory.Exists(@"C:\Carpeta Temporal"))
                {
                    if (File.Exists(ruta))
                    {
                        MessageBox.Show("Ya existe una foto de perfil asociada al empleado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (txtNombre.Text != "" && txtCedula.Text != "")
                        {
                            EspacioCamara.Image.Save(ruta, ImageFormat.Jpeg);
                            TerminarFuenteDeVideo();
                            btnIniciar.Text = "Iniciar camara";
                            btnIniciar.Text = "Reemplazar foto";
                            btnImportarFotoCand.Enabled = true;
                            cbxDispositivo.Enabled = true;
                            btnTomarFoto.Enabled = false;
                            EspacioCamara.LoadAsync(ruta);
                        }
                        else
                        {
                            MessageBox.Show("No hay datos ingresado por favor ingreselos para continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else 
                {
                    if (MessageBox.Show("La caperta de destino ha sido eliminada o no existe. ¿Desea crear el directorio de destino?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            Directory.CreateDirectory(@"C:\Carpeta Temporal");
                            MessageBox.Show("Directorio creado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception xp)
                        {
                            MessageBox.Show("Error inesparado al intentar crear el directorio. \nDetalle técnico: " + xp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception xp)
            {
                MessageBox.Show("Error al intentar guardar la imagen.\nDetalle técnico: " + xp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnIniciar.Text == "Iniciar camara")
                {
                    if (ExisteDispositivo)
                    {

                        FuenteDeVideo = new VideoCaptureDevice(DispositivoDeVideo[cbxDispositivo.SelectedIndex].MonikerString);
                        FuenteDeVideo.NewFrame += new NewFrameEventHandler(Video_NuevoFrame);
                        FuenteDeVideo.Start();
                        lblInfoEstadoCam.Text = "Ejecutando Dispositivo…";
                        btnIniciar.Text = "Detener";
                        cbxDispositivo.Enabled = false;
                        btnImportarFotoCand.Enabled = false;
                        btnTomarFoto.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Problemas al intentar iniciar la cámara.\nPosible error de Driver o su equipo no cuenta con WebCam.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }

                }
                else if (btnIniciar.Text == "Reemplazar foto")
                {
                    File.Delete(@"C:\\Carpeta Temporal\\" + txtCedula.Text + ".jpg");
                    FuenteDeVideo = new VideoCaptureDevice(DispositivoDeVideo[cbxDispositivo.SelectedIndex].MonikerString);
                    FuenteDeVideo.NewFrame += new NewFrameEventHandler(Video_NuevoFrame);
                    FuenteDeVideo.Start();
                    lblInfoEstadoCam.Text = "Dispositivo detenido…";
                    btnIniciar.Text = "Detener";
                    cbxDispositivo.Enabled = false;
                    btnImportarFotoCand.Enabled = false;
                    btnTomarFoto.Enabled = true;
                    grBoxImagen.Text = DispositivoDeVideo[cbxDispositivo.SelectedIndex].Name.ToString();
                }
                else
                {
                    if (FuenteDeVideo.IsRunning)
                    {
                        TerminarFuenteDeVideo();
                        lblInfoEstadoCam.Text = "Dispositivo Detenido…";
                        btnIniciar.Text = "Iniciar camara";
                        cbxDispositivo.Enabled = true;
                        EspacioCamara.Image = null;
                        btnTomarFoto.Enabled = false;
                        btnImportarFotoCand.Enabled = true;
                    }
                }
            }
            catch (Exception xp)
            {
                MessageBox.Show("Error al iniciar el dispositivo." + "\nDetalle técnico: " + xp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void frmGestorCamara_FormClosing(object sender, FormClosingEventArgs e)
        {
            TerminarFuenteDeVideo();
        }

        private void EspacioCamara_MouseClick(object sender, MouseEventArgs e)
        {
            //Preguntamos si el boton pulsado del Mouse es el Derecho
            //si no lo es no salimos sin hacer nada mas
            if (e.Button != MouseButtons.Right)
            {
                return;
            }
            //Definimos el lugar donde aparecera el scontextMenuStrip
            if (File.Exists(@"C:\\Carpeta Temporal\\" + txtCedula.Text + ".jpg")) 
            
            {
                if (btnIniciar.Text == "Reemplazar foto")
                {
                    menuClickDerechoFoto.Show(MousePosition);
                }
            }
        }
        private string valorCelda = String.Empty;

        private void menuClickDerechoFoto_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                switch (e.ClickedItem.Name)
                {
                    case "itmEliminar":
                        menuClickDerechoFoto.Visible = false;
                        try
                        {
                            if (MessageBox.Show("¿Realemente desea eliminar ésta fotografía?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                File.Delete(@"C:\\Carpeta Temporal\\" + txtCedula.Text + ".jpg");
                                EspacioCamara.Image = null;
                                btnIniciar.Text = "Iniciar camara";
                                MessageBox.Show("Imagen eliminada con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            menuClickDerechoFoto.Visible = false;
                            if (fbdBuscador.ShowDialog() == DialogResult.OK)
                            {
                                System.IO.File.Copy(@"C:\\Carpeta Temporal\\" + txtCedula.Text + ".jpg", txtCedula.Text+".jpg", true);
                                if (System.IO.Directory.Exists(fbdBuscador.SelectedPath))
                                {
                                    if (File.Exists(@"C:\\Carpeta Temporal\\" + txtCedula.Text + ".jpg"))
                                    {
                                        if (MessageBox.Show("La imagen que intenta copiar ya existe. ¿Desea reemplazaral?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                        {
                                            System.IO.File.Copy(@"C:\\Carpeta Temporal\\" + txtCedula.Text + ".jpg", fbdBuscador.SelectedPath + "\\" + txtCedula.Text + ".jpg", true);
                                            if (MessageBox.Show("Imagen copiada satisfactoriamente en la ruta: " + fbdBuscador.SelectedPath + "\\" + txtCedula.Text + ".jpg" + "\n¿Desea abrir la imagen?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                            {
                                                System.Diagnostics.Process.Start(fbdBuscador.SelectedPath + "\\" + txtCedula.Text + ".jpg");
                                            }
                                        }
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void itmAbrirImagen_Click(object sender, EventArgs e)
        {
            menuClickDerechoFoto.Visible = false;
            try
            {
                System.Diagnostics.Process.Start(@"C:\\Carpeta Temporal\\" + txtCedula.Text + ".jpg");
            }
            catch
            {
                MessageBox.Show("Error inesperado al intentar abrir la imagen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void itmAbrirCarpeta_Click(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(@"C:\\Carpeta Temporal"))
                {
                    System.Diagnostics.Process.Start(@"C:\\Carpeta Temporal");
                }
                else 
                {
                    MessageBox.Show("La carpeta que contiene la imagen ha sido eliminada o no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch 
            {
                MessageBox.Show("Error inesperado al intentar abrir la carpeta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
