namespace GUI
{
    partial class frmSeleccionBaseDatos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlDetalles = new System.Windows.Forms.GroupBox();
            this.lnkOpcionesAvanzadas = new System.Windows.Forms.LinkLabel();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.pnlSoftValue = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblMySql = new System.Windows.Forms.Label();
            this.pnlDetalles.SuspendLayout();
            this.pnlSoftValue.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Base de Datos establecida:";
            // 
            // pnlDetalles
            // 
            this.pnlDetalles.Controls.Add(this.lblMySql);
            this.pnlDetalles.Controls.Add(this.lnkOpcionesAvanzadas);
            this.pnlDetalles.Controls.Add(this.label2);
            this.pnlDetalles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetalles.Location = new System.Drawing.Point(0, 0);
            this.pnlDetalles.Name = "pnlDetalles";
            this.pnlDetalles.Size = new System.Drawing.Size(415, 90);
            this.pnlDetalles.TabIndex = 2;
            this.pnlDetalles.TabStop = false;
            this.pnlDetalles.Text = "Detalles";
            // 
            // lnkOpcionesAvanzadas
            // 
            this.lnkOpcionesAvanzadas.AutoSize = true;
            this.lnkOpcionesAvanzadas.Location = new System.Drawing.Point(288, 66);
            this.lnkOpcionesAvanzadas.Name = "lnkOpcionesAvanzadas";
            this.lnkOpcionesAvanzadas.Size = new System.Drawing.Size(121, 15);
            this.lnkOpcionesAvanzadas.TabIndex = 3;
            this.lnkOpcionesAvanzadas.TabStop = true;
            this.lnkOpcionesAvanzadas.Text = "Opciones avanzadas";
            this.lnkOpcionesAvanzadas.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkOpcionesAvanzadas_LinkClicked);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSeleccionar.Location = new System.Drawing.Point(97, 29);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(87, 27);
            this.btnSeleccionar.TabIndex = 0;
            this.btnSeleccionar.Text = "Iniciar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // pnlSoftValue
            // 
            this.pnlSoftValue.Controls.Add(this.btnSalir);
            this.pnlSoftValue.Controls.Add(this.btnSeleccionar);
            this.pnlSoftValue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSoftValue.Location = new System.Drawing.Point(0, 90);
            this.pnlSoftValue.Name = "pnlSoftValue";
            this.pnlSoftValue.Size = new System.Drawing.Size(415, 68);
            this.pnlSoftValue.TabIndex = 3;
            this.pnlSoftValue.TabStop = false;
            this.pnlSoftValue.Text = "SoftValue";
            // 
            // btnSalir
            // 
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSalir.Location = new System.Drawing.Point(239, 29);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(87, 27);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblMySql
            // 
            this.lblMySql.AutoSize = true;
            this.lblMySql.Location = new System.Drawing.Point(195, 43);
            this.lblMySql.Name = "lblMySql";
            this.lblMySql.Size = new System.Drawing.Size(47, 15);
            this.lblMySql.TabIndex = 4;
            this.lblMySql.Text = "MySQL";
            // 
            // frmSeleccionBaseDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(415, 158);
            this.Controls.Add(this.pnlDetalles);
            this.Controls.Add(this.pnlSoftValue);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSeleccionBaseDatos";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bases de Datos";
            this.pnlDetalles.ResumeLayout(false);
            this.pnlDetalles.PerformLayout();
            this.pnlSoftValue.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox pnlDetalles;
        private System.Windows.Forms.GroupBox pnlSoftValue;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.LinkLabel lnkOpcionesAvanzadas;
        private System.Windows.Forms.Label lblMySql;
    }
}