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
    public partial class frmRecXGenero : Form
    {
        string database = "Data Source=.;Initial Catalog=CINES;Integrated Security=True";
        string result;
        DatosSQL con;
        Validaciones val;
        frmAdministrador admin;
        
        public string Result
        {
            set { result = value; }
            get { return result; }
        }

        public frmRecXGenero()
        {
            InitializeComponent();
        }

        private void frmRecXGenero_Load(object sender, EventArgs e)
        {
            admin = new frmAdministrador();
            con = new DatosSQL(database);
            val = new Validaciones();
        }

        private void btnRecCons1_Click(object sender, EventArgs e)
        {
            int gen = Convert.ToInt32(txtRecGenero.Text);
            int mes = Convert.ToInt32(txtRecMeses.Text);
            admin.TablaConsulta = null;
            admin.TablaConsulta = new DataTable();
            admin.TablaConsulta = con.recaudacionPorGenero(gen, mes);
            admin.Consultas = "";
            admin.Consultas = "-- El total recaudado por el genero en el periodo de meses pedido y hasta la fecha. \n"+
                                    "create procedure sp_recaudacionPorGenero \n"+
                                    "@Genero int = 1, \n"+
                                    "@Meses int = 1 \n"+
                                    "as \n"+
                                    "select g.genero as 'Genero de pelicula', sum(e.precio - d.monto_promocion - d.monto_beneficio) as 'Totales Generales' \n"+
                                    "from Facturas as f, Detalles_Facturas as d, Entradas as e, Funciones as fun, Peliculas as p, Generos as g \n"+
                                    "where (f.id_factura = d.id_factura) and (d.id_entrada = e.id_entrada)  \n"+
                                    "and (fun.id_funcion = d.id_funcion) and (fun.id_pelicula = p.id_pelicula) \n"+
                                    "and (g.id_genero = p.id_genero) \n"+
                                    "and (g.id_genero = @Genero) and (f.fecha between dateadd(month, -@Meses, getdate()) and getdate()) \n"+
                                    "group by g.genero; \n";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtRecGenero_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void txtRecMeses_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }
    }
}
