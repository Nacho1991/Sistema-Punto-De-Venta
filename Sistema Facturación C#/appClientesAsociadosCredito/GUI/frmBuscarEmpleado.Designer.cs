namespace GUI
{
    partial class frmBuscarEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarEmpleado));
            this.grbRegistros = new System.Windows.Forms.GroupBox();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.clmCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmContrasenna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFechaModificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCreadoPor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmModificadoPor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFiltroEmpleado = new System.Windows.Forms.TextBox();
            this.lblBuscarEmpleado = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbOpcionesBusqueda = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbRegistros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbRegistros
            // 
            this.grbRegistros.Controls.Add(this.dgvEmpleados);
            this.grbRegistros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbRegistros.Location = new System.Drawing.Point(148, 73);
            this.grbRegistros.Name = "grbRegistros";
            this.grbRegistros.Size = new System.Drawing.Size(590, 305);
            this.grbRegistros.TabIndex = 1;
            this.grbRegistros.TabStop = false;
            this.grbRegistros.Text = "Productos";
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCedula,
            this.clmNombre,
            this.clmApellidos,
            this.clmFechaNacimiento,
            this.clmTelefono,
            this.clmCelular,
            this.clmEdad,
            this.clmSexo,
            this.clmNombreUsuario,
            this.clmContrasenna,
            this.clmEmail,
            this.clmFechaCreacion,
            this.clmFechaModificacion,
            this.clmCreadoPor,
            this.clmModificadoPor,
            this.clmDepartamento});
            this.dgvEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmpleados.Location = new System.Drawing.Point(3, 17);
            this.dgvEmpleados.MultiSelect = false;
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleados.Size = new System.Drawing.Size(584, 285);
            this.dgvEmpleados.TabIndex = 0;
            // 
            // clmCedula
            // 
            this.clmCedula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmCedula.DataPropertyName = "Id_Cedula";
            this.clmCedula.HeaderText = "Cédula";
            this.clmCedula.Name = "clmCedula";
            this.clmCedula.ReadOnly = true;
            this.clmCedula.Width = 71;
            // 
            // clmNombre
            // 
            this.clmNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmNombre.DataPropertyName = "Nombre";
            this.clmNombre.HeaderText = "Nombre";
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.ReadOnly = true;
            this.clmNombre.Width = 77;
            // 
            // clmApellidos
            // 
            this.clmApellidos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmApellidos.DataPropertyName = "Apellidos";
            this.clmApellidos.HeaderText = "Apellidos";
            this.clmApellidos.Name = "clmApellidos";
            this.clmApellidos.ReadOnly = true;
            this.clmApellidos.Width = 82;
            // 
            // clmFechaNacimiento
            // 
            this.clmFechaNacimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmFechaNacimiento.DataPropertyName = "fecha_nacimiento";
            this.clmFechaNacimiento.HeaderText = "Fecha de nacimiento";
            this.clmFechaNacimiento.Name = "clmFechaNacimiento";
            this.clmFechaNacimiento.ReadOnly = true;
            this.clmFechaNacimiento.Visible = false;
            this.clmFechaNacimiento.Width = 131;
            // 
            // clmTelefono
            // 
            this.clmTelefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmTelefono.DataPropertyName = "telefono";
            this.clmTelefono.HeaderText = "Teléfono";
            this.clmTelefono.Name = "clmTelefono";
            this.clmTelefono.ReadOnly = true;
            this.clmTelefono.Width = 80;
            // 
            // clmCelular
            // 
            this.clmCelular.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmCelular.DataPropertyName = "celular";
            this.clmCelular.HeaderText = "Celular";
            this.clmCelular.Name = "clmCelular";
            this.clmCelular.ReadOnly = true;
            this.clmCelular.Width = 71;
            // 
            // clmEdad
            // 
            this.clmEdad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmEdad.DataPropertyName = "edad";
            this.clmEdad.HeaderText = "Edad";
            this.clmEdad.Name = "clmEdad";
            this.clmEdad.ReadOnly = true;
            this.clmEdad.Visible = false;
            this.clmEdad.Width = 57;
            // 
            // clmSexo
            // 
            this.clmSexo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmSexo.DataPropertyName = "sexo";
            this.clmSexo.HeaderText = "Sexo";
            this.clmSexo.Name = "clmSexo";
            this.clmSexo.ReadOnly = true;
            this.clmSexo.Visible = false;
            this.clmSexo.Width = 56;
            // 
            // clmNombreUsuario
            // 
            this.clmNombreUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmNombreUsuario.DataPropertyName = "nombre_usuario";
            this.clmNombreUsuario.HeaderText = "Nombre de usuario";
            this.clmNombreUsuario.Name = "clmNombreUsuario";
            this.clmNombreUsuario.ReadOnly = true;
            this.clmNombreUsuario.Visible = false;
            this.clmNombreUsuario.Width = 121;
            // 
            // clmContrasenna
            // 
            this.clmContrasenna.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmContrasenna.DataPropertyName = "contrasenna";
            this.clmContrasenna.HeaderText = "Contraseña";
            this.clmContrasenna.Name = "clmContrasenna";
            this.clmContrasenna.ReadOnly = true;
            this.clmContrasenna.Visible = false;
            this.clmContrasenna.Width = 86;
            // 
            // clmEmail
            // 
            this.clmEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmEmail.DataPropertyName = "email";
            this.clmEmail.HeaderText = "Correo electronico";
            this.clmEmail.Name = "clmEmail";
            this.clmEmail.ReadOnly = true;
            this.clmEmail.Visible = false;
            this.clmEmail.Width = 118;
            // 
            // clmFechaCreacion
            // 
            this.clmFechaCreacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmFechaCreacion.DataPropertyName = "fecha_creacion";
            this.clmFechaCreacion.HeaderText = "Fecha de creación";
            this.clmFechaCreacion.Name = "clmFechaCreacion";
            this.clmFechaCreacion.ReadOnly = true;
            this.clmFechaCreacion.Visible = false;
            this.clmFechaCreacion.Width = 121;
            // 
            // clmFechaModificacion
            // 
            this.clmFechaModificacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmFechaModificacion.DataPropertyName = "fecha_modificacion";
            this.clmFechaModificacion.HeaderText = "Fecha de modificación";
            this.clmFechaModificacion.Name = "clmFechaModificacion";
            this.clmFechaModificacion.ReadOnly = true;
            this.clmFechaModificacion.Visible = false;
            this.clmFechaModificacion.Width = 139;
            // 
            // clmCreadoPor
            // 
            this.clmCreadoPor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmCreadoPor.DataPropertyName = "creado_Por";
            this.clmCreadoPor.HeaderText = "Creado por";
            this.clmCreadoPor.Name = "clmCreadoPor";
            this.clmCreadoPor.ReadOnly = true;
            this.clmCreadoPor.Visible = false;
            this.clmCreadoPor.Width = 84;
            // 
            // clmModificadoPor
            // 
            this.clmModificadoPor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmModificadoPor.DataPropertyName = "modificado_por";
            this.clmModificadoPor.HeaderText = "Modificado por";
            this.clmModificadoPor.Name = "clmModificadoPor";
            this.clmModificadoPor.ReadOnly = true;
            this.clmModificadoPor.Visible = false;
            this.clmModificadoPor.Width = 102;
            // 
            // clmDepartamento
            // 
            this.clmDepartamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmDepartamento.DataPropertyName = "Deártamento_Id_Departamento";
            this.clmDepartamento.HeaderText = "Departamento";
            this.clmDepartamento.Name = "clmDepartamento";
            this.clmDepartamento.ReadOnly = true;
            this.clmDepartamento.Width = 111;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbOpcionesBusqueda);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.txtFiltroEmpleado);
            this.panel1.Controls.Add(this.lblBuscarEmpleado);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(148, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 73);
            this.panel1.TabIndex = 2;
            // 
            // txtFiltroEmpleado
            // 
            this.txtFiltroEmpleado.Location = new System.Drawing.Point(27, 36);
            this.txtFiltroEmpleado.Name = "txtFiltroEmpleado";
            this.txtFiltroEmpleado.Size = new System.Drawing.Size(224, 21);
            this.txtFiltroEmpleado.TabIndex = 8;
            this.txtFiltroEmpleado.TextChanged += new System.EventHandler(this.txtFiltroEmpleado_TextChanged);
            // 
            // lblBuscarEmpleado
            // 
            this.lblBuscarEmpleado.AutoSize = true;
            this.lblBuscarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBuscarEmpleado.Location = new System.Drawing.Point(24, 18);
            this.lblBuscarEmpleado.Name = "lblBuscarEmpleado";
            this.lblBuscarEmpleado.Size = new System.Drawing.Size(143, 15);
            this.lblBuscarEmpleado.TabIndex = 7;
            this.lblBuscarEmpleado.Text = "Ingrese el texto a buscar:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(496, 18);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(46, 38);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(148, 378);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 378);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(738, 47);
            this.panel3.TabIndex = 4;
            // 
            // cmbOpcionesBusqueda
            // 
            this.cmbOpcionesBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOpcionesBusqueda.FormattingEnabled = true;
            this.cmbOpcionesBusqueda.Items.AddRange(new object[] {
            "Cédula",
            "Nombre",
            "Correo electrónico"});
            this.cmbOpcionesBusqueda.Location = new System.Drawing.Point(273, 36);
            this.cmbOpcionesBusqueda.Name = "cmbOpcionesBusqueda";
            this.cmbOpcionesBusqueda.Size = new System.Drawing.Size(196, 23);
            this.cmbOpcionesBusqueda.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Opciones de búsqueda:";
            // 
            // frmBuscarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(738, 425);
            this.Controls.Add(this.grbRegistros);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuscarEmpleado";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar empleado";
            this.grbRegistros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbRegistros;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtFiltroEmpleado;
        private System.Windows.Forms.Label lblBuscarEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCelular;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmContrasenna;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFechaModificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCreadoPor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmModificadoPor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDepartamento;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOpcionesBusqueda;
    }
}