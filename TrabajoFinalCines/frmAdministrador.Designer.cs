namespace TrabajoFinalCines
{
    partial class frmAdministrador
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
            this.dtgvContenidoTablas = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAdminCampos = new System.Windows.Forms.Label();
            this.chkLbCampos = new System.Windows.Forms.CheckedListBox();
            this.lblAdminTablas = new System.Windows.Forms.Label();
            this.cboTablas = new System.Windows.Forms.ComboBox();
            this.btnAdminConsultar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvContenidoTablas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.dtgvContenidoTablas, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1644, 793);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dtgvContenidoTablas
            // 
            this.dtgvContenidoTablas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvContenidoTablas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvContenidoTablas.Location = new System.Drawing.Point(3, 63);
            this.dtgvContenidoTablas.Name = "dtgvContenidoTablas";
            this.dtgvContenidoTablas.Size = new System.Drawing.Size(1227, 433);
            this.dtgvContenidoTablas.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdminConsultar);
            this.panel1.Controls.Add(this.lblAdminCampos);
            this.panel1.Controls.Add(this.chkLbCampos);
            this.panel1.Controls.Add(this.lblAdminTablas);
            this.panel1.Controls.Add(this.cboTablas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1236, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 433);
            this.panel1.TabIndex = 1;
            // 
            // lblAdminCampos
            // 
            this.lblAdminCampos.AutoSize = true;
            this.lblAdminCampos.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminCampos.Location = new System.Drawing.Point(16, 48);
            this.lblAdminCampos.Name = "lblAdminCampos";
            this.lblAdminCampos.Size = new System.Drawing.Size(65, 20);
            this.lblAdminCampos.TabIndex = 3;
            this.lblAdminCampos.Text = "Campos:";
            // 
            // chkLbCampos
            // 
            this.chkLbCampos.FormattingEnabled = true;
            this.chkLbCampos.Location = new System.Drawing.Point(85, 48);
            this.chkLbCampos.Name = "chkLbCampos";
            this.chkLbCampos.Size = new System.Drawing.Size(148, 154);
            this.chkLbCampos.TabIndex = 2;
            // 
            // lblAdminTablas
            // 
            this.lblAdminTablas.AutoSize = true;
            this.lblAdminTablas.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminTablas.Location = new System.Drawing.Point(16, 22);
            this.lblAdminTablas.Name = "lblAdminTablas";
            this.lblAdminTablas.Size = new System.Drawing.Size(54, 20);
            this.lblAdminTablas.TabIndex = 1;
            this.lblAdminTablas.Text = "Tablas:";
            // 
            // cboTablas
            // 
            this.cboTablas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTablas.FormattingEnabled = true;
            this.cboTablas.Location = new System.Drawing.Point(85, 21);
            this.cboTablas.Name = "cboTablas";
            this.cboTablas.Size = new System.Drawing.Size(148, 21);
            this.cboTablas.TabIndex = 0;
            this.cboTablas.SelectedIndexChanged += new System.EventHandler(this.cboTablas_SelectedIndexChanged);
            // 
            // btnAdminConsultar
            // 
            this.btnAdminConsultar.Location = new System.Drawing.Point(85, 389);
            this.btnAdminConsultar.Name = "btnAdminConsultar";
            this.btnAdminConsultar.Size = new System.Drawing.Size(148, 41);
            this.btnAdminConsultar.TabIndex = 4;
            this.btnAdminConsultar.Text = "Consultar";
            this.btnAdminConsultar.UseVisualStyleBackColor = true;
            this.btnAdminConsultar.Click += new System.EventHandler(this.btnAdminConsultar_Click);
            // 
            // frmAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1644, 793);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmAdministrador";
            this.Text = "Administrador";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAdministrador_FormClosing);
            this.Load += new System.EventHandler(this.frmAdministrador_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvContenidoTablas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dtgvContenidoTablas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAdminTablas;
        private System.Windows.Forms.ComboBox cboTablas;
        private System.Windows.Forms.CheckedListBox chkLbCampos;
        private System.Windows.Forms.Label lblAdminCampos;
        private System.Windows.Forms.Button btnAdminConsultar;
    }
}