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
    public partial class frmLogin : Form
    {
        DatosSQL con;
        string database = "Data Source=.;Initial Catalog=CINES;Integrated Security=True";

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            con = new DatosSQL(database);
            con.conectar();
        }
    }
}
