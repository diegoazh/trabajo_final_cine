namespace TrabajoFinalCines
{
    partial class frmAppPrincipal
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabVtaEntradas = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.clintesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sociosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peliculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarPelículasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promocionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaPromociónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarPromocionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaReservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarReservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sucursalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNroFactura = new System.Windows.Forms.Label();
            this.lblTituloNumFactura = new System.Windows.Forms.Label();
            this.lblTituloFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblTituloCine = new System.Windows.Forms.Label();
            this.cboNombreCine = new System.Windows.Forms.ComboBox();
            this.lblTituloCliente = new System.Windows.Forms.Label();
            this.cboClientes = new System.Windows.Forms.ComboBox();
            this.lblTituloFormaPago = new System.Windows.Forms.Label();
            this.cboFormaPago = new System.Windows.Forms.ComboBox();
            this.cboPromocion = new System.Windows.Forms.ComboBox();
            this.lblTituloPromocion = new System.Windows.Forms.Label();
            this.cboDescuentos = new System.Windows.Forms.ComboBox();
            this.lblTituloDescuento = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabVtaEntradas.SuspendLayout();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.menuPrincipal, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(986, 640);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.tabControl1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 54);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(980, 506);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabVtaEntradas);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(101, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(778, 500);
            this.tabControl1.TabIndex = 0;
            // 
            // tabVtaEntradas
            // 
            this.tabVtaEntradas.BackColor = System.Drawing.Color.Silver;
            this.tabVtaEntradas.Controls.Add(this.cboDescuentos);
            this.tabVtaEntradas.Controls.Add(this.lblTituloDescuento);
            this.tabVtaEntradas.Controls.Add(this.cboPromocion);
            this.tabVtaEntradas.Controls.Add(this.lblTituloPromocion);
            this.tabVtaEntradas.Controls.Add(this.cboFormaPago);
            this.tabVtaEntradas.Controls.Add(this.lblTituloFormaPago);
            this.tabVtaEntradas.Controls.Add(this.cboClientes);
            this.tabVtaEntradas.Controls.Add(this.lblTituloCliente);
            this.tabVtaEntradas.Controls.Add(this.cboNombreCine);
            this.tabVtaEntradas.Controls.Add(this.lblTituloCine);
            this.tabVtaEntradas.Controls.Add(this.dtpFecha);
            this.tabVtaEntradas.Controls.Add(this.lblTituloFecha);
            this.tabVtaEntradas.Controls.Add(this.lblTituloNumFactura);
            this.tabVtaEntradas.Controls.Add(this.lblNroFactura);
            this.tabVtaEntradas.Location = new System.Drawing.Point(4, 22);
            this.tabVtaEntradas.Name = "tabVtaEntradas";
            this.tabVtaEntradas.Padding = new System.Windows.Forms.Padding(3);
            this.tabVtaEntradas.Size = new System.Drawing.Size(770, 474);
            this.tabVtaEntradas.TabIndex = 0;
            this.tabVtaEntradas.Text = "Venta Entradas";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(770, 474);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clintesToolStripMenuItem,
            this.funcionesToolStripMenuItem,
            this.peliculasToolStripMenuItem,
            this.promocionesToolStripMenuItem,
            this.reservasToolStripMenuItem,
            this.sucursalesToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(986, 24);
            this.menuPrincipal.TabIndex = 1;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // clintesToolStripMenuItem
            // 
            this.clintesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.listarToolStripMenuItem,
            this.sociosToolStripMenuItem});
            this.clintesToolStripMenuItem.Name = "clintesToolStripMenuItem";
            this.clintesToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.clintesToolStripMenuItem.Text = "Clintes";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo Cliente";
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.listarToolStripMenuItem.Text = "Listar Clientes";
            // 
            // sociosToolStripMenuItem
            // 
            this.sociosToolStripMenuItem.Name = "sociosToolStripMenuItem";
            this.sociosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sociosToolStripMenuItem.Text = "Listar Socios";
            // 
            // funcionesToolStripMenuItem
            // 
            this.funcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salasToolStripMenuItem1,
            this.editarToolStripMenuItem});
            this.funcionesToolStripMenuItem.Name = "funcionesToolStripMenuItem";
            this.funcionesToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.funcionesToolStripMenuItem.Text = "Funciones";
            // 
            // salasToolStripMenuItem1
            // 
            this.salasToolStripMenuItem1.Name = "salasToolStripMenuItem1";
            this.salasToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.salasToolStripMenuItem1.Text = "Nueva función";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.editarToolStripMenuItem.Text = "Listar funciones";
            // 
            // peliculasToolStripMenuItem
            // 
            this.peliculasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaToolStripMenuItem,
            this.listarPelículasToolStripMenuItem});
            this.peliculasToolStripMenuItem.Name = "peliculasToolStripMenuItem";
            this.peliculasToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.peliculasToolStripMenuItem.Text = "Peliculas";
            // 
            // nuevaToolStripMenuItem
            // 
            this.nuevaToolStripMenuItem.Name = "nuevaToolStripMenuItem";
            this.nuevaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nuevaToolStripMenuItem.Text = "Nueva película";
            // 
            // listarPelículasToolStripMenuItem
            // 
            this.listarPelículasToolStripMenuItem.Name = "listarPelículasToolStripMenuItem";
            this.listarPelículasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.listarPelículasToolStripMenuItem.Text = "Listar películas";
            // 
            // promocionesToolStripMenuItem
            // 
            this.promocionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaPromociónToolStripMenuItem,
            this.listarPromocionesToolStripMenuItem});
            this.promocionesToolStripMenuItem.Name = "promocionesToolStripMenuItem";
            this.promocionesToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.promocionesToolStripMenuItem.Text = "Promociones";
            // 
            // nuevaPromociónToolStripMenuItem
            // 
            this.nuevaPromociónToolStripMenuItem.Name = "nuevaPromociónToolStripMenuItem";
            this.nuevaPromociónToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.nuevaPromociónToolStripMenuItem.Text = "Nueva promoción";
            // 
            // listarPromocionesToolStripMenuItem
            // 
            this.listarPromocionesToolStripMenuItem.Name = "listarPromocionesToolStripMenuItem";
            this.listarPromocionesToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.listarPromocionesToolStripMenuItem.Text = "Listar promociones";
            // 
            // reservasToolStripMenuItem
            // 
            this.reservasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaReservaToolStripMenuItem,
            this.listarReservasToolStripMenuItem});
            this.reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            this.reservasToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.reservasToolStripMenuItem.Text = "Reservas";
            // 
            // nuevaReservaToolStripMenuItem
            // 
            this.nuevaReservaToolStripMenuItem.Name = "nuevaReservaToolStripMenuItem";
            this.nuevaReservaToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.nuevaReservaToolStripMenuItem.Text = "Nueva reserva";
            // 
            // listarReservasToolStripMenuItem
            // 
            this.listarReservasToolStripMenuItem.Name = "listarReservasToolStripMenuItem";
            this.listarReservasToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.listarReservasToolStripMenuItem.Text = "Listar reservas";
            // 
            // sucursalesToolStripMenuItem
            // 
            this.sucursalesToolStripMenuItem.Name = "sucursalesToolStripMenuItem";
            this.sucursalesToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.sucursalesToolStripMenuItem.Text = "Sucursales";
            // 
            // lblNroFactura
            // 
            this.lblNroFactura.AutoSize = true;
            this.lblNroFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroFactura.ForeColor = System.Drawing.Color.DimGray;
            this.lblNroFactura.Location = new System.Drawing.Point(623, 28);
            this.lblNroFactura.Name = "lblNroFactura";
            this.lblNroFactura.Size = new System.Drawing.Size(140, 24);
            this.lblNroFactura.TabIndex = 0;
            this.lblNroFactura.Text = "0000000000000";
            // 
            // lblTituloNumFactura
            // 
            this.lblTituloNumFactura.AutoSize = true;
            this.lblTituloNumFactura.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloNumFactura.ForeColor = System.Drawing.Color.Black;
            this.lblTituloNumFactura.Location = new System.Drawing.Point(675, 3);
            this.lblTituloNumFactura.Name = "lblTituloNumFactura";
            this.lblTituloNumFactura.Size = new System.Drawing.Size(89, 23);
            this.lblTituloNumFactura.TabIndex = 1;
            this.lblTituloNumFactura.Text = "Nº Factura";
            // 
            // lblTituloFecha
            // 
            this.lblTituloFecha.AutoSize = true;
            this.lblTituloFecha.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFecha.ForeColor = System.Drawing.Color.Black;
            this.lblTituloFecha.Location = new System.Drawing.Point(6, 3);
            this.lblTituloFecha.Name = "lblTituloFecha";
            this.lblTituloFecha.Size = new System.Drawing.Size(57, 23);
            this.lblTituloFecha.TabIndex = 2;
            this.lblTituloFecha.Text = "Fecha";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(11, 32);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 3;
            // 
            // lblTituloCine
            // 
            this.lblTituloCine.AutoSize = true;
            this.lblTituloCine.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCine.ForeColor = System.Drawing.Color.Black;
            this.lblTituloCine.Location = new System.Drawing.Point(392, 3);
            this.lblTituloCine.Name = "lblTituloCine";
            this.lblTituloCine.Size = new System.Drawing.Size(50, 23);
            this.lblTituloCine.TabIndex = 4;
            this.lblTituloCine.Text = "Cine:";
            // 
            // cboNombreCine
            // 
            this.cboNombreCine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNombreCine.FormattingEnabled = true;
            this.cboNombreCine.Location = new System.Drawing.Point(329, 33);
            this.cboNombreCine.Name = "cboNombreCine";
            this.cboNombreCine.Size = new System.Drawing.Size(176, 21);
            this.cboNombreCine.TabIndex = 5;
            // 
            // lblTituloCliente
            // 
            this.lblTituloCliente.AutoSize = true;
            this.lblTituloCliente.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCliente.ForeColor = System.Drawing.Color.Black;
            this.lblTituloCliente.Location = new System.Drawing.Point(6, 70);
            this.lblTituloCliente.Name = "lblTituloCliente";
            this.lblTituloCliente.Size = new System.Drawing.Size(67, 23);
            this.lblTituloCliente.TabIndex = 6;
            this.lblTituloCliente.Text = "Cliente";
            // 
            // cboClientes
            // 
            this.cboClientes.FormattingEnabled = true;
            this.cboClientes.Location = new System.Drawing.Point(6, 96);
            this.cboClientes.Name = "cboClientes";
            this.cboClientes.Size = new System.Drawing.Size(205, 21);
            this.cboClientes.TabIndex = 7;
            // 
            // lblTituloFormaPago
            // 
            this.lblTituloFormaPago.AutoSize = true;
            this.lblTituloFormaPago.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFormaPago.ForeColor = System.Drawing.Color.Black;
            this.lblTituloFormaPago.Location = new System.Drawing.Point(148, 143);
            this.lblTituloFormaPago.Name = "lblTituloFormaPago";
            this.lblTituloFormaPago.Size = new System.Drawing.Size(130, 23);
            this.lblTituloFormaPago.TabIndex = 8;
            this.lblTituloFormaPago.Text = "Forma de Pago:";
            // 
            // cboFormaPago
            // 
            this.cboFormaPago.FormattingEnabled = true;
            this.cboFormaPago.Location = new System.Drawing.Point(148, 169);
            this.cboFormaPago.Name = "cboFormaPago";
            this.cboFormaPago.Size = new System.Drawing.Size(137, 21);
            this.cboFormaPago.TabIndex = 9;
            // 
            // cboPromocion
            // 
            this.cboPromocion.FormattingEnabled = true;
            this.cboPromocion.Location = new System.Drawing.Point(334, 169);
            this.cboPromocion.Name = "cboPromocion";
            this.cboPromocion.Size = new System.Drawing.Size(137, 21);
            this.cboPromocion.TabIndex = 11;
            // 
            // lblTituloPromocion
            // 
            this.lblTituloPromocion.AutoSize = true;
            this.lblTituloPromocion.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPromocion.ForeColor = System.Drawing.Color.Black;
            this.lblTituloPromocion.Location = new System.Drawing.Point(334, 143);
            this.lblTituloPromocion.Name = "lblTituloPromocion";
            this.lblTituloPromocion.Size = new System.Drawing.Size(100, 23);
            this.lblTituloPromocion.TabIndex = 10;
            this.lblTituloPromocion.Text = "Promocion:";
            // 
            // cboDescuentos
            // 
            this.cboDescuentos.FormattingEnabled = true;
            this.cboDescuentos.Location = new System.Drawing.Point(520, 169);
            this.cboDescuentos.Name = "cboDescuentos";
            this.cboDescuentos.Size = new System.Drawing.Size(137, 21);
            this.cboDescuentos.TabIndex = 13;
            // 
            // lblTituloDescuento
            // 
            this.lblTituloDescuento.AutoSize = true;
            this.lblTituloDescuento.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDescuento.ForeColor = System.Drawing.Color.Black;
            this.lblTituloDescuento.Location = new System.Drawing.Point(520, 143);
            this.lblTituloDescuento.Name = "lblTituloDescuento";
            this.lblTituloDescuento.Size = new System.Drawing.Size(198, 23);
            this.lblTituloDescuento.TabIndex = 12;
            this.lblTituloDescuento.Text = "Descuentos especiales:";
            // 
            // frmAppPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 640);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "frmAppPrincipal";
            this.Text = "AppPrincipal";
            this.Load += new System.EventHandler(this.frmAppPrincipal_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabVtaEntradas.ResumeLayout(false);
            this.tabVtaEntradas.PerformLayout();
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem clintesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sociosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peliculasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promocionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sucursalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarPelículasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaPromociónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarPromocionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaReservaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarReservasToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabVtaEntradas;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cboClientes;
        private System.Windows.Forms.Label lblTituloCliente;
        private System.Windows.Forms.ComboBox cboNombreCine;
        private System.Windows.Forms.Label lblTituloCine;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblTituloFecha;
        private System.Windows.Forms.Label lblTituloNumFactura;
        private System.Windows.Forms.Label lblNroFactura;
        private System.Windows.Forms.ComboBox cboDescuentos;
        private System.Windows.Forms.Label lblTituloDescuento;
        private System.Windows.Forms.ComboBox cboPromocion;
        private System.Windows.Forms.Label lblTituloPromocion;
        private System.Windows.Forms.ComboBox cboFormaPago;
        private System.Windows.Forms.Label lblTituloFormaPago;
    }
}