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
    public partial class frmListadoPeliculas : Form
    {
        
        public frmListadoPeliculas()
        {
            InitializeComponent();
        }

        private void frmListadoPeliculas_Load(object sender, EventArgs e)
        {
            VistaPeliculasDataSet vistaPeliculas = new VistaPeliculasDataSet();
            cvReportePelicula.ReportSource = vistaPeliculas;
        }
    }
}
