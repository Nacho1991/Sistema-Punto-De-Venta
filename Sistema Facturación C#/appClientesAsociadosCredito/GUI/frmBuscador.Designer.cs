namespace GUI
{
    partial class frmBuscador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscador));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnNombre = new System.Windows.Forms.RadioButton();
            this.rbtnNumCedula = new System.Windows.Forms.RadioButton();
            this.rbtnNumUsuario = new System.Windows.Forms.RadioButton();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumeroBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvResultBusqueda = new System.Windows.Forms.DataGridView();
            this.clmCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrimerApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSegundoApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLimiteCredito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSaldoActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultBusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnNombre);
            this.groupBox1.Controls.Add(this.rbtnNumCedula);
            this.groupBox1.Controls.Add(this.rbtnNumUsuario);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones de busqueda:";
            // 
            // rbtnNombre
            // 
            this.rbtnNombre.AutoSize = true;
            this.rbtnNombre.Location = new System.Drawing.Point(11, 65);
            this.rbtnNombre.Name = "rbtnNombre";
            this.rbtnNombre.Size = new System.Drawing.Size(130, 17);
            this.rbtnNombre.TabIndex = 2;
            this.rbtnNombre.TabStop = true;
            this.rbtnNombre.Text = "Por nombre del cliente";
            this.rbtnNombre.UseVisualStyleBackColor = true;
            this.rbtnNombre.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbtnNumCedula
            // 
            this.rbtnNumCedula.AutoSize = true;
            this.rbtnNumCedula.Location = new System.Drawing.Point(11, 42);
            this.rbtnNumCedula.Name = "rbtnNumCedula";
            this.rbtnNumCedula.Size = new System.Drawing.Size(129, 17);
            this.rbtnNumCedula.TabIndex = 1;
            this.rbtnNumCedula.TabStop = true;
            this.rbtnNumCedula.Text = "Por número de cédula";
            this.rbtnNumCedula.UseVisualStyleBackColor = true;
            this.rbtnNumCedula.CheckedChanged += new System.EventHandler(this.rbtnNumCedula_CheckedChanged);
            // 
            // rbtnNumUsuario
            // 
            this.rbtnNumUsuario.AutoSize = true;
            this.rbtnNumUsuario.Location = new System.Drawing.Point(11, 19);
            this.rbtnNumUsuario.Name = "rbtnNumUsuario";
            this.rbtnNumUsuario.Size = new System.Drawing.Size(130, 17);
            this.rbtnNumUsuario.TabIndex = 0;
            this.rbtnNumUsuario.TabStop = true;
            this.rbtnNumUsuario.Text = "Por número del cliente";
            this.rbtnNumUsuario.UseVisualStyleBackColor = true;
            this.rbtnNumUsuario.CheckedChanged += new System.EventHandler(this.rbtnNumUsuario_CheckedChanged);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(229, 24);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 1;
            this.lblNumero.Text = "Número:";
            // 
            // txtNumeroBuscar
            // 
            this.txtNumeroBuscar.Location = new System.Drawing.Point(315, 44);
            this.txtNumeroBuscar.Name = "txtNumeroBuscar";
            this.txtNumeroBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroBuscar.TabIndex = 2;
            this.txtNumeroBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroBuscar_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(337, 79);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(58, 38);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvResultBusqueda);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(889, 299);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado de busqueda:";
            // 
            // dgvResultBusqueda
            // 
            this.dgvResultBusqueda.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvResultBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvResultBusqueda.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvResultBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultBusqueda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCedula,
            this.clmCodigo,
            this.clmNombre,
            this.clmPrimerApellido,
            this.clmSegundoApellido,
            this.clmDireccion,
            this.clmTelefono,
            this.clmLimiteCredito,
            this.clmSaldoActual});
            this.dgvResultBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResultBusqueda.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvResultBusqueda.Location = new System.Drawing.Point(3, 16);
            this.dgvResultBusqueda.Name = "dgvResultBusqueda";
            this.dgvResultBusqueda.ReadOnly = true;
            this.dgvResultBusqueda.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvResultBusqueda.Size = new System.Drawing.Size(883, 280);
            this.dgvResultBusqueda.TabIndex = 0;
            // 
            // clmCedula
            // 
            this.clmCedula.HeaderText = "Cédula";
            this.clmCedula.Name = "clmCedula";
            this.clmCedula.ReadOnly = true;
            // 
            // clmCodigo
            // 
            this.clmCodigo.HeaderText = "Código";
            this.clmCodigo.Name = "clmCodigo";
            this.clmCodigo.ReadOnly = true;
            // 
            // clmNombre
            // 
            this.clmNombre.HeaderText = "Nombre";
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.ReadOnly = true;
            // 
            // clmPrimerApellido
            // 
            this.clmPrimerApellido.HeaderText = "1er Apellido";
            this.clmPrimerApellido.Name = "clmPrimerApellido";
            this.clmPrimerApellido.ReadOnly = true;
            // 
            // clmSegundoApellido
            // 
            this.clmSegundoApellido.HeaderText = "2do Apellido";
            this.clmSegundoApellido.Name = "clmSegundoApellido";
            this.clmSegundoApellido.ReadOnly = true;
            // 
            // clmDireccion
            // 
            this.clmDireccion.HeaderText = "Dirección";
            this.clmDireccion.Name = "clmDireccion";
            this.clmDireccion.ReadOnly = true;
            // 
            // clmTelefono
            // 
            this.clmTelefono.HeaderText = "Teléfono";
            this.clmTelefono.Name = "clmTelefono";
            this.clmTelefono.ReadOnly = true;
            // 
            // clmLimiteCredito
            // 
            this.clmLimiteCredito.HeaderText = "Límite del credito";
            this.clmLimiteCredito.Name = "clmLimiteCredito";
            this.clmLimiteCredito.ReadOnly = true;
            // 
            // clmSaldoActual
            // 
            this.clmSaldoActual.HeaderText = "Saldo actual";
            this.clmSaldoActual.Name = "clmSaldoActual";
            this.clmSaldoActual.ReadOnly = true;
            // 
            // frmBuscador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(889, 422);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNumeroBuscar);
            this.Controls.Add(this.lblNumero);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmBuscador";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscador de clientes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultBusqueda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnNumCedula;
        private System.Windows.Forms.RadioButton rbtnNumUsuario;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumeroBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvResultBusqueda;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrimerApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSegundoApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLimiteCredito;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSaldoActual;
        private System.Windows.Forms.RadioButton rbtnNombre;
    }
}