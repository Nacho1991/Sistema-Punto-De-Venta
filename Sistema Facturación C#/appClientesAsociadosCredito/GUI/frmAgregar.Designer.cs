namespace GUI
{
    partial class frmAgregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregar));
            this.grbProductoAgregar = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbProductoAgregar.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbProductoAgregar
            // 
            this.grbProductoAgregar.Controls.Add(this.label1);
            this.grbProductoAgregar.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbProductoAgregar.Location = new System.Drawing.Point(0, 0);
            this.grbProductoAgregar.Name = "grbProductoAgregar";
            this.grbProductoAgregar.Size = new System.Drawing.Size(503, 127);
            this.grbProductoAgregar.TabIndex = 0;
            this.grbProductoAgregar.TabStop = false;
            this.grbProductoAgregar.Text = "Productos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del producto:";
            // 
            // frmAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 319);
            this.Controls.Add(this.grbProductoAgregar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAgregar";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Agregar producto";
            this.grbProductoAgregar.ResumeLayout(false);
            this.grbProductoAgregar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbProductoAgregar;
        private System.Windows.Forms.Label label1;
    }
}