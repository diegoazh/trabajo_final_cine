using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TrabajoFinalCines
{
    /*********************************************************************
     * Esta clase hay que adaptarla al proyecto esta realizada para un 
     * proyecto anterior por ello tiene clases que no existen como la de
     * producto que aparece más abajo, pero como la idea es la misma la
     * vamos a reciclar y si se puede mejorar para que se adapte mejor a
     * futuros proyectos.
     *********************************************************************/
    class ManejoForm
    {
        private DatosSQL cnx;

        public ManejoForm(DatosSQL conexion)
        {
            cnx = conexion;
        }

        public void cargarCombo(ComboBox nombre, string tabla)
        {
            cnx.selectAsterisco(tabla);
            nombre.DataSource = cnx.TablaDatos;
            nombre.ValueMember = cnx.TablaDatos.Columns[0].ColumnName;
            nombre.DisplayMember = cnx.TablaDatos.Columns[1].ColumnName;
        }

        public void cargarLista(ListBox nombre, string tabla, out Pelicula[] vector)
        {
            Pelicula[] vp = new Pelicula[50];
            cnx.readTable(tabla);
            int c = 0;
            while (cnx.LectorDatos.Read())
            {
                Pelicula p = new Pelicula();
                if (!cnx.LectorDatos.IsDBNull(0))
                    p.IdPelicula = cnx.LectorDatos.GetInt32(0);
                if (!cnx.LectorDatos.IsDBNull(1))
                    p.Nombre = cnx.LectorDatos.GetString(1);
                if (!cnx.LectorDatos.IsDBNull(2))
                    p.Descripcion = cnx.LectorDatos.GetString(2);
                if (!cnx.LectorDatos.IsDBNull(3))
                    p.Estreno = cnx.LectorDatos.GetInt32(3);
                if (!cnx.LectorDatos.IsDBNull(4))
                    p.Duracion = cnx.LectorDatos.GetString(4);
                if (!cnx.LectorDatos.IsDBNull(5))
                    p.Genero = cnx.LectorDatos.GetInt32(5);
                if (!cnx.LectorDatos.IsDBNull(6))
                    p.Calificacion = cnx.LectorDatos.GetInt32(6);
                vp[c] = p;
                c++;
            }
            cnx.LectorDatos.Close();
            cnx.desconectar();

            nombre.Items.Clear();
            for (int i = 0; i < c; i++)
            {
                nombre.Items.Add(vp[i].ToString());
            }

            vector = vp;
        }

        public void limpiarText(Form form)
        {
            foreach(Control allControls in form.Controls)
            {
                if (allControls is TextBox)
                {
                    ((TextBox)allControls).Clear();
                }
            }
        }

        public void inicializacionForm(Form form, bool boolean)
        {
            foreach (Control allcontrolls in form.Controls)
            {
                if (allcontrolls is TextBox)
                {
                    if (allcontrolls.Name == "txtDetalle")
                        allcontrolls.Enabled = boolean;
                    if (allcontrolls.Name == "txtCodigo")
                        allcontrolls.Enabled = boolean;
                    if (allcontrolls.Name == "txtPrecio")
                        allcontrolls.Enabled = boolean;
                }
                if (allcontrolls is Button)
                {
                    if (allcontrolls.Name == "btnEditar")
                        allcontrolls.Enabled = boolean;
                    if (allcontrolls.Name == "btnEliminar")
                        allcontrolls.Enabled = boolean;
                    if (allcontrolls.Name == "btnCargar")
                        allcontrolls.Enabled = boolean;
                    if (allcontrolls.Name == "btnCancelar")
                        allcontrolls.Enabled = boolean;
                }
                if (allcontrolls is DateTimePicker)
                {
                    allcontrolls.Enabled = boolean;
                }
                if (allcontrolls is ComboBox)
                {
                    allcontrolls.Enabled = boolean;
                }
                if (allcontrolls is RadioButton)
                {
                    allcontrolls.Enabled = boolean;
                }
            }
        }
    }
}