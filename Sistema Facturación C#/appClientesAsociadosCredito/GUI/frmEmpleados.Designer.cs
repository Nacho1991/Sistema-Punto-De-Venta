namespace GUI
{
    partial class frmEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleados));
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnActualizar = new System.Windows.Forms.ToolStripButton();
            this.btnPlanilla = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.clmNumeroEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCodDepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTipoCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCorreoElectronico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSalarioMensula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmContrasenna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCreadoPor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmModificadoPor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFechaModificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1011, 40);
            this.panel2.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregar,
            this.btnEliminar,
            this.btnActualizar,
            this.btnPlanilla,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1011, 38);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(69, 35);
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(54, 35);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(63, 35);
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnPlanilla
            // 
            this.btnPlanilla.Image = ((System.Drawing.Image)(resources.GetObject("btnPlanilla.Image")));
            this.btnPlanilla.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPlanilla.Name = "btnPlanilla";
            this.btnPlanilla.Size = new System.Drawing.Size(49, 35);
            this.btnPlanilla.Text = "Planilla";
            this.btnPlanilla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPlanilla.Click += new System.EventHandler(this.btnPlanilla_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(41, 35);
            this.toolStripButton1.Text = "Editar";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToOrderColumns = true;
            this.dgvEmpleados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmNumeroEmpleado,
            this.clmCodDepartamento,
            this.clmDepartamento,
            this.clmTipoCargo,
            this.clmCedula,
            this.clmFechaNacimiento,
            this.clmCelular,
            this.clmEdad,
            this.clmNombre,
            this.clmApellidos,
            this.clmCorreoElectronico,
            this.clmTelefono,
            this.clmSexo,
            this.clmSalarioMensula,
            this.clmContrasenna,
            this.clmNombreUsuario,
            this.clmCreadoPor,
            this.clmModificadoPor,
            this.clmFechaModificacion,
            this.clmFechaCreacion});
            this.dgvEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvEmpleados.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvEmpleados.Location = new System.Drawing.Point(0, 40);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleados.Size = new System.Drawing.Size(1011, 258);
            this.dgvEmpleados.TabIndex = 0;
            // 
            // clmNumeroEmpleado
            // 
            this.clmNumeroEmpleado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmNumeroEmpleado.DataPropertyName = "id_NumeroRegistro";
            this.clmNumeroEmpleado.HeaderText = "Número del empleado";
            this.clmNumeroEmpleado.Name = "clmNumeroEmpleado";
            this.clmNumeroEmpleado.ReadOnly = true;
            this.clmNumeroEmpleado.Width = 123;
            // 
            // clmCodDepartamento
            // 
            this.clmCodDepartamento.DataPropertyName = "id_Departamento";
            this.clmCodDepartamento.HeaderText = "Código de departamento";
            this.clmCodDepartamento.Name = "clmCodDepartamento";
            // 
            // clmDepartamento
            // 
            this.clmDepartamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmDepartamento.DataPropertyName = "nombreDepartamento";
            this.clmDepartamento.HeaderText = "Departamento";
            this.clmDepartamento.Name = "clmDepartamento";
            this.clmDepartamento.ReadOnly = true;
            this.clmDepartamento.Width = 99;
            // 
            // clmTipoCargo
            // 
            this.clmTipoCargo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmTipoCargo.DataPropertyName = "tipoCargo";
            this.clmTipoCargo.HeaderText = "Tipo de cargo";
            this.clmTipoCargo.Name = "clmTipoCargo";
            this.clmTipoCargo.ReadOnly = true;
            this.clmTipoCargo.Width = 90;
            // 
            // clmCedula
            // 
            this.clmCedula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmCedula.DataPropertyName = "cedula";
            this.clmCedula.HeaderText = "Cédula";
            this.clmCedula.Name = "clmCedula";
            this.clmCedula.ReadOnly = true;
            this.clmCedula.Width = 65;
            // 
            // clmFechaNacimiento
            // 
            this.clmFechaNacimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmFechaNacimiento.DataPropertyName = "fechaNacimiento";
            this.clmFechaNacimiento.HeaderText = "Fecha nacimiento";
            this.clmFechaNacimiento.Name = "clmFechaNacimiento";
            this.clmFechaNacimiento.ReadOnly = true;
            this.clmFechaNacimiento.Width = 106;
            // 
            // clmCelular
            // 
            this.clmCelular.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmCelular.DataPropertyName = "celular";
            this.clmCelular.HeaderText = "Celular";
            this.clmCelular.Name = "clmCelular";
            this.clmCelular.ReadOnly = true;
            this.clmCelular.Width = 64;
            // 
            // clmEdad
            // 
            this.clmEdad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmEdad.DataPropertyName = "edad";
            this.clmEdad.HeaderText = "Edad";
            this.clmEdad.Name = "clmEdad";
            this.clmEdad.ReadOnly = true;
            this.clmEdad.Width = 57;
            // 
            // clmNombre
            // 
            this.clmNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmNombre.DataPropertyName = "nombre";
            this.clmNombre.HeaderText = "Nombre:";
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.ReadOnly = true;
            this.clmNombre.Width = 72;
            // 
            // clmApellidos
            // 
            this.clmApellidos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmApellidos.DataPropertyName = "apellidos";
            this.clmApellidos.HeaderText = "Apellidos";
            this.clmApellidos.Name = "clmApellidos";
            this.clmApellidos.ReadOnly = true;
            this.clmApellidos.Width = 74;
            // 
            // clmCorreoElectronico
            // 
            this.clmCorreoElectronico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmCorreoElectronico.DataPropertyName = "correoElectronico";
            this.clmCorreoElectronico.HeaderText = "Correo electrónico";
            this.clmCorreoElectronico.Name = "clmCorreoElectronico";
            this.clmCorreoElectronico.ReadOnly = true;
            this.clmCorreoElectronico.Width = 108;
            // 
            // clmTelefono
            // 
            this.clmTelefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmTelefono.DataPropertyName = "telefono";
            this.clmTelefono.HeaderText = "Teléfono";
            this.clmTelefono.Name = "clmTelefono";
            this.clmTelefono.ReadOnly = true;
            this.clmTelefono.Width = 74;
            // 
            // clmSexo
            // 
            this.clmSexo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmSexo.DataPropertyName = "sexo";
            this.clmSexo.HeaderText = "Sexo";
            this.clmSexo.Name = "clmSexo";
            this.clmSexo.ReadOnly = true;
            this.clmSexo.Width = 56;
            // 
            // clmSalarioMensula
            // 
            this.clmSalarioMensula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmSalarioMensula.DataPropertyName = "salarioMensual";
            this.clmSalarioMensula.HeaderText = "Salario Mensual";
            this.clmSalarioMensula.Name = "clmSalarioMensula";
            this.clmSalarioMensula.ReadOnly = true;
            this.clmSalarioMensula.Width = 98;
            // 
            // clmContrasenna
            // 
            this.clmContrasenna.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmContrasenna.DataPropertyName = "contrasenna";
            this.clmContrasenna.HeaderText = "Contraseña";
            this.clmContrasenna.Name = "clmContrasenna";
            this.clmContrasenna.ReadOnly = true;
            this.clmContrasenna.Visible = false;
            // 
            // clmNombreUsuario
            // 
            this.clmNombreUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmNombreUsuario.DataPropertyName = "nombreUsuario";
            this.clmNombreUsuario.HeaderText = "Nombre de usuario";
            this.clmNombreUsuario.Name = "clmNombreUsuario";
            this.clmNombreUsuario.ReadOnly = true;
            this.clmNombreUsuario.Visible = false;
            // 
            // clmCreadoPor
            // 
            this.clmCreadoPor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmCreadoPor.DataPropertyName = "creadoPor";
            this.clmCreadoPor.HeaderText = "Creado por:";
            this.clmCreadoPor.Name = "clmCreadoPor";
            this.clmCreadoPor.ReadOnly = true;
            this.clmCreadoPor.Width = 80;
            // 
            // clmModificadoPor
            // 
            this.clmModificadoPor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmModificadoPor.DataPropertyName = "modificadoPor";
            this.clmModificadoPor.HeaderText = "Modificado por:";
            this.clmModificadoPor.Name = "clmModificadoPor";
            this.clmModificadoPor.ReadOnly = true;
            this.clmModificadoPor.Width = 96;
            // 
            // clmFechaModificacion
            // 
            this.clmFechaModificacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmFechaModificacion.DataPropertyName = "fechaModificacion";
            this.clmFechaModificacion.HeaderText = "Fecha de modificacón";
            this.clmFechaModificacion.Name = "clmFechaModificacion";
            this.clmFechaModificacion.ReadOnly = true;
            this.clmFechaModificacion.Width = 125;
            // 
            // clmFechaCreacion
            // 
            this.clmFechaCreacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmFechaCreacion.DataPropertyName = "fechaCreacion";
            this.clmFechaCreacion.HeaderText = "Fecha de creación";
            this.clmFechaCreacion.Name = "clmFechaCreacion";
            this.clmFechaCreacion.ReadOnly = true;
            this.clmFechaCreacion.Width = 111;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(144, 328);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(119, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(289, 323);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(85, 28);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(144, 354);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(119, 20);
            this.txtSexo.TabIndex = 4;
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1011, 414);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.panel2);
            this.Name = "frmEmpleados";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleados";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton btnActualizar;
        private System.Windows.Forms.ToolStripButton btnPlanilla;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNumeroEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodDepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTipoCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCelular;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCorreoElectronico;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSalarioMensula;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmContrasenna;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCreadoPor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmModificadoPor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFechaModificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFechaCreacion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtSexo;
    }
}