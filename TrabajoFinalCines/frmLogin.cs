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
        Validaciones val;
        string database = "Data Source=.;Initial Catalog=CINES;Integrated Security=True";
        string user, pass;
        string result; // esta variable la vamos a utilizar en la clase program para evaluar si iniciamos la app principal o no.
        int category; // esta variable la vamos a utilizar en la clase program para evaluar si iniciamos la app de administrador o no.

        public string Result // esta propiedad nos va a servir para lo antes mensionado.
        {
            set { result = value; }
            get { return result; }
        }
        public int Category // esta propiedad nos va a servir para lo antes mensionado.
        {
            set { category = value; }
            get { return category; }
        }

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            con = new DatosSQL(database);
            val = new Validaciones();
            btnLogUser.Enabled = false;
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.Yes; // esto nos sirve para cerrar el form de logueo
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsuario.Text))
            {
                epUsuario.Icon = Properties.Resources.error;
                epUsuario.SetError(txtUsuario, "Este campo no puede quedar vacio");
            }
            else
            {
                epUsuario.Icon = Properties.Resources.success;
            }
        }

        private void txtPassUser_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPassUser.Text))
            {
                epPassUser.Icon = Properties.Resources.error;
                epPassUser.SetError(txtPassUser, "Este campo no puede quedar vacio");
            }
            else
            {
                epPassUser.Icon = Properties.Resources.success;
            }
        }

        private void txtPassUser_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtPassUser.Text))
                btnLogUser.Enabled = true;
            else
                btnLogUser.Enabled = false;
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.alfaNumerico(e);
        }

        private void txtPassUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                // evaluamos los txt de usuario para ver que esten rellenos
                if (txtUsuario.Text != String.Empty)
                    user = txtUsuario.Text;
                // evaluamos los txt de contraseña para ver cual esta rellenado
                if (txtPassUser.Text != String.Empty)
                    pass = txtPassUser.Text;

                bool login; // variable a utilizar en el metodo de validación
                int tipo; // variable a utilizar en el metodo de validación
                con.validarUsuario(user, pass, out login, out tipo); // validamos el usuario que intenta loguearse

                if (login)
                {
                    this.DialogResult = DialogResult.Yes; // esto nos sirve para llamar al frmAppPrincipal
                    result = "OK";
                    category = tipo;
                }
                else
                {
                    MessageBox.Show("Algo salio mal"); // si el login fue false mostramos el mensaje
                }
            }
        }

        private void btnLogUser_Click(object sender, EventArgs e)
        {
            // evaluamos los txt de usuario para ver que esten rellenos
            if (txtUsuario.Text != String.Empty)
                user = txtUsuario.Text;
            // evaluamos los txt de contraseña para ver cual esta rellenado
            if (txtPassUser.Text != String.Empty)
                pass = txtPassUser.Text;

            bool login; // variable a utilizar en el metodo de validación
            int tipo; // variable a utilizar en el metodo de validación
            con.validarUsuario(user, pass, out login, out tipo); // validamos el usuario que intenta loguearse

            if (login)
            {
                this.DialogResult = DialogResult.Yes; // esto nos sirve para llamar al frmAppPrincipal
                result = "OK";
                category = tipo;
            }
            else
            {
                MessageBox.Show("Algo salio mal"); // si el login fue false mostramos el mensaje
            }
        }
    }
}
