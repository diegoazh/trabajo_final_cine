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
        string database = @"Data Source=PC\SQLEXPRESS;Initial Catalog=CINES;Integrated Security=True";
        DatosSQL con;
        ManejoForm mnj;
        VistaPeliculaDataSet datos;
        ReportePeliculas reporte;

        public frmListadoPeliculas()
        {
            InitializeComponent();
        }

        private void frmListadoPeliculas_Load(object sender, EventArgs e)
        {
            con = new DatosSQL(database);
            mnj = new ManejoForm(con);
            con.crearDataSet();
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            reporte = new ReportePeliculas();
            datos = new VistaPeliculaDataSet();
            con.conectar();
            con.recuperarTabla(datos, "vPeliculas");
            con.desconectar();
            reporte.SetDataSource(datos);
            cvReportePelicula.ReportSource = reporte;
            cvReportePelicula.Show();
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            string query;
            if (txtFiltro.Text != String.Empty)
            {
                query = "select * from vPeliculas where Titulo like '%"+txtFiltro.Text+"%';";
            }
            else
            {
                query = "Select * from vPeliculas;";
            }
            reporte = new ReportePeliculas();
            DataSet data = new DataSet();
            con.conectar();
            con.recuperarTabla(data, "vPeliculas", query);
            con.desconectar();
            reporte.SetDataSource(data);
            cvReportePelicula.ReportSource = reporte;
            cvReportePelicula.Show();
        }
    }
}
