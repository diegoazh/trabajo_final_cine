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
    public partial class frmAdministrador : Form
    {
        string database = @"Data Source=PC\SQLEXPRESS;Initial Catalog=CINES;Integrated Security=True";
        DatosSQL con;
        DataTable laTabla;
        DataTable tablaConsulta;
        List<DataTable> tablas;
        List<string> columnas = new List<string>();
        string consultas;
        Validaciones val;
        ManejoForm mnj;

        /****************************************************************
         * Propiedades
         ****************************************************************/
        public string Consultas
        {
            set { consultas = value; }
            get { return consultas; }
        }
        public DataTable TablaConsulta
        {
            set { tablaConsulta = value; }
            get { return tablaConsulta; }
        }
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
            //MessageBox.Show(query);

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
            if (list is Object)
                list.Clear();
            else
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
            val = new Validaciones();
            mnj = new ManejoForm(con);
        }

        private void cboTablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            chkLbCampos.Items.Clear();
            laTabla = tablas[cboTablas.SelectedIndex];
            cargarCamposChkLb(laTabla,chkLbCampos);
        }

        private void frmAdministrador_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.eliminarDataSet(con.DBCines);
        }

        private void btnAdminConsultar_Click(object sender, EventArgs e)
        {
            consultasALaDB(cboTablas,chkLbCampos,dtgvContenidoTablas);
            removerColumnas(columnas, chkLbCampos, dtgvContenidoTablas, con.TablaDatos);
            dtgvContenidoTablas.Refresh();
        }

        private void txtRecGenero_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void txtRecMeses_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void txtRecPeli_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void txtRecPeliMes_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void txtRecCalPeli_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void txtSocPeli_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void txtSocButaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void btnRecXGenero_Click(object sender, EventArgs e)
        {
            int gen = Convert.ToInt32(txtRecGenero.Text);
            int mes = Convert.ToInt32(txtRecMeses.Text);
            tablaConsulta = null;
            tablaConsulta = new DataTable();
            tablaConsulta = con.recaudacionPorGenero(gen, mes);
            dtgvContenidoTablas.DataSource = tablaConsulta;
            string query = "-- El total recaudado por el genero en el periodo de meses pedido y hasta la fecha. \n\n" +
                                    "create procedure sp_recaudacionPorGenero \n" +
                                    "@Genero int = 1, \n" +
                                    "@Meses int = 1 \n" +
                                    "as \n" +
                                    "select g.genero as 'Genero de pelicula', sum(e.precio - d.monto_promocion - d.monto_beneficio) as 'Totales Generales' \n" +
                                    "from Facturas as f, Detalles_Facturas as d, Entradas as e, Funciones as fun, Peliculas as p, Generos as g \n" +
                                    "where (f.id_factura = d.id_factura) and (d.id_entrada = e.id_entrada)  \n" +
                                    "and (fun.id_funcion = d.id_funcion) and (fun.id_pelicula = p.id_pelicula) \n" +
                                    "and (g.id_genero = p.id_genero) \n" +
                                    "and (g.id_genero = @Genero) and (f.fecha between dateadd(month, -@Meses, getdate()) and getdate()) \n" +
                                    "group by g.genero; \n";
            MessageBox.Show(query);
            mnj.limpiarText(this);
        }

        private void btnRecXPeli_Click(object sender, EventArgs e)
        {
            int gen = Convert.ToInt32(txtRecPeli.Text);
            int mes = Convert.ToInt32(txtRecPeliMes.Text);
            tablaConsulta = null;
            tablaConsulta = new DataTable();
            tablaConsulta = con.recaudacionPorPelicula(gen, mes);
            dtgvContenidoTablas.DataSource = tablaConsulta;
            string query = "-- El total recaudado la película en el periodo de meses pedido y hasta la fecha. \n"+
                            "create procedure sp_recaudacionPorPelicula \n"+
                            "@Pelicula int = 1, \n"+
                            "@Meses int = 1 \n"+
                            "as \n"+
                            "select p.nombre as 'Título de la Película', sum(e.precio - d.monto_promocion - d.monto_beneficio) as 'Totales Generales' \n"+
                            "from Facturas as f, Detalles_Facturas as d, Entradas as e, Funciones as fun, Peliculas as p \n"+
                            "where (f.id_factura = d.id_factura) and (d.id_entrada = e.id_entrada)  \n"+
                            "and (fun.id_funcion = d.id_funcion) and (fun.id_pelicula = p.id_pelicula) \n"+
                            "and (p.id_pelicula = @Pelicula) and (f.fecha between dateadd(month, -@Meses, getdate()) and getdate()) \n"+
                            "group by p.nombre";
            MessageBox.Show(query);
            mnj.limpiarText(this);
        }

        private void btnPeliXCalif_Click(object sender, EventArgs e)
        {
            int pel = Convert.ToInt32(txtRecCalPeli.Text);
            bool soc;
            if (chkRecCalSoc.Checked)
                soc = true;
            else
                soc = false;
            string desde = Convert.ToString(dtpRecCalDesde.Value.Date);
            string hasta = Convert.ToString(dtpRecCalHasta.Value.Date);
            string pattern = @"/(\d*[/|-]\d*)/g";
            desde = Regex.Replace(desde, pattern, String.Empty);
            hasta = Regex.Replace(hasta, pattern, String.Empty);

            tablaConsulta = null;
            tablaConsulta = new DataTable();
            tablaConsulta = con.clientesNoSociosPorPelicula(pel,soc,desde,hasta);
            dtgvContenidoTablas.DataSource = tablaConsulta;
            string query = "-- Pelicuas por calificacion, cantidad de clientes y entradas. \n"+
                            "create procedure sp_clientesNoSociosPorPelicula \n"+
                            "@Pelicula int = 1, \n"+
                            "@Socio bit = 0, \n"+
                            "@FechaDesde date, \n"+
                            "@FechaHasta date \n"+
                            "as \n"+
                            "if @FechaDesde = NULL \n"+
	                        "    return \n"+
                            "if @FechaHasta = NULL \n"+
	                        "    return \n"+
                            "begin \n"+
                            "select p.nombre as 'Título de la Pélicula', p.descripcion as 'Calificacion', count(*) as 'Cantidad de clientes', count(d.id_entrada) 'Cantidad de entradas' \n"+
                            "from Facturas as f, Detalles_Facturas as d, Entradas as e, Clientes as c, Funciones as fun, Peliculas as p, Calificacion as cal \n"+
                            "where (f.id_factura = d.id_factura) and (d.id_funcion = fun.id_funcion) and (d.id_entrada = e.id_entrada) and \n"+
                            "(f.id_cliente = c.id_cliente) and (fun.id_pelicula = p.id_pelicula) and (p.id_calificacion = cal.id_calificacion) and \n"+
                            "(f.fecha between @FechaDesde and @FechaHasta) and (p.id_pelicula = @Pelicula) \n"+
                            "group by p.nombre, p.descripcion \n"+
                            "end";
            MessageBox.Show(query);
            mnj.limpiarText(this);
        }

        private void btnSociosXPeli_Click(object sender, EventArgs e)
        {
            int pel = Convert.ToInt32(txtSocPeli.Text);
            int but = Convert.ToInt32(txtSocButaca.Text);
            bool soc;
            if (chkSocSocio.Checked)
                soc = true;
            else
                soc = false;
            string desde = Convert.ToString(dtpSocDesde.Value.Date);
            string hasta = Convert.ToString(dtpSocHasta.Value.Date);
            string pattern = @"/(\d*[/|-]\d*)/g";
            desde = Regex.Replace(desde, pattern, String.Empty);
            hasta = Regex.Replace(hasta, pattern, String.Empty);

            tablaConsulta = null;
            tablaConsulta = new DataTable();
            tablaConsulta = con.clientesPorPeliculaYButacaEnFecha(pel,soc,but,desde,hasta);
            dtgvContenidoTablas.DataSource = tablaConsulta;
            string query = "-- Socios que hayan visto determinada pelicula entre el determinadas fechas, y que se hayan sentado más de tres veces en la misma butaca. \n"+
                                "create procedure sp_clientesPorPeliculaYButacaEnFecha \n"+
                                "@Pelicula int = 1, \n"+
                                "@socio bit = 0, \n"+
                                "@Butaca int = 1, \n"+
                                "@FechaDesde date, \n"+
                                "@FechaHasta date \n"+
                                "as \n"+
                                "if @FechaDesde = null \n"+
	                            "    return \n"+
                                "if @FechaHasta = null \n"+
	                            "    return \n"+
                                "begin \n"+
                                "select c.nom_cliente as 'NOMBRE', c.ape_cliente as 'APELLIDO', p.nombre as 'PELICULA', s.nombre_sala as 'SALA', b.butaca as 'BUTACA' \n"+
                                "from Clientes as c join Facturas as f on c.id_cliente = f.id_cliente \n"+
	                            "    join Detalles_Facturas as d on f.id_factura = d.id_factura \n"+
	                            "    join Funciones as fun on d.id_funcion = fun.id_funcion \n"+
	                            "    join Peliculas as p on fun.id_pelicula = p.id_pelicula \n"+
	                            "    join Salas as s on fun.id_sala = s.id_sala \n"+
	                            "    join Butacas as b on s.id_sala = b.id_sala \n"+
                                "where (p.id_pelicula = @Pelicula) and (f.fecha between @FechaDesde and @FechaHasta) and (c.socio = @socio) \n"+
                                "and 3 < ( \n"+
	                            "    select count(b2.id_butaca) \n"+
	                            "    from Clientes as c2 join Facturas as f2 on c2.id_cliente = f2.id_cliente \n"+
		                        "        join Detalles_Facturas as d2 on f2.id_factura = d2.id_factura \n"+
		                        "        join Funciones as fun2 on d2.id_funcion = fun2.id_funcion \n"+
		                        "        join Salas as s2 on fun2.id_sala = s2.id_sala \n"+
		                        "        join Butacas as b2 on s2.id_sala = b2.id_sala \n"+
	                            "    where b2.id_butaca = @Butaca and c2.id_cliente = c.id_cliente \n"+
                                ") \n"+
                                "end";
            MessageBox.Show(query);
            mnj.limpiarText(this);
        }
    }
}