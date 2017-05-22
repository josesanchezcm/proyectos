namespace DemoMantenimiento
{
    partial class ProveedorMan03
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
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.cboDistrito = new System.Windows.Forms.ComboBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtRS = new System.Windows.Forms.TextBox();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.txtRepVen = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.lblRepven = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.cboDistrito);
            this.grpDatos.Controls.Add(this.btnGrabar);
            this.grpDatos.Controls.Add(this.Label1);
            this.grpDatos.Controls.Add(this.txtRS);
            this.grpDatos.Controls.Add(this.txtDir);
            this.grpDatos.Controls.Add(this.txtRepVen);
            this.grpDatos.Controls.Add(this.txtTel);
            this.grpDatos.Controls.Add(this.Label2);
            this.grpDatos.Controls.Add(this.lblRepven);
            this.grpDatos.Controls.Add(this.Label3);
            this.grpDatos.Controls.Add(this.Label4);
            this.grpDatos.Controls.Add(this.btnCancelar);
            this.grpDatos.Location = new System.Drawing.Point(9, 12);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(397, 185);
            this.grpDatos.TabIndex = 8;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos";
           
            // 
            // cboDistrito
            // 
            this.cboDistrito.FormattingEnabled = true;
            this.cboDistrito.Location = new System.Drawing.Point(94, 115);
            this.cboDistrito.Name = "cboDistrito";
            this.cboDistrito.Size = new System.Drawing.Size(162, 21);
            this.cboDistrito.TabIndex = 6;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(303, 108);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(72, 24);
            this.btnGrabar.TabIndex = 4;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(8, 24);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(64, 16);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "R.Social:";
            // 
            // txtRS
            // 
            this.txtRS.Location = new System.Drawing.Point(94, 25);
            this.txtRS.Name = "txtRS";
            this.txtRS.Size = new System.Drawing.Size(192, 20);
            this.txtRS.TabIndex = 0;
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(94, 57);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(192, 20);
            this.txtDir.TabIndex = 0;
            // 
            // txtRepVen
            // 
            this.txtRepVen.Location = new System.Drawing.Point(94, 144);
            this.txtRepVen.Name = "txtRepVen";
            this.txtRepVen.Size = new System.Drawing.Size(192, 20);
            this.txtRepVen.TabIndex = 0;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(94, 89);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(69, 20);
            this.txtTel.TabIndex = 0;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(8, 56);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(64, 16);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Direccion";
            // 
            // lblRepven
            // 
            this.lblRepven.Location = new System.Drawing.Point(8, 146);
            this.lblRepven.Name = "lblRepven";
            this.lblRepven.Size = new System.Drawing.Size(80, 18);
            this.lblRepven.TabIndex = 3;
            this.lblRepven.Text = "Rep. Ventas:";
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(8, 88);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(64, 16);
            this.Label3.TabIndex = 3;
            this.Label3.Text = "Telefono:";
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(8, 120);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(64, 16);
            this.Label4.TabIndex = 3;
            this.Label4.Text = "Distrito:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(303, 140);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(72, 24);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ProveedorMan03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 207);
            this.Controls.Add(this.grpDatos);
            this.Name = "ProveedorMan03";
            this.Text = "Actualizar Proveedor";
            this.Load += new System.EventHandler(this.ProveedorMan03_Load);
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox grpDatos;
        internal System.Windows.Forms.Button btnGrabar;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtRS;
        internal System.Windows.Forms.TextBox txtDir;
        internal System.Windows.Forms.TextBox txtRepVen;
        internal System.Windows.Forms.TextBox txtTel;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label lblRepven;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cboDistrito;
    }
}