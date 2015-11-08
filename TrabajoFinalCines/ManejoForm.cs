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

        /*public void cargarLista(ListBox nombre, string tabla, out Producto[] vector)
        {
            Producto[] vp = new Producto[50];
            cnx.readTable(tabla);
            int c = 0;
            while (cnx.pDataReader.Read())
            {
                Producto p = new Producto();
                if (!cnx.pDataReader.IsDBNull(0))
                    p.pCodigo = cnx.pDataReader.GetInt32(0);
                if (!cnx.pDataReader.IsDBNull(1))
                    p.pDetalle = cnx.pDataReader.GetString(1);
                if (!cnx.pDataReader.IsDBNull(2))
                    p.pTipo = cnx.pDataReader.GetInt32(2);
                if (!cnx.pDataReader.IsDBNull(3))
                    p.pMarca = cnx.pDataReader.GetInt32(3);
                if (!cnx.pDataReader.IsDBNull(4))
                    p.pPrecio = cnx.pDataReader.GetDouble(4);
                if (!cnx.pDataReader.IsDBNull(5))
                    p.pFecha = cnx.pDataReader.GetDateTime(5);
                vp[c] = p;
                c++;
            }
            cnx.pDataReader.Close();
            cnx.desconectar();

            nombre.Items.Clear();
            for (int i = 0; i < c; i++)
            {
                nombre.Items.Add(vp[i].ToString());
            }

            vector = vp;
        }*/

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