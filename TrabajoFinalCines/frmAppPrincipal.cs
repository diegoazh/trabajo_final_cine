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
    public partial class frmAppPrincipal : Form
    {
        public frmAppPrincipal()
        {
            InitializeComponent();
        }

        private void frmAppPrincipal_Load(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPage2);
        }

        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgregarPelicula frmAP = new FrmAgregarPelicula();
            frmAP.ShowDialog();
        }

        private void listarPelículasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoPeliculas frmLP = new frmListadoPeliculas();
            frmLP.ShowDialog();
        }
    }
}
