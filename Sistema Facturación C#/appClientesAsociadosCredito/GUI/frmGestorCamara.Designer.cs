namespace GUI
{
    partial class frmGestorCamara
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestorCamara));
            this.gruBoxDatos = new System.Windows.Forms.GroupBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblInfoEstadoCam = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.grBoxImagen = new System.Windows.Forms.GroupBox();
            this.EspacioCamara = new System.Windows.Forms.PictureBox();
            this.gruBoxOpciones = new System.Windows.Forms.GroupBox();
            this.cbxDispositivo = new System.Windows.Forms.ComboBox();
            this.btnImportarFotoCand = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.lblListaCamaras = new System.Windows.Forms.Label();
            this.btnTomarFoto = new System.Windows.Forms.Button();
            this.panBotones = new System.Windows.Forms.Panel();
            this.menuClickDerechoFoto = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itmAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.itmEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.itmCopiar = new System.Windows.Forms.ToolStripMenuItem();
            this.fbdBuscador = new System.Windows.Forms.FolderBrowserDialog();
            this.itmAbrirImagen = new System.Windows.Forms.ToolStripMenuItem();
            this.itmAbrirCarpeta = new System.Windows.Forms.ToolStripMenuItem();
            this.gruBoxDatos.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.grBoxImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EspacioCamara)).BeginInit();
            this.gruBoxOpciones.SuspendLayout();
            this.panBotones.SuspendLayout();
            this.menuClickDerechoFoto.SuspendLayout();
            this.SuspendLayout();
            // 
            // gruBoxDatos
            // 
            this.gruBoxDatos.Controls.Add(this.txtCedula);
            this.gruBoxDatos.Controls.Add(this.txtNombre);
            this.gruBoxDatos.Controls.Add(this.lblCedula);
            this.gruBoxDatos.Controls.Add(this.lblNombre);
            this.gruBoxDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.gruBoxDatos.Location = new System.Drawing.Point(0, 0);
            this.gruBoxDatos.Margin = new System.Windows.Forms.Padding(5);
            this.gruBoxDatos.Name = "gruBoxDatos";
            this.gruBoxDatos.Padding = new System.Windows.Forms.Padding(5);
            this.gruBoxDatos.Size = new System.Drawing.Size(509, 66);
            this.gruBoxDatos.TabIndex = 14;
            this.gruBoxDatos.TabStop = false;
            this.gruBoxDatos.Text = "Datos";
            // 
            // txtCedula
            // 
            this.txtCedula.Enabled = false;
            this.txtCedula.Location = new System.Drawing.Point(367, 24);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(5);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.ReadOnly = true;
            this.txtCedula.Size = new System.Drawing.Size(123, 21);
            this.txtCedula.TabIndex = 2;
            this.txtCedula.Tag = "Ingrese el número de cédula del candidato";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(82, 24);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(214, 21);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Tag = "Ingrese el nombre del candidato";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(308, 27);
            this.lblCedula.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(49, 15);
            this.lblCedula.TabIndex = 2;
            this.lblCedula.Text = "Cédula:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(17, 27);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(55, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstado,
            this.lblInfoEstadoCam});
            this.statusStrip1.Location = new System.Drawing.Point(0, 350);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 22, 0);
            this.statusStrip1.Size = new System.Drawing.Size(509, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 20;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblEstado
            // 
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(125, 17);
            this.lblEstado.Text = "Estado de la WebCam:";
            // 
            // lblInfoEstadoCam
            // 
            this.lblInfoEstadoCam.Name = "lblInfoEstadoCam";
            this.lblInfoEstadoCam.Size = new System.Drawing.Size(0, 17);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(311, 5);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(113, 39);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(105, 5);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(95, 39);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // grBoxImagen
            // 
            this.grBoxImagen.Controls.Add(this.EspacioCamara);
            this.grBoxImagen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grBoxImagen.Location = new System.Drawing.Point(180, 66);
            this.grBoxImagen.Margin = new System.Windows.Forms.Padding(5);
            this.grBoxImagen.Name = "grBoxImagen";
            this.grBoxImagen.Padding = new System.Windows.Forms.Padding(5);
            this.grBoxImagen.Size = new System.Drawing.Size(329, 234);
            this.grBoxImagen.TabIndex = 16;
            this.grBoxImagen.TabStop = false;
            this.grBoxImagen.Text = "Foto";
            // 
            // EspacioCamara
            // 
            this.EspacioCamara.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EspacioCamara.Location = new System.Drawing.Point(5, 19);
            this.EspacioCamara.Margin = new System.Windows.Forms.Padding(5);
            this.EspacioCamara.Name = "EspacioCamara";
            this.EspacioCamara.Size = new System.Drawing.Size(319, 210);
            this.EspacioCamara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EspacioCamara.TabIndex = 8;
            this.EspacioCamara.TabStop = false;
            this.EspacioCamara.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EspacioCamara_MouseClick);
            // 
            // gruBoxOpciones
            // 
            this.gruBoxOpciones.Controls.Add(this.cbxDispositivo);
            this.gruBoxOpciones.Controls.Add(this.btnImportarFotoCand);
            this.gruBoxOpciones.Controls.Add(this.btnIniciar);
            this.gruBoxOpciones.Controls.Add(this.lblListaCamaras);
            this.gruBoxOpciones.Controls.Add(this.btnTomarFoto);
            this.gruBoxOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.gruBoxOpciones.Location = new System.Drawing.Point(0, 66);
            this.gruBoxOpciones.Margin = new System.Windows.Forms.Padding(5);
            this.gruBoxOpciones.Name = "gruBoxOpciones";
            this.gruBoxOpciones.Padding = new System.Windows.Forms.Padding(5);
            this.gruBoxOpciones.Size = new System.Drawing.Size(180, 234);
            this.gruBoxOpciones.TabIndex = 15;
            this.gruBoxOpciones.TabStop = false;
            this.gruBoxOpciones.Text = "Opciones de cámara";
            // 
            // cbxDispositivo
            // 
            this.cbxDispositivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDispositivo.FormattingEnabled = true;
            this.cbxDispositivo.Location = new System.Drawing.Point(13, 208);
            this.cbxDispositivo.Margin = new System.Windows.Forms.Padding(5);
            this.cbxDispositivo.Name = "cbxDispositivo";
            this.cbxDispositivo.Size = new System.Drawing.Size(163, 23);
            this.cbxDispositivo.TabIndex = 7;
            this.cbxDispositivo.Tag = "Muestra la lista de los dispositivos WebCam disponibles en su equipo";
            // 
            // btnImportarFotoCand
            // 
            this.btnImportarFotoCand.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImportarFotoCand.Image = ((System.Drawing.Image)(resources.GetObject("btnImportarFotoCand.Image")));
            this.btnImportarFotoCand.Location = new System.Drawing.Point(20, 30);
            this.btnImportarFotoCand.Margin = new System.Windows.Forms.Padding(5);
            this.btnImportarFotoCand.Name = "btnImportarFotoCand";
            this.btnImportarFotoCand.Size = new System.Drawing.Size(137, 44);
            this.btnImportarFotoCand.TabIndex = 4;
            this.btnImportarFotoCand.Tag = "Importe una foto de perfil desde cualquier dispositivo de almacenamiento";
            this.btnImportarFotoCand.Text = "Importar foto";
            this.btnImportarFotoCand.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImportarFotoCand.UseVisualStyleBackColor = false;
            this.btnImportarFotoCand.Click += new System.EventHandler(this.btnImportarFotoCand_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIniciar.Image = ((System.Drawing.Image)(resources.GetObject("btnIniciar.Image")));
            this.btnIniciar.Location = new System.Drawing.Point(17, 138);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(5);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(137, 44);
            this.btnIniciar.TabIndex = 6;
            this.btnIniciar.Tag = "Inicia la WebCam de su equipo";
            this.btnIniciar.Text = "Iniciar camara";
            this.btnIniciar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // lblListaCamaras
            // 
            this.lblListaCamaras.AutoSize = true;
            this.lblListaCamaras.Location = new System.Drawing.Point(10, 187);
            this.lblListaCamaras.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblListaCamaras.Name = "lblListaCamaras";
            this.lblListaCamaras.Size = new System.Drawing.Size(126, 15);
            this.lblListaCamaras.TabIndex = 14;
            this.lblListaCamaras.Text = "Camaras disponibles:";
            // 
            // btnTomarFoto
            // 
            this.btnTomarFoto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTomarFoto.Image = ((System.Drawing.Image)(resources.GetObject("btnTomarFoto.Image")));
            this.btnTomarFoto.Location = new System.Drawing.Point(17, 84);
            this.btnTomarFoto.Margin = new System.Windows.Forms.Padding(5);
            this.btnTomarFoto.Name = "btnTomarFoto";
            this.btnTomarFoto.Size = new System.Drawing.Size(137, 44);
            this.btnTomarFoto.TabIndex = 5;
            this.btnTomarFoto.Tag = "Tome una foto de perfil desde la WebCam intengrada del equipo";
            this.btnTomarFoto.Text = "Tomar foto";
            this.btnTomarFoto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTomarFoto.UseVisualStyleBackColor = false;
            this.btnTomarFoto.Click += new System.EventHandler(this.btnTomarFoto_Click);
            // 
            // panBotones
            // 
            this.panBotones.Controls.Add(this.btnCancelar);
            this.panBotones.Controls.Add(this.btnAgregar);
            this.panBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panBotones.Location = new System.Drawing.Point(0, 300);
            this.panBotones.Margin = new System.Windows.Forms.Padding(5);
            this.panBotones.Name = "panBotones";
            this.panBotones.Size = new System.Drawing.Size(509, 50);
            this.panBotones.TabIndex = 17;
            // 
            // menuClickDerechoFoto
            // 
            this.menuClickDerechoFoto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmAbrir,
            this.itmEliminar,
            this.itmCopiar});
            this.menuClickDerechoFoto.Name = "menuClickDerechoFoto";
            this.menuClickDerechoFoto.Size = new System.Drawing.Size(153, 92);
            this.menuClickDerechoFoto.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuClickDerechoFoto_ItemClicked);
            // 
            // itmAbrir
            // 
            this.itmAbrir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmAbrirImagen,
            this.itmAbrirCarpeta});
            this.itmAbrir.Image = global::appClientesAsociadosCredito.Properties.Resources.file_23675_640;
            this.itmAbrir.Name = "itmAbrir";
            this.itmAbrir.Size = new System.Drawing.Size(152, 22);
            this.itmAbrir.Text = "Abrir";
            // 
            // itmEliminar
            // 
            this.itmEliminar.Image = ((System.Drawing.Image)(resources.GetObject("itmEliminar.Image")));
            this.itmEliminar.Name = "itmEliminar";
            this.itmEliminar.Size = new System.Drawing.Size(152, 22);
            this.itmEliminar.Text = "Eliminar";
            // 
            // itmCopiar
            // 
            this.itmCopiar.Image = global::appClientesAsociadosCredito.Properties.Resources.Editing_Copy_icon;
            this.itmCopiar.Name = "itmCopiar";
            this.itmCopiar.Size = new System.Drawing.Size(152, 22);
            this.itmCopiar.Text = "Copiar";
            // 
            // itmAbrirImagen
            // 
            this.itmAbrirImagen.Name = "itmAbrirImagen";
            this.itmAbrirImagen.Size = new System.Drawing.Size(152, 22);
            this.itmAbrirImagen.Text = "Abrir imagen";
            this.itmAbrirImagen.Click += new System.EventHandler(this.itmAbrirImagen_Click);
            // 
            // itmAbrirCarpeta
            // 
            this.itmAbrirCarpeta.Name = "itmAbrirCarpeta";
            this.itmAbrirCarpeta.Size = new System.Drawing.Size(152, 22);
            this.itmAbrirCarpeta.Text = "Abrir carpeta";
            this.itmAbrirCarpeta.Click += new System.EventHandler(this.itmAbrirCarpeta_Click);
            // 
            // frmGestorCamara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(509, 372);
            this.Controls.Add(this.grBoxImagen);
            this.Controls.Add(this.gruBoxOpciones);
            this.Controls.Add(this.panBotones);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gruBoxDatos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGestorCamara";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de WebCam";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGestorCamara_FormClosing);
            this.gruBoxDatos.ResumeLayout(false);
            this.gruBoxDatos.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grBoxImagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EspacioCamara)).EndInit();
            this.gruBoxOpciones.ResumeLayout(false);
            this.gruBoxOpciones.PerformLayout();
            this.panBotones.ResumeLayout(false);
            this.menuClickDerechoFoto.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gruBoxDatos;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblEstado;
        private System.Windows.Forms.ToolStripStatusLabel lblInfoEstadoCam;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox grBoxImagen;
        private System.Windows.Forms.PictureBox EspacioCamara;
        private System.Windows.Forms.GroupBox gruBoxOpciones;
        private System.Windows.Forms.ComboBox cbxDispositivo;
        private System.Windows.Forms.Label lblListaCamaras;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnImportarFotoCand;
        private System.Windows.Forms.Button btnTomarFoto;
        private System.Windows.Forms.Panel panBotones;
        private System.Windows.Forms.ContextMenuStrip menuClickDerechoFoto;
        private System.Windows.Forms.ToolStripMenuItem itmAbrir;
        private System.Windows.Forms.ToolStripMenuItem itmEliminar;
        private System.Windows.Forms.ToolStripMenuItem itmCopiar;
        private System.Windows.Forms.FolderBrowserDialog fbdBuscador;
        private System.Windows.Forms.ToolStripMenuItem itmAbrirImagen;
        private System.Windows.Forms.ToolStripMenuItem itmAbrirCarpeta;
    }
}