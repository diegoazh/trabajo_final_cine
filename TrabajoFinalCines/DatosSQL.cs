using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; // De aquí para abajo es requerido para poder realizar la conexión con el sql server
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms; // Necesario para usar los componentes de un form (en este caso un MessageBox)

namespace TrabajoFinalCines
{
    class DatosSQL
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lectorDatos;
        private SqlDataAdapter adaptador;
        private DataTable tablaDatos;
        private DataSet dbCines;
        private string cadenaConexion;

        // Constructores
        public DatosSQL()
        {
            conexion = new SqlConnection();
            comando = new SqlCommand();
            lectorDatos = null;
            tablaDatos = new DataTable();
            cadenaConexion = null;
        }
        public DatosSQL(string cadenaConexion)
        {
            conexion = new SqlConnection();
            comando = new SqlCommand();
            lectorDatos = null;
            tablaDatos = new DataTable();
            this.cadenaConexion = cadenaConexion;
        }

        // Propiedades
        public SqlDataReader LectorDatos
        {
            set { lectorDatos = value; }
            get { return lectorDatos; }
        }
        public string CadenaConexion
        {
            set { cadenaConexion = value; }
            get { return cadenaConexion; }
        }
        public DataTable TablaDatos
        {
            set { tablaDatos = value; }
            get { return tablaDatos; }
        }
        public DataSet DBCines
        {
            set { dbCines = value; }
            get { return dbCines; }
        }

