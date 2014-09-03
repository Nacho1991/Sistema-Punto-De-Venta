namespace GUI
{
    partial class frmListaArchivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaArchivos));
            this.dgvArchivos = new System.Windows.Forms.DataGridView();
            this.clmSeleccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmRuta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbArchivos = new System.Windows.Forms.GroupBox();
            this.grbDetalles = new System.Windows.Forms.GroupBox();
            this.lblTamanno = new System.Windows.Forms.Label();
            this.lblFechaCreacion = new System.Windows.Forms.Label();
            this.lblTipoExtension = new System.Windows.Forms.Label();
            this.lblNombreArchivo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.ptbVistaPrevia = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.menuClickDerechoImagen = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itmAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.itmEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.itmCopiar = new System.Windows.Forms.ToolStripMenuItem();
            this.fbdBuscador = new System.Windows.Forms.FolderBrowserDialog();
            this.menuClickDerechoOpciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itmMarcarVarios = new System.Windows.Forms.ToolStripMenuItem();
            this.itmMarcarTodos = new System.Windows.Forms.ToolStripMenuItem();
            this.itmMarcarSeleccionado = new System.Windows.Forms.ToolStripMenuItem();
            this.itmEliminarMarcados = new System.Windows.Forms.ToolStripMenuItem();
            this.itmEliminarSeleccionado = new System.Windows.Forms.ToolStripMenuItem();
            this.itmCancelarSeleccion = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchivos)).BeginInit();
            this.grbArchivos.SuspendLayout();
            this.grbDetalles.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbVistaPrevia)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuClickDerechoImagen.SuspendLayout();
            this.menuClickDerechoOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArchivos
            // 
            this.dgvArchivos.AllowUserToAddRows = false;
            this.dgvArchivos.AllowUserToDeleteRows = false;
            this.dgvArchivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArchivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSeleccion,
            this.clmRuta});
            this.dgvArchivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvArchivos.Location = new System.Drawing.Point(3, 16);
            this.dgvArchivos.MultiSelect = false;
            this.dgvArchivos.Name = "dgvArchivos";
            this.dgvArchivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArchivos.Size = new System.Drawing.Size(365, 295);
            this.dgvArchivos.TabIndex = 0;
            this.dgvArchivos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvArchivos_CellMouseClick);
            this.dgvArchivos.SelectionChanged += new System.EventHandler(this.dgvArchivos_SelectionChanged);
            // 
            // clmSeleccion
            // 
            this.clmSeleccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmSeleccion.HeaderText = "Seleccionar";
            this.clmSeleccion.Name = "clmSeleccion";
            this.clmSeleccion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmSeleccion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmSeleccion.Width = 88;
            // 
            // clmRuta
            // 
            this.clmRuta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmRuta.DataPropertyName = "Nombre";
            this.clmRuta.HeaderText = "Ruta del archivo";
            this.clmRuta.Name = "clmRuta";
            this.clmRuta.ReadOnly = true;
            this.clmRuta.Width = 101;
            // 
            // grbArchivos
            // 
            this.grbArchivos.Controls.Add(this.dgvArchivos);
            this.grbArchivos.Controls.Add(this.grbDetalles);
            this.grbArchivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbArchivos.Location = new System.Drawing.Point(0, 78);
            this.grbArchivos.Name = "grbArchivos";
            this.grbArchivos.Size = new System.Drawing.Size(647, 314);
            this.grbArchivos.TabIndex = 1;
            this.grbArchivos.TabStop = false;
            this.grbArchivos.Text = "Archivos";
            // 
            // grbDetalles
            // 
            this.grbDetalles.Controls.Add(this.lblTamanno);
            this.grbDetalles.Controls.Add(this.lblFechaCreacion);
            this.grbDetalles.Controls.Add(this.lblTipoExtension);
            this.grbDetalles.Controls.Add(this.lblNombreArchivo);
            this.grbDetalles.Controls.Add(this.label4);
            this.grbDetalles.Controls.Add(this.label3);
            this.grbDetalles.Controls.Add(this.label2);
            this.grbDetalles.Controls.Add(this.label1);
            this.grbDetalles.Controls.Add(this.groupBox1);
            this.grbDetalles.Dock = System.Windows.Forms.DockStyle.Right;
            this.grbDetalles.Location = new System.Drawing.Point(368, 16);
            this.grbDetalles.Name = "grbDetalles";
            this.grbDetalles.Size = new System.Drawing.Size(276, 295);
            this.grbDetalles.TabIndex = 1;
            this.grbDetalles.TabStop = false;
            this.grbDetalles.Text = "Detalles";
            // 
            // lblTamanno
            // 
            this.lblTamanno.AutoSize = true;
            this.lblTamanno.Location = new System.Drawing.Point(135, 79);
            this.lblTamanno.Name = "lblTamanno";
            this.lblTamanno.Size = new System.Drawing.Size(17, 13);
            this.lblTamanno.TabIndex = 9;
            this.lblTamanno.Text = "\"\"";
            // 
            // lblFechaCreacion
            // 
            this.lblFechaCreacion.AutoSize = true;
            this.lblFechaCreacion.Location = new System.Drawing.Point(135, 105);
            this.lblFechaCreacion.Name = "lblFechaCreacion";
            this.lblFechaCreacion.Size = new System.Drawing.Size(17, 13);
            this.lblFechaCreacion.TabIndex = 8;
            this.lblFechaCreacion.Text = "\"\"";
            // 
            // lblTipoExtension
            // 
            this.lblTipoExtension.AutoSize = true;
            this.lblTipoExtension.Location = new System.Drawing.Point(135, 54);
            this.lblTipoExtension.Name = "lblTipoExtension";
            this.lblTipoExtension.Size = new System.Drawing.Size(17, 13);
            this.lblTipoExtension.TabIndex = 6;
            this.lblTipoExtension.Text = "\"\"";
            // 
            // lblNombreArchivo
            // 
            this.lblNombreArchivo.AutoSize = true;
            this.lblNombreArchivo.Location = new System.Drawing.Point(135, 30);
            this.lblNombreArchivo.Name = "lblNombreArchivo";
            this.lblNombreArchivo.Size = new System.Drawing.Size(17, 13);
            this.lblNombreArchivo.TabIndex = 5;
            this.lblNombreArchivo.Text = "\"\"";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha de creación:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tamaño:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo de extensión:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del archivo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblInfo);
            this.groupBox1.Controls.Add(this.ptbVistaPrevia);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(3, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 156);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vista previa";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(-614, -391);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(107, 13);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Formato incompatible";
            // 
            // ptbVistaPrevia
            // 
            this.ptbVistaPrevia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbVistaPrevia.Location = new System.Drawing.Point(3, 16);
            this.ptbVistaPrevia.Name = "ptbVistaPrevia";
            this.ptbVistaPrevia.Size = new System.Drawing.Size(264, 137);
            this.ptbVistaPrevia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbVistaPrevia.TabIndex = 0;
            this.ptbVistaPrevia.TabStop = false;
            this.ptbVistaPrevia.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ptbVistaPrevia_MouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 392);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 43);
            this.panel1.TabIndex = 2;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(240, 6);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(98, 30);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // grbDatos
            // 
            this.grbDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbDatos.Location = new System.Drawing.Point(0, 0);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Size = new System.Drawing.Size(647, 78);
            this.grbDatos.TabIndex = 3;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "Datos";
            // 
            // menuClickDerechoImagen
            // 
            this.menuClickDerechoImagen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmAbrir,
            this.itmEliminar,
            this.itmCopiar});
            this.menuClickDerechoImagen.Name = "menuClickDerecho";
            this.menuClickDerechoImagen.Size = new System.Drawing.Size(118, 70);
            this.menuClickDerechoImagen.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuClickDerecho_ItemClicked);
            // 
            // itmAbrir
            // 
            this.itmAbrir.Image = ((System.Drawing.Image)(resources.GetObject("itmAbrir.Image")));
            this.itmAbrir.Name = "itmAbrir";
            this.itmAbrir.Size = new System.Drawing.Size(117, 22);
            this.itmAbrir.Text = "Abrir";
            // 
            // itmEliminar
            // 
            this.itmEliminar.Image = global::appClientesAsociadosCredito.Properties.Resources.forbidden_159816_640;
            this.itmEliminar.Name = "itmEliminar";
            this.itmEliminar.Size = new System.Drawing.Size(117, 22);
            this.itmEliminar.Text = "Eliminar";
            // 
            // itmCopiar
            // 
            this.itmCopiar.Image = global::appClientesAsociadosCredito.Properties.Resources.Editing_Copy_icon;
            this.itmCopiar.Name = "itmCopiar";
            this.itmCopiar.Size = new System.Drawing.Size(117, 22);
            this.itmCopiar.Text = "Copiar";
            // 
            // menuClickDerechoOpciones
            // 
            this.menuClickDerechoOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmMarcarVarios,
            this.itmMarcarTodos,
            this.itmMarcarSeleccionado,
            this.itmEliminarMarcados,
            this.itmEliminarSeleccionado,
            this.itmCancelarSeleccion});
            this.menuClickDerechoOpciones.Name = "menuClickDerechoOpciones";
            this.menuClickDerechoOpciones.Size = new System.Drawing.Size(190, 136);
            this.menuClickDerechoOpciones.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuClickDerechoOpciones_ItemClicked);
            // 
            // itmMarcarVarios
            // 
            this.itmMarcarVarios.Name = "itmMarcarVarios";
            this.itmMarcarVarios.Size = new System.Drawing.Size(189, 22);
            this.itmMarcarVarios.Text = "Marcar varios";
            // 
            // itmMarcarTodos
            // 
            this.itmMarcarTodos.Name = "itmMarcarTodos";
            this.itmMarcarTodos.Size = new System.Drawing.Size(189, 22);
            this.itmMarcarTodos.Text = "Marcar todos";
            // 
            // itmMarcarSeleccionado
            // 
            this.itmMarcarSeleccionado.Name = "itmMarcarSeleccionado";
            this.itmMarcarSeleccionado.Size = new System.Drawing.Size(189, 22);
            this.itmMarcarSeleccionado.Text = "Marcar seleccionado";
            // 
            // itmEliminarMarcados
            // 
            this.itmEliminarMarcados.Name = "itmEliminarMarcados";
            this.itmEliminarMarcados.Size = new System.Drawing.Size(189, 22);
            this.itmEliminarMarcados.Text = "Eliminar marcados";
            this.itmEliminarMarcados.Visible = false;
            // 
            // itmEliminarSeleccionado
            // 
            this.itmEliminarSeleccionado.Name = "itmEliminarSeleccionado";
            this.itmEliminarSeleccionado.Size = new System.Drawing.Size(189, 22);
            this.itmEliminarSeleccionado.Text = "Eliminar seleccionado";
            this.itmEliminarSeleccionado.Visible = false;
            // 
            // itmCancelarSeleccion
            // 
            this.itmCancelarSeleccion.Name = "itmCancelarSeleccion";
            this.itmCancelarSeleccion.Size = new System.Drawing.Size(189, 22);
            this.itmCancelarSeleccion.Text = "Cancelar selección";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmListaArchivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(647, 435);
            this.Controls.Add(this.grbArchivos);
            this.Controls.Add(this.grbDatos);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListaArchivos";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de archivos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchivos)).EndInit();
            this.grbArchivos.ResumeLayout(false);
            this.grbDetalles.ResumeLayout(false);
            this.grbDetalles.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbVistaPrevia)).EndInit();
            this.panel1.ResumeLayout(false);
            this.menuClickDerechoImagen.ResumeLayout(false);
            this.menuClickDerechoOpciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArchivos;
        private System.Windows.Forms.GroupBox grbArchivos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox grbDetalles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTamanno;
        private System.Windows.Forms.Label lblFechaCreacion;
        private System.Windows.Forms.Label lblTipoExtension;
        private System.Windows.Forms.Label lblNombreArchivo;
        private System.Windows.Forms.PictureBox ptbVistaPrevia;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ContextMenuStrip menuClickDerechoImagen;
        private System.Windows.Forms.ToolStripMenuItem itmAbrir;
        private System.Windows.Forms.ToolStripMenuItem itmEliminar;
        private System.Windows.Forms.ToolStripMenuItem itmCopiar;
        private System.Windows.Forms.FolderBrowserDialog fbdBuscador;
        private System.Windows.Forms.ContextMenuStrip menuClickDerechoOpciones;
        private System.Windows.Forms.ToolStripMenuItem itmMarcarVarios;
        private System.Windows.Forms.ToolStripMenuItem itmMarcarTodos;
        private System.Windows.Forms.ToolStripMenuItem itmMarcarSeleccionado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmSeleccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRuta;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem itmEliminarMarcados;
        private System.Windows.Forms.ToolStripMenuItem itmEliminarSeleccionado;
        private System.Windows.Forms.ToolStripMenuItem itmCancelarSeleccion;
    }
}