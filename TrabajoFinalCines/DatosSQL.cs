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
        public SqlDataReader DataReader
        {
            set { dataReader = value; }
            get { return dataReader; }
        }
        public string CadenaConexion
        {
            set { cadenaConexion = value; }
            get { return cadenaConexion; }
        }
        public DataTable DataTable
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

        public bool validarUsuario(string user, string pass)
        {
            // para más información visite esta referencia https://msdn.microsoft.com/es-ar/library/cc438155(v=vs.71).aspx
            bool result; // creamos la variable que devolvera el metodo

            comando.CommandText = "validarUsuario"; // indicamos cual es el procedimiento de sqlserver que se utilizará
            comando.CommandType = System.Data.CommandType.StoredProcedure; // indicamos que el tipo de comando es un procedimiento

            if (comando.Parameters.Contains("@Name")
                || comando.Parameters.Contains("@Pass")
                || comando.Parameters.Contains("@Result")) // Preguntamos si los parametros ya existen, si no hacemos esto despues del primer intento en caso de ser fallido, no podriamos ejecutar un segundo intento porque daria  un error, pues estaríamos creando nuevamente los parametros que ya existen
            {
                comando.Parameters["@Name"].Value = user;
                comando.Parameters["@Pass"].Value = pass;
            }
            else // si no existen los parametros los creamos.
            {
                comando.Parameters.Add("@Name", SqlDbType.NVarChar, 30).Value = user; // declaramos los parametros que recibe el procedimiento.
                comando.Parameters.Add("@Pass", SqlDbType.NVarChar, 30).Value = pass; // declaramos los parametros que recibe el procedimiento.
                comando.Parameters.Add("@Result", SqlDbType.Bit).Direction = ParameterDirection.Output; // declaramos el parametro que devuelve el procedimiento y su dirección, osea "output"
            }

            conexion.ConnectionString = cadenaConexion; // creamos una nueva conexión, tener cuidado el metodo conectar no sirve porque nos cambia el comandType a text
            conexion.Open(); // abrimos la conexión
            comando.Connection = conexion; // indicamos cual sera la conexión a usar por el comando
            comando.ExecuteNonQuery(); // ejecutamos el comando contra la base de datos
            desconectar(); // desconectamos

            result = (bool)(comando.Parameters["@Result"].Value); // asignamos a la variable result el parametro que nos devuelve el procedimiento, que es un bit en sql, lo cual nos indica que en c# es de tipo bool (ver https://msdn.microsoft.com/es-es/library/yy6y35y8(v=vs.110).aspx)
            return result; // retornamos el valor
        }
    }
}
