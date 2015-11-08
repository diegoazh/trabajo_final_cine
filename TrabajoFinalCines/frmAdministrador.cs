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

        public frmAdministrador()
        {
            InitializeComponent();
        }

        private void frmAdministrador_Load(object sender, EventArgs e)
        {
            con = new DatosSQL(database);
            con.crearDataSet();
        }
    }
}
