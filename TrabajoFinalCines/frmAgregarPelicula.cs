using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TrabajoFinalCines
{
    public partial class FrmAgregarPelicula : Form
    {
        string database = @"Data Source=PC\SQLEXPRESS;Initial Catalog=CINES;Integrated Security=True";
        DatosSQL con;
        ManejoForm mnj;
        Pelicula[] vp = new Pelicula[999];
        bool nuevo = false;

        public FrmAgregarPelicula()
        {
            InitializeComponent();
        }

        

        private void FrmAgregarPelicula_Load(object sender, EventArgs e)
        {
            con = new DatosSQL(database);
            mnj = new ManejoForm(con);
            txtDuracion.MaxLength = 8;
            mnj.cargarCombo(cboxGenero, "Generos");
            mnj.cargarCombo(cboxCalificacion, "Calificacion");
            mnj.cargarLista(lstPeliculas, "Peliculas", out vp);
            deshabilitar();
        }

        private void lblDescrip_Click(object sender, EventArgs e)
        {

        }


        //////////////////Métodos/////////////////
        public void Limpiar()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtDuracion.Text = "";
            cboxGenero.SelectedIndex = 0;
            cboxCalificacion.SelectedIndex = 0;
        }

        private void habilitar()
        {
            //Items que se habilitan
            txtNombre.Enabled = true;
            txtDescripcion.Enabled = true;
            txtDuracion.Enabled = true;
            cboxCalificacion.Enabled = true;
            cboxGenero.Enabled = true;
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
            chkEstreno.Enabled = true;

            //items que se deshabilitan
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnBorrar.Enabled = false;
            lstPeliculas.Enabled = false;
        }

        private void deshabilitar()
        {
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            btnBorrar.Enabled = true;
            lstPeliculas.Enabled = true;
            nuevo = false;
            txtNombre.Enabled = false;
            txtDescripcion.Enabled = false;
            txtDuracion.Enabled = false;
            cboxCalificacion.Enabled = false;
            cboxGenero.Enabled = false;
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;
            chkEstreno.Enabled = false;
            btnEditar.Enabled = false;
        }

        private void FrmAgregarPelicula_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esta Seguro de cerrar la ventana?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstPeliculas_SelectedIndexChanged(object sender, EventArgs e)
        {
            nuevo = false;
            btnEditar.Enabled = true;
            int x = lstPeliculas.SelectedIndex;

            txtNombre.Text = vp[x].Nombre;
            txtDescripcion.Text = vp[x].Descripcion;
            txtDuracion.Text = vp[x].Duracion;
            cboxCalificacion.SelectedValue = vp[x].Calificacion;
            cboxGenero.SelectedValue = vp[x].Genero;
            if (vp[x].Estreno == 1)
                chkEstreno.Checked = true;
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            nuevo = true;
            mnj.limpiarText(this);
            habilitar();
            txtNombre.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            nuevo = false;
            habilitar();
            txtNombre.Focus();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Esta seguro que desea eliminar la pelicula?","Eliminar pelicula",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = "delete from Peliculas where id_pelicula = " + vp[lstPeliculas.SelectedIndex].IdPelicula;
                con.insertUpdateDelete(sql);
                Limpiar();
                lstPeliculas.Items.Clear();
                mnj.cargarLista(lstPeliculas, "Peliculas", out vp);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Pelicula pel = new Pelicula();
            if(txtNombre.Text == String.Empty)
            {
                MessageBox.Show("Este campo no puede quedar vacio");
                txtNombre.Focus();
            }
            else if (txtDescripcion.Text == String.Empty)
            {
                MessageBox.Show("Este campo no puede quedar vacio");
                txtDescripcion.Focus();
            }
            else if (txtDuracion.Text == String.Empty)
            {
                MessageBox.Show("Este campo no puede quedar vacio");
                txtDescripcion.Focus();
            }
            else
            {
                string dur = txtDuracion.Text;

                pel.Nombre = txtNombre.Text;
                pel.Descripcion = txtDescripcion.Text;
                pel.Duracion = dur;
                if (chkEstreno.Checked)
                    pel.Estreno = 1;
                else
                    pel.Estreno = 0;
                pel.Genero = cboxGenero.SelectedIndex + 1;
                pel.Calificacion = cboxCalificacion.SelectedIndex + 1;

                string sql;
                if (nuevo)
                {
                    sql = "insert into Peliculas values('" + pel.Nombre + "', '" + pel.Descripcion + "', " + pel.Estreno + ", '" + pel.Duracion + "', " + pel.Genero + ", " + pel.Calificacion + ", null, null, null)";
                    con.insertUpdateDelete(sql);
                }
                else
                {
                    sql = "update peliculas set nombre = '" + pel.Nombre + "', descripcion = '" + pel.Descripcion + "', estreno = " + pel.Estreno + ", duracion = '" + pel.Duracion + "', id_genero = " + pel.Genero + ", id_calificacion = " + pel.Calificacion + " where id_pelicula = " + vp[lstPeliculas.SelectedIndex].IdPelicula;
                    con.insertUpdateDelete(sql);
                }
                lstPeliculas.Items.Clear();
                mnj.cargarLista(lstPeliculas, "Peliculas", out vp);
                Limpiar();
                deshabilitar();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            deshabilitar();
        }


    }
}