        // Metodos
        public void conectar()
        {
            try
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al establecer la conexión. A continuación se detallan los errores capturados.", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.ToString());
            }
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }
        public void desconectar()
        {
            conexion.Close();
            conexion.Dispose();
        }
        public DataTable selectAsterisco(string nombreTabla)
        {
            conectar();
            comando.CommandText = "select * from " + nombreTabla;
            try
            {
                /******************************************************************************************************************************************
                 * Esto lo hacemos porque si ejecutaramos el load solamente, lo que recupere la consulta se almacena con lo que ya contenga el dataTable.
                 * Y la idea es que el data table contenga solamente la información de la tabla que se consulta en ese momento
                 ******************************************************************************************************************************************/
                tablaDatos = null;
                tablaDatos = new DataTable();
                tablaDatos.Load(comando.ExecuteReader());
            }
            catch(Exception ex)
            {
                MessageBox.Show("Se encontraron errores o la tabla estaba vacia: \n" + ex.ToString());
            }
            desconectar();
            return tablaDatos;
        }
        public DataTable selectQuery(string query)
        {
            conectar();
            comando.CommandText = query;
            try
            {
                /******************************************************************************************************************************************
                 * Esto lo hacemos porque si ejecutaramos el load solamente, lo que recupere la consulta se almacena con lo que ya contenga el dataTable.
                 * Y la idea es que el data table contenga solamente la información de la tabla que se consulta en ese momento
                 ******************************************************************************************************************************************/
                tablaDatos = null;
                tablaDatos = new DataTable();
                tablaDatos.Load(comando.ExecuteReader());
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se encontro nada o la tabla estaba vacía. \n" + ex.ToString());
            }
            desconectar();
            return tablaDatos;
        }
        public void readTable(string nombreTabla)
        {
            conectar();
            comando.CommandText = "select * from " + nombreTabla;
            lectorDatos = comando.ExecuteReader();
        }

        /********************************************************************************************************************************
         * Este metodo hay que mejorarlo para no estar escribiendo consultas todo el tiempo,
         * probablemente sea util usar expresiones regulares para poder analizarlo.
         * En principio dentro deberia tener un DataReader seguramente, para que lea la tabla
         * que le pasemos y nos diga cuantas columnas tiene y luego en base a ello distribulla el
         * string de datos que le pasamos por parametro junto al nombre de la tabla para hacer el
         * insert update o delete; también sería muy necesario pasar un tercer parametro posiblemente
         * un entero para que dependiendo de su valor ejecute insert, update o delete.
         ********************************************************************************************************************************/

        public void insertUpdateDelete(string query)
        {
            conectar();
            comando.CommandText = query;
            comando.ExecuteNonQuery();
            desconectar();
        }

        public void validarUsuario(string user, string pass, out bool result, out int tipo)
        {
            // Para más información visite estas referencias:
            // https://msdn.microsoft.com/es-ar/library/cc438155(v=vs.71).aspx
            // https://msdn.microsoft.com/es-AR/library/ee332485.aspx
            // https://msdn.microsoft.com/es-AR/library/14akc2c7.aspx

            comando.CommandText = "validarUsuario"; // indicamos cual es el procedimiento de sqlserver que se utilizará
            comando.CommandType = System.Data.CommandType.StoredProcedure; // indicamos que el tipo de comando es un procedimiento

            if (comando.Parameters.Contains("@Name")
                || comando.Parameters.Contains("@Pass")
                || comando.Parameters.Contains("@Result")
                || comando.Parameters.Contains("@Tipo")) // Preguntamos si los parametros ya existen, si no hacemos esto despues del primer intento en caso de ser fallido, no podriamos ejecutar un segundo intento porque daria  un error, pues estaríamos creando nuevamente los parametros que ya existen
            {
                comando.Parameters["@Name"].Value = user;
                comando.Parameters["@Pass"].Value = pass;
            }
            else // si no existen los parametros los creamos.
            {
                comando.Parameters.Add("@Name", SqlDbType.NVarChar, 30).Value = user; // declaramos los parametros que recibe el procedimiento.
                comando.Parameters.Add("@Pass", SqlDbType.NVarChar, 30).Value = pass; // declaramos los parametros que recibe el procedimiento.
                comando.Parameters.Add("@Result", SqlDbType.Bit).Direction = ParameterDirection.Output; // declaramos el parametro que devuelve el procedimiento y su dirección, osea "output"
                comando.Parameters.Add("@Tipo", SqlDbType.Int).Direction = ParameterDirection.Output; // declaramos el parametro que devuelve el procedimiento y su dirección, osea "output"
            }

            conexion.ConnectionString = cadenaConexion; // creamos una nueva conexión, tener cuidado el metodo conectar no sirve porque nos cambia el comandType a text
            conexion.Open(); // abrimos la conexión
            comando.Connection = conexion; // indicamos cual sera la conexión a usar por el comando
            comando.ExecuteNonQuery(); // ejecutamos el comando contra la base de datos
            desconectar(); // desconectamos

            result = (bool)(comando.Parameters["@Result"].Value); // asignamos a la variable result el parametro que nos devuelve el procedimiento, que es un bit en sql, lo cual nos indica que en c# es de tipo bool (ver https://msdn.microsoft.com/es-es/library/yy6y35y8(v=vs.110).aspx)
            tipo = (int)(comando.Parameters["@Tipo"].Value);
        }

        public DataTable recaudacionPorGenero(int genero, int mes)
        {
            DataTable tablaRetornada = new DataTable();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "sp_recaudacionPorGenero " + genero +", "+ mes;
            //comando.CommandType = System.Data.CommandType.StoredProcedure;
            //if(comando.Parameters.Contains("@Genero") || comando.Parameters.Contains("@Meses"))
            //{
            //    comando.Parameters["@Genero"].Value = genero;
            //    comando.Parameters["@Meses"].Value = mes;
            //}
            //else
            //{
            //    comando.Parameters.Add("@Genero", SqlDbType.Int).Value = genero;
            //    comando.Parameters.Add("@Meses", SqlDbType.Int).Value = mes;
            //}
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();
            comando.Connection = conexion;
            tablaRetornada.Load(comando.ExecuteReader());
            desconectar();

            return tablaRetornada;
        }

        public DataTable recaudacionPorPelicula(int pelicula, int mes)
        {
            DataTable tablaRetornada = new DataTable();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "sp_recaudacionPorPelicula " + pelicula + ", " + mes;
            //comando.CommandType = System.Data.CommandType.StoredProcedure;
            //if (comando.Parameters.Contains("@Pelicula") || comando.Parameters.Contains("@Meses"))
            //{
            //    comando.Parameters["@Pelicula"].Value = pelicula;
            //    comando.Parameters["@Meses"].Value = mes;
            //}
            //else
            //{
            //    comando.Parameters.Add("@Pelicula", SqlDbType.Int).Value = pelicula;
            //    comando.Parameters.Add("@Meses", SqlDbType.Int).Value = mes;
            //}
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();
            comando.Connection = conexion;
            tablaRetornada.Load(comando.ExecuteReader());
            desconectar();

            return tablaRetornada;
        }

        public DataTable clientesNoSociosPorPelicula(int pelicula, bool socio, string fechaDesde, string fechaHasta)
        {
            DataTable tablaRetornada = new DataTable();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "sp_clientesNoSociosPorPelicula " + pelicula +", "+ socio + ", '" + fechaDesde + "', " +"'" + fechaHasta +"'";
            //comando.CommandType = System.Data.CommandType.StoredProcedure;
            //if (comando.Parameters.Contains("@Pelicula") || comando.Parameters.Contains("@Socio") ||
            //    comando.Parameters.Contains("@FechaDesde") || comando.Parameters.Contains("@FechaHasta"))
            //{
            //    comando.Parameters["@Pelicula"].Value = pelicula;
            //    comando.Parameters["@Socio"].Value = socio;
            //    comando.Parameters["@FechaDesde"].Value = fechaDesde;
            //    comando.Parameters["@FechaHasta"].Value = fechaHasta;
            //}
            //else
            //{
            //    comando.Parameters.Add("@Pelicula", SqlDbType.Int).Value = pelicula;
            //    comando.Parameters.Add("@Socio", SqlDbType.Bit).Value = socio;
            //    comando.Parameters.Add("@FechaDesde", SqlDbType.Date).Value = fechaDesde;
            //    comando.Parameters.Add("@FechaHasta", SqlDbType.Date).Value = fechaHasta;
            //}
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();
            comando.Connection = conexion;
            tablaRetornada.Load(comando.ExecuteReader());
            desconectar();

            return tablaRetornada;
        }

        public DataTable clientesPorPeliculaYButacaEnFecha(int pelicula, bool socio, int butaca, string fechaDesde, string fechaHasta)
        {
            DataTable tablaRetornada = new DataTable();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "sp_clientesPorPeliculaYButacaEnFecha " + pelicula + ", " + socio + ", " + butaca + ", '" + fechaDesde + "', " + "'" + fechaHasta + "'";
            //comando.CommandType = System.Data.CommandType.StoredProcedure;
            //if (comando.Parameters.Contains("@Pelicula") || comando.Parameters.Contains("@Socio") || comando.Parameters.Contains("@Butaca") ||
            //    comando.Parameters.Contains("@FechaDesde") || comando.Parameters.Contains("@FechaHasta"))
            //{
            //    comando.Parameters["@Pelicula"].Value = pelicula;
            //    comando.Parameters["@Socio"].Value = socio;
            //    comando.Parameters["@Butaca"].Value = butaca;
            //    comando.Parameters["@FechaDesde"].Value = fechaDesde;
            //    comando.Parameters["@FechaHasta"].Value = fechaHasta;
            //}
            //else
            //{
            //    comando.Parameters.Add("@Pelicula", SqlDbType.Int).Value = pelicula;
            //    comando.Parameters.Add("@Socio", SqlDbType.Bit).Value = socio;
            //    comando.Parameters.Add("@Butaca", SqlDbType.Int).Value = butaca;
            //    comando.Parameters.Add("@FechaDesde", SqlDbType.Date).Value = fechaDesde;
            //    comando.Parameters.Add("@FechaHasta", SqlDbType.Date).Value = fechaHasta;
            //}
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();
            comando.Connection = conexion;
            tablaRetornada.Load(comando.ExecuteReader());
            desconectar();

            return tablaRetornada;
        }

        public void recuperarTabla(DataSet dataSet, string nombreTabla)
        {
            /*********************************************************
             * Para mayor información sobre lo que hace este metodo
             * ver el siguiente tutorial de microsoft:
             * https://support.microsoft.com/es-es/kb/314145
             *********************************************************/

            adaptador = new SqlDataAdapter("Select * from "+nombreTabla, conexion);
            adaptador.FillSchema(dataSet, SchemaType.Source, nombreTabla);
            adaptador.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            adaptador.Fill(dataSet, nombreTabla);
        }

        public void recuperarTabla(DataSet dataSet, string nombreTabla, string query)
        {
            /*********************************************************
             * Para mayor información sobre lo que hace este metodo
             * ver el siguiente tutorial de microsoft:
             * https://support.microsoft.com/es-es/kb/314145
             *********************************************************/

            adaptador = new SqlDataAdapter(query, conexion);
            adaptador.FillSchema(dataSet, SchemaType.Source, nombreTabla);
            adaptador.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            adaptador.Fill(dataSet, nombreTabla);
        }

        public void crearDataSet()
        {
            /*********************************************************
             * Para mayor información sobre lo que hace este metodo
             * ver el siguiente tutorial de microsoft:
             * https://support.microsoft.com/es-es/kb/314145
             *********************************************************/

            try
            {
                dbCines = new DataSet("CINES");

                conexion.ConnectionString = cadenaConexion;
                conexion.Open();

                recuperarTabla(dbCines,"Provincias");
                recuperarTabla(dbCines,"Departamentos");
                recuperarTabla(dbCines,"Localidades");
                recuperarTabla(dbCines,"Barrios");
                recuperarTabla(dbCines,"Condiciones_Fiscales");
                recuperarTabla(dbCines,"Beneficios");
                recuperarTabla(dbCines,"Clientes");
                recuperarTabla(dbCines,"Tipo_Promociones");
                recuperarTabla(dbCines,"Promociones");
                recuperarTabla(dbCines,"Formas_de_Pagos");
                recuperarTabla(dbCines,"Cines");
                recuperarTabla(dbCines,"Facturas");
                recuperarTabla(dbCines,"Calificacion");
                recuperarTabla(dbCines,"Generos");
                recuperarTabla(dbCines,"Peliculas");
                recuperarTabla(dbCines,"Tipos_Salas");
                recuperarTabla(dbCines,"Salas");
                recuperarTabla(dbCines,"EstadoButacas");
                recuperarTabla(dbCines,"Butacas");
                recuperarTabla(dbCines,"Entradas");
                recuperarTabla(dbCines,"Funciones");
                recuperarTabla(dbCines,"Detalles_Facturas");
                recuperarTabla(dbCines,"Reservas");
                recuperarTabla(dbCines,"Detalles_Reservas");
                recuperarTabla(dbCines,"user_categories");
                recuperarTabla(dbCines,"users");

                conexion.Close();
                conexion.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Se detectaron errores: " + ex.ToString());
            }
        }

        public void eliminarDataSet(DataSet dataSet)
        {
            dataSet.Dispose();
        }
    }
}
