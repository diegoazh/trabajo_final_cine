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
        private SqlDataReader dataReader;
        private DataTable dataTable;
        private string cadenaConexion;

        // Constructores
        public DatosSQL()
        {
            conexion = new SqlConnection();
            comando = new SqlCommand();
            dataReader = null;
            dataTable = new DataTable();
            cadenaConexion = null;
        }
        public DatosSQL(string cadenaConexion)
        {
            conexion = new SqlConnection();
            comando = new SqlCommand();
            dataReader = null;
            dataTable = new DataTable();
            this.cadenaConexion = cadenaConexion;
        }

        // Propiedades
        public SqlDataReader pDataReader
        {
            set { dataReader = value; }
            get { return dataReader; }
        }
        public string pCadenaConexion
        {
            set { cadenaConexion = value; }
            get { return cadenaConexion; }
        }
        public DataTable pDataTable
        {
            set { dataTable = value; }
            get { return dataTable; }
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
            dataTable.Load(comando.ExecuteReader());
            desconectar();
            return dataTable;
        }
        public DataTable selectQuery(string query)
        {
            conectar();
            comando.CommandText = query;
            dataTable.Load(comando.ExecuteReader());
            desconectar();
            return dataTable;
        }
        public void readTable(string nombreTabla)
        {
            conectar();
            comando.CommandText = "select * from " + nombreTabla;
            dataReader = comando.ExecuteReader();
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
    }
}
