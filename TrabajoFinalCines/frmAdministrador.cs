using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoFinalCines
{
    public partial class frmAdministrador : Form
    {
        string database = "Data Source=.;Initial Catalog=CINES;Integrated Security=True";
        DatosSQL con;
        List<DataTable> tablas;
        List<string> columnas;

        /****************************************************************
         * Metodos para el manejor del form
         ****************************************************************/
        public void cargarTablasEnCbo(List<DataTable> listTablas, ComboBox comboBox)
        {
            foreach(DataTable tabla in con.DBCines.Tables)
            {
                listTablas.Add(tabla);
            }
            for (int i = 0; i < listTablas.Count; i++)
            {
                comboBox.Items.Add(listTablas[i].TableName);
            }
        }
        public void cargarCamposChkLb(DataTable dataTable, CheckedListBox checkListBox)
        {
            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                checkListBox.Items.Add(dataTable.Columns[i].ColumnName);
            }
        }
        public void consultasALaDB(ComboBox comboBox, CheckedListBox checkedListBox, DataGridView dataGridView)
        {
            string query;
            string campos = "";

            if (checkedListBox.CheckedItems.Count > 0)
            {
                for (int i = 0; i < checkedListBox.CheckedItems.Count; i++)
                {
                    campos += checkedListBox.CheckedItems[i].ToString() + ",";
                }
            }
            else
            {
                campos = "*";
            }

            campos = campos.TrimEnd(',');

            query = "select " + campos + " from " + comboBox.SelectedItem;
            MessageBox.Show(query);

            con.selectQuery(query);

            try
            {
                dataGridView.DataSource = con.TablaDatos;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Se encontraron errores: " + ex.ToString());
            }
        }
        public void removerColumnas(List<string> list, CheckedListBox checkedListBox, DataGridView dataGridView, DataTable dataTable)
        {
            list.Clear();
            list = new List<string>();

            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                list.Add(dataTable.Columns[i].ColumnName.ToString());
            }

            for (int a = 0; a < checkedListBox.CheckedItems.Count; a++)
            {
                list.Remove(checkedListBox.CheckedItems[a].ToString());
            }

            if (checkedListBox.CheckedItems.Count != 0)
            {
                for (int b = 0; b < list.Count; b++)
                {
                    dataGridView.Columns.Remove(list[b]);
                }
            }
        }
        /****************************************************************
         * Fin metodos para el manejor del form
         ****************************************************************/

        public frmAdministrador()
        {
            InitializeComponent();
        }

        private void frmAdministrador_Load(object sender, EventArgs e)
        {
            con = new DatosSQL(database);
            con.crearDataSet();
            tablas = new List<DataTable>();
            cargarTablasEnCbo(tablas, cboTablas);
        }

        private void cboTablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            chkLbCampos.Items.Clear();
            DataTable laTabla = tablas[cboTablas.SelectedIndex];
            cargarCamposChkLb(laTabla,chkLbCampos);
        }

        private void frmAdministrador_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.eliminarDataSet(con.DBCines);
        }

        private void btnAdminConsultar_Click(object sender, EventArgs e)
        {
            con.TablaDatos.Clear();
            consultasALaDB(cboTablas,chkLbCampos,dtgvContenidoTablas);
            removerColumnas(columnas, chkLbCampos, dtgvContenidoTablas, con.TablaDatos);
            dtgvContenidoTablas.Refresh();
        }
    }
}