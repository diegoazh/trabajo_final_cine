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
        string user, pass;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            con = new DatosSQL(database);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // evaluamos los txt de usuario para ver cuales se rellenaron
            if (txtAdministrador.Text != String.Empty && txtUsuario.Text == String.Empty)
                user = txtAdministrador.Text;
            else if (txtAdministrador.Text == String.Empty && txtUsuario.Text != String.Empty)
                user = txtUsuario.Text;
            else if (txtAdministrador.Text != String.Empty && txtUsuario.Text != String.Empty)
            {
                user = txtUsuario.Text;
                txtAdministrador.Clear();
            }

            // evaluamos los txt de contraseña para ver cual esta rellenado
            if (txtContrasenia2.Text != String.Empty && txtContrasenia.Text == String.Empty)
                pass = txtContrasenia2.Text;
            else if (txtContrasenia2.Text == String.Empty && txtContrasenia.Text != String.Empty)
                pass = txtContrasenia.Text;
            else if (txtContrasenia2.Text != String.Empty && txtContrasenia.Text != String.Empty)
            {
                pass = txtContrasenia.Text;
                txtContrasenia2.Clear();
            }

            if (con.validarUsuario(user, pass))
                MessageBox.Show("Logueado");
            else
                MessageBox.Show("Algo salio mal");
        }
    }
}
