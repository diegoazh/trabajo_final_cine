namespace TrabajoFinalCines
{
    partial class frmRecXGenero
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
            this.lblRecGenero = new System.Windows.Forms.Label();
            this.txtRecGenero = new System.Windows.Forms.TextBox();
            this.txtRecMeses = new System.Windows.Forms.TextBox();
            this.lblRecMeses = new System.Windows.Forms.Label();
            this.lblRecAviso = new System.Windows.Forms.Label();
            this.btnRecCons1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRecGenero
            // 
            this.lblRecGenero.AutoSize = true;
            this.lblRecGenero.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecGenero.Location = new System.Drawing.Point(30, 23);
            this.lblRecGenero.Name = "lblRecGenero";
            this.lblRecGenero.Size = new System.Drawing.Size(56, 20);
            this.lblRecGenero.TabIndex = 0;
            this.lblRecGenero.Text = "Genero";
            // 
            // txtRecGenero
            // 
            this.txtRecGenero.Location = new System.Drawing.Point(112, 23);
            this.txtRecGenero.Name = "txtRecGenero";
            this.txtRecGenero.Size = new System.Drawing.Size(100, 20);
            this.txtRecGenero.TabIndex = 1;
            this.txtRecGenero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRecGenero_KeyPress);
            // 
            // txtRecMeses
            // 
            this.txtRecMeses.Location = new System.Drawing.Point(112, 59);
            this.txtRecMeses.Name = "txtRecMeses";
            this.txtRecMeses.Size = new System.Drawing.Size(100, 20);
            this.txtRecMeses.TabIndex = 3;
            this.txtRecMeses.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRecMeses_KeyPress);
            // 
            // lblRecMeses
            // 
            this.lblRecMeses.AutoSize = true;
            this.lblRecMeses.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecMeses.Location = new System.Drawing.Point(30, 59);
            this.lblRecMeses.Name = "lblRecMeses";
            this.lblRecMeses.Size = new System.Drawing.Size(52, 20);
            this.lblRecMeses.TabIndex = 2;
            this.lblRecMeses.Text = "Meses";
            // 
            // lblRecAviso
            // 
            this.lblRecAviso.AutoSize = true;
            this.lblRecAviso.Location = new System.Drawing.Point(30, 82);
            this.lblRecAviso.Name = "lblRecAviso";
            this.lblRecAviso.Size = new System.Drawing.Size(207, 13);
            this.lblRecAviso.TabIndex = 4;
            this.lblRecAviso.Text = "*Ingrese la cantidad de meses hacia atras.";
            // 
            // btnRecCons1
            // 
            this.btnRecCons1.Location = new System.Drawing.Point(34, 119);
            this.btnRecCons1.Name = "btnRecCons1";
            this.btnRecCons1.Size = new System.Drawing.Size(158, 36);
            this.btnRecCons1.TabIndex = 5;
            this.btnRecCons1.Text = "Consultar";
            this.btnRecCons1.UseVisualStyleBackColor = true;
            this.btnRecCons1.Click += new System.EventHandler(this.btnRecCons1_Click);
            // 
            // frmRecXGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 188);
            this.Controls.Add(this.btnRecCons1);
            this.Controls.Add(this.lblRecAviso);
            this.Controls.Add(this.txtRecMeses);
            this.Controls.Add(this.lblRecMeses);
            this.Controls.Add(this.txtRecGenero);
            this.Controls.Add(this.lblRecGenero);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRecXGenero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recaudación por Genero";
            this.Load += new System.EventHandler(this.frmRecXGenero_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecGenero;
        private System.Windows.Forms.TextBox txtRecGenero;
        private System.Windows.Forms.TextBox txtRecMeses;
        private System.Windows.Forms.Label lblRecMeses;
        private System.Windows.Forms.Label lblRecAviso;
        private System.Windows.Forms.Button btnRecCons1;
    }
}