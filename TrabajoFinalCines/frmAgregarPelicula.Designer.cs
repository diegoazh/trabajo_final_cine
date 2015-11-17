namespace TrabajoFinalCines
{
    partial class FrmAgregarPelicula
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
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescrip = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.cboxGenero = new System.Windows.Forms.ComboBox();
            this.lblCalifica = new System.Windows.Forms.Label();
            this.cboxCalificacion = new System.Windows.Forms.ComboBox();
            this.lstPeliculas = new System.Windows.Forms.ListBox();
            this.chkEstreno = new System.Windows.Forms.CheckBox();
            this.lblEstreno = new System.Windows.Forms.Label();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.lblAviso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(11, 247);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(80, 50);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nueva Película";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(97, 247);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(80, 50);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar Película";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(183, 247);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 50);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(269, 247);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(80, 50);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(355, 247);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(80, 50);
            this.btnBorrar.TabIndex = 5;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(441, 247);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(80, 50);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(106, 17);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(149, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(14, 21);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 14;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDescrip
            // 
            this.lblDescrip.AutoSize = true;
            this.lblDescrip.Location = new System.Drawing.Point(14, 59);
            this.lblDescrip.Name = "lblDescrip";
            this.lblDescrip.Size = new System.Drawing.Size(63, 13);
            this.lblDescrip.TabIndex = 15;
            this.lblDescrip.Text = "Descripción";
            this.lblDescrip.Click += new System.EventHandler(this.lblDescrip_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(106, 54);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(149, 20);
            this.txtDescripcion.TabIndex = 8;
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Location = new System.Drawing.Point(14, 97);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(50, 13);
            this.lblDuracion.TabIndex = 16;
            this.lblDuracion.Text = "Duración";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(14, 146);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(42, 13);
            this.lblGenero.TabIndex = 17;
            this.lblGenero.Text = "Género";
            // 
            // cboxGenero
            // 
            this.cboxGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxGenero.FormattingEnabled = true;
            this.cboxGenero.Location = new System.Drawing.Point(106, 139);
            this.cboxGenero.Name = "cboxGenero";
            this.cboxGenero.Size = new System.Drawing.Size(149, 21);
            this.cboxGenero.TabIndex = 11;
            // 
            // lblCalifica
            // 
            this.lblCalifica.AutoSize = true;
            this.lblCalifica.Location = new System.Drawing.Point(14, 182);
            this.lblCalifica.Name = "lblCalifica";
            this.lblCalifica.Size = new System.Drawing.Size(61, 13);
            this.lblCalifica.TabIndex = 18;
            this.lblCalifica.Text = "Calificación";
            // 
            // cboxCalificacion
            // 
            this.cboxCalificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCalificacion.FormattingEnabled = true;
            this.cboxCalificacion.Location = new System.Drawing.Point(106, 175);
            this.cboxCalificacion.Name = "cboxCalificacion";
            this.cboxCalificacion.Size = new System.Drawing.Size(149, 21);
            this.cboxCalificacion.TabIndex = 12;
            // 
            // lstPeliculas
            // 
            this.lstPeliculas.FormattingEnabled = true;
            this.lstPeliculas.Location = new System.Drawing.Point(283, 12);
            this.lstPeliculas.Name = "lstPeliculas";
            this.lstPeliculas.Size = new System.Drawing.Size(238, 212);
            this.lstPeliculas.TabIndex = 1;
            this.lstPeliculas.SelectedIndexChanged += new System.EventHandler(this.lstPeliculas_SelectedIndexChanged);
            // 
            // chkEstreno
            // 
            this.chkEstreno.AutoSize = true;
            this.chkEstreno.Location = new System.Drawing.Point(106, 206);
            this.chkEstreno.Name = "chkEstreno";
            this.chkEstreno.Size = new System.Drawing.Size(35, 17);
            this.chkEstreno.TabIndex = 13;
            this.chkEstreno.Text = "Si";
            this.chkEstreno.UseVisualStyleBackColor = true;
            // 
            // lblEstreno
            // 
            this.lblEstreno.AutoSize = true;
            this.lblEstreno.Location = new System.Drawing.Point(14, 207);
            this.lblEstreno.Name = "lblEstreno";
            this.lblEstreno.Size = new System.Drawing.Size(43, 13);
            this.lblEstreno.TabIndex = 19;
            this.lblEstreno.Text = "Estreno";
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(106, 90);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(149, 20);
            this.txtDuracion.TabIndex = 9;
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Location = new System.Drawing.Point(106, 112);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(59, 13);
            this.lblAviso.TabIndex = 10;
            this.lblAviso.Text = "*HH:mm:ss";
            // 
            // FrmAgregarPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 309);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.lblEstreno);
            this.Controls.Add(this.chkEstreno);
            this.Controls.Add(this.lstPeliculas);
            this.Controls.Add(this.cboxCalificacion);
            this.Controls.Add(this.lblCalifica);
            this.Controls.Add(this.cboxGenero);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblDuracion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescrip);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Name = "FrmAgregarPelicula";
            this.Text = "Agregar Pelicula";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAgregarPelicula_FormClosing);
            this.Load += new System.EventHandler(this.FrmAgregarPelicula_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescrip;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.ComboBox cboxGenero;
        private System.Windows.Forms.Label lblCalifica;
        private System.Windows.Forms.ComboBox cboxCalificacion;
        private System.Windows.Forms.ListBox lstPeliculas;
        private System.Windows.Forms.CheckBox chkEstreno;
        private System.Windows.Forms.Label lblEstreno;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.Label lblAviso;
    }
}