namespace GUI
{
    partial class frmHostorialInicioSesion
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
            this.dgvRegistroInicioSesion = new System.Windows.Forms.DataGridView();
            this.clmCodigoEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombreEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTipoEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gruBoxRegistro = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grupBox = new System.Windows.Forms.GroupBox();
            this.tabControlHistorial = new System.Windows.Forms.TabControl();
            this.tPageHistorial = new System.Windows.Forms.TabPage();
            this.tPageDaatos = new System.Windows.Forms.TabPage();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtTipoCargo = new System.Windows.Forms.TextBox();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.txtFechaCreacion = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCodigoEmpleado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroInicioSesion)).BeginInit();
            this.gruBoxRegistro.SuspendLayout();
            this.tabControlHistorial.SuspendLayout();
            this.tPageHistorial.SuspendLayout();
            this.tPageDaatos.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRegistroInicioSesion
            // 
            this.dgvRegistroInicioSesion.AllowUserToDeleteRows = false;
            this.dgvRegistroInicioSesion.AllowUserToOrderColumns = true;
            this.dgvRegistroInicioSesion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistroInicioSesion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodigoEmpleado,
            this.clmNombreEmpleado,
            this.clmTipoEmpleado,
            this.clmHoraInicio});
            this.dgvRegistroInicioSesion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRegistroInicioSesion.Location = new System.Drawing.Point(3, 3);
            this.dgvRegistroInicioSesion.Name = "dgvRegistroInicioSesion";
            this.dgvRegistroInicioSesion.ReadOnly = true;
            this.dgvRegistroInicioSesion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegistroInicioSesion.Size = new System.Drawing.Size(564, 361);
            this.dgvRegistroInicioSesion.TabIndex = 0;
            this.dgvRegistroInicioSesion.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvRegistroInicioSesion_MouseClick);
            // 
            // clmCodigoEmpleado
            // 
            this.clmCodigoEmpleado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmCodigoEmpleado.DataPropertyName = "CodigoEmpleado";
            this.clmCodigoEmpleado.HeaderText = "Código de empleado";
            this.clmCodigoEmpleado.Name = "clmCodigoEmpleado";
            this.clmCodigoEmpleado.ReadOnly = true;
            this.clmCodigoEmpleado.Width = 152;
            // 
            // clmNombreEmpleado
            // 
            this.clmNombreEmpleado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmNombreEmpleado.DataPropertyName = "NombreEmpleado";
            this.clmNombreEmpleado.HeaderText = "Nombre de empleado";
            this.clmNombreEmpleado.Name = "clmNombreEmpleado";
            this.clmNombreEmpleado.ReadOnly = true;
            this.clmNombreEmpleado.Width = 158;
            // 
            // clmTipoEmpleado
            // 
            this.clmTipoEmpleado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmTipoEmpleado.DataPropertyName = "tipoEmpleado";
            this.clmTipoEmpleado.HeaderText = "Tipo de empleado";
            this.clmTipoEmpleado.Name = "clmTipoEmpleado";
            this.clmTipoEmpleado.ReadOnly = true;
            this.clmTipoEmpleado.Width = 135;
            // 
            // clmHoraInicio
            // 
            this.clmHoraInicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmHoraInicio.DataPropertyName = "ID_HoraInicio";
            this.clmHoraInicio.HeaderText = "Fecha/Hora inicio";
            this.clmHoraInicio.Name = "clmHoraInicio";
            this.clmHoraInicio.ReadOnly = true;
            this.clmHoraInicio.Width = 133;
            // 
            // gruBoxRegistro
            // 
            this.gruBoxRegistro.Controls.Add(this.btnSalir);
            this.gruBoxRegistro.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gruBoxRegistro.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gruBoxRegistro.Location = new System.Drawing.Point(0, 397);
            this.gruBoxRegistro.Name = "gruBoxRegistro";
            this.gruBoxRegistro.Size = new System.Drawing.Size(578, 77);
            this.gruBoxRegistro.TabIndex = 1;
            this.gruBoxRegistro.TabStop = false;
            this.gruBoxRegistro.Text = "Regsistros";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(246, 24);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(93, 29);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // grupBox
            // 
            this.grupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.grupBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupBox.Location = new System.Drawing.Point(0, 0);
            this.grupBox.Name = "grupBox";
            this.grupBox.Size = new System.Drawing.Size(144, 526);
            this.grupBox.TabIndex = 2;
            this.grupBox.TabStop = false;
            this.grupBox.Text = "Opciones:";
            // 
            // tabControlHistorial
            // 
            this.tabControlHistorial.Controls.Add(this.tPageHistorial);
            this.tabControlHistorial.Controls.Add(this.tPageDaatos);
            this.tabControlHistorial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlHistorial.Location = new System.Drawing.Point(0, 0);
            this.tabControlHistorial.Name = "tabControlHistorial";
            this.tabControlHistorial.SelectedIndex = 0;
            this.tabControlHistorial.Size = new System.Drawing.Size(578, 397);
            this.tabControlHistorial.TabIndex = 3;
            // 
            // tPageHistorial
            // 
            this.tPageHistorial.BackColor = System.Drawing.Color.Gainsboro;
            this.tPageHistorial.Controls.Add(this.dgvRegistroInicioSesion);
            this.tPageHistorial.Location = new System.Drawing.Point(4, 26);
            this.tPageHistorial.Name = "tPageHistorial";
            this.tPageHistorial.Padding = new System.Windows.Forms.Padding(3);
            this.tPageHistorial.Size = new System.Drawing.Size(570, 367);
            this.tPageHistorial.TabIndex = 0;
            this.tPageHistorial.Text = "Historial";
            // 
            // tPageDaatos
            // 
            this.tPageDaatos.BackColor = System.Drawing.Color.Gainsboro;
            this.tPageDaatos.Controls.Add(this.txtTelefono);
            this.tPageDaatos.Controls.Add(this.txtEdad);
            this.tPageDaatos.Controls.Add(this.txtTipoCargo);
            this.tPageDaatos.Controls.Add(this.txtDepartamento);
            this.tPageDaatos.Controls.Add(this.txtFechaCreacion);
            this.tPageDaatos.Controls.Add(this.txtSalario);
            this.tPageDaatos.Controls.Add(this.txtCelular);
            this.tPageDaatos.Controls.Add(this.txtCedula);
            this.tPageDaatos.Controls.Add(this.txtApellidos);
            this.tPageDaatos.Controls.Add(this.txtNombreEmpleado);
            this.tPageDaatos.Controls.Add(this.label11);
            this.tPageDaatos.Controls.Add(this.label10);
            this.tPageDaatos.Controls.Add(this.label9);
            this.tPageDaatos.Controls.Add(this.label8);
            this.tPageDaatos.Controls.Add(this.label7);
            this.tPageDaatos.Controls.Add(this.label6);
            this.tPageDaatos.Controls.Add(this.label5);
            this.tPageDaatos.Controls.Add(this.label4);
            this.tPageDaatos.Controls.Add(this.label3);
            this.tPageDaatos.Controls.Add(this.label2);
            this.tPageDaatos.Location = new System.Drawing.Point(4, 26);
            this.tPageDaatos.Name = "tPageDaatos";
            this.tPageDaatos.Padding = new System.Windows.Forms.Padding(3);
            this.tPageDaatos.Size = new System.Drawing.Size(570, 367);
            this.tPageDaatos.TabIndex = 1;
            this.tPageDaatos.Text = "Datos";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(172, 106);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ReadOnly = true;
            this.txtTelefono.Size = new System.Drawing.Size(206, 25);
            this.txtTelefono.TabIndex = 3;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(443, 75);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.ReadOnly = true;
            this.txtEdad.Size = new System.Drawing.Size(115, 25);
            this.txtEdad.TabIndex = 7;
            // 
            // txtTipoCargo
            // 
            this.txtTipoCargo.Location = new System.Drawing.Point(443, 44);
            this.txtTipoCargo.Name = "txtTipoCargo";
            this.txtTipoCargo.ReadOnly = true;
            this.txtTipoCargo.Size = new System.Drawing.Size(115, 25);
            this.txtTipoCargo.TabIndex = 6;
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Location = new System.Drawing.Point(443, 13);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.ReadOnly = true;
            this.txtDepartamento.Size = new System.Drawing.Size(115, 25);
            this.txtDepartamento.TabIndex = 6;
            // 
            // txtFechaCreacion
            // 
            this.txtFechaCreacion.Location = new System.Drawing.Point(172, 199);
            this.txtFechaCreacion.Name = "txtFechaCreacion";
            this.txtFechaCreacion.ReadOnly = true;
            this.txtFechaCreacion.Size = new System.Drawing.Size(206, 25);
            this.txtFechaCreacion.TabIndex = 5;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(172, 168);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.ReadOnly = true;
            this.txtSalario.Size = new System.Drawing.Size(206, 25);
            this.txtSalario.TabIndex = 5;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(172, 137);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.ReadOnly = true;
            this.txtCelular.Size = new System.Drawing.Size(206, 25);
            this.txtCelular.TabIndex = 4;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(172, 75);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.ReadOnly = true;
            this.txtCedula.Size = new System.Drawing.Size(151, 25);
            this.txtCedula.TabIndex = 2;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(172, 44);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.ReadOnly = true;
            this.txtApellidos.Size = new System.Drawing.Size(151, 25);
            this.txtApellidos.TabIndex = 1;
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Location = new System.Drawing.Point(172, 13);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.ReadOnly = true;
            this.txtNombreEmpleado.Size = new System.Drawing.Size(151, 25);
            this.txtNombreEmpleado.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "Cédula:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(332, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Edad:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Celular:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(332, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Tipo de cargo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(332, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Departamento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Fecha de creación:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Salario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Apellidos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Telefono:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre de empleado:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControlHistorial);
            this.panel1.Controls.Add(this.gruBoxRegistro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(144, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 474);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtCodigoEmpleado);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(144, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(578, 52);
            this.panel2.TabIndex = 5;
            // 
            // txtCodigoEmpleado
            // 
            this.txtCodigoEmpleado.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoEmpleado.Location = new System.Drawing.Point(70, 16);
            this.txtCodigoEmpleado.Name = "txtCodigoEmpleado";
            this.txtCodigoEmpleado.ReadOnly = true;
            this.txtCodigoEmpleado.Size = new System.Drawing.Size(162, 25);
            this.txtCodigoEmpleado.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // frmHostorialInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 526);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.grupBox);
            this.Name = "frmHostorialInicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial de inicio de sesión";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroInicioSesion)).EndInit();
            this.gruBoxRegistro.ResumeLayout(false);
            this.tabControlHistorial.ResumeLayout(false);
            this.tPageHistorial.ResumeLayout(false);
            this.tPageDaatos.ResumeLayout(false);
            this.tPageDaatos.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRegistroInicioSesion;
        private System.Windows.Forms.GroupBox gruBoxRegistro;
        private System.Windows.Forms.GroupBox grupBox;
        private System.Windows.Forms.TabControl tabControlHistorial;
        private System.Windows.Forms.TabPage tPageHistorial;
        private System.Windows.Forms.TabPage tPageDaatos;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtTipoCargo;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.TextBox txtFechaCreacion;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtCodigoEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigoEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombreEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTipoEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHoraInicio;
    }
}