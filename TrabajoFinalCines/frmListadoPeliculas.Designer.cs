namespace TrabajoFinalCines
{
    partial class frmListadoPeliculas
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cvReportePelicula = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.cvReportePelicula, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(901, 497);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cvReportePelicula
            // 
            this.cvReportePelicula.ActiveViewIndex = -1;
            this.cvReportePelicula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cvReportePelicula.Cursor = System.Windows.Forms.Cursors.Default;
            this.cvReportePelicula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cvReportePelicula.Location = new System.Drawing.Point(3, 3);
            this.cvReportePelicula.Name = "cvReportePelicula";
            this.cvReportePelicula.Size = new System.Drawing.Size(895, 416);
            this.cvReportePelicula.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGenerarReporte);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 425);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 69);
            this.panel1.TabIndex = 1;
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Location = new System.Drawing.Point(9, 24);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(116, 36);
            this.btnGenerarReporte.TabIndex = 0;
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            // 
            // frmListadoPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 497);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmListadoPeliculas";
            this.Text = "frmListadoPeliculas";
            this.Load += new System.EventHandler(this.frmListadoPeliculas_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer cvReportePelicula;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGenerarReporte;
    }
}