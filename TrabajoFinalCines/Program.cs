using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoFinalCines
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            /******************************************************************************************************************************************************
             * Lo que vamos a realizar ahora es iniciar el form de login antes de iniciar la app principal.
             * Esto lo hacemos asi porque de otra forma la app se iniciaría de igual forma con todo el acceso
             * a los datos que ello representa. Otras formas serían iniciar la app y luego esconder el form principal
             * con this.Hide(); pero esto inicia la app y solo la oculta, lo cual permitiría tambien el acceso a los
             * datos aunque con un poco más de dificultad.
             * 
             * Para más detalles de lo que vamos a realizar ver el siguiente post: http://ltuttini.blogspot.com.ar/2009/09/c-winforms-realizar-tareas-antes-de.html
             * 
             ******************************************************************************************************************************************************/
            /*frmLogin log = new frmLogin(); // creamos el objeto del form

            do
            {
                log.ShowDialog(); // lo llamamos, como necesitamos un stop (osea que inicie y se quede ahí) usamos el ShowDialog, pues el simple Show no tendría efecto a este nivel.
            } while (log.DialogResult != DialogResult.Yes); // mientras el DialogResult del frmLogin sea diferente de Yes (cuando hacemos clic en el boton cerrar) llamaremos al frmLogin.

            if (log.Result == "OK") // si salimos del bucle fue porque el reultado fue Yes, result de frmLogin contiene el string OK iniciamos la app, de otra forma el programa finaliza.
            {
                if(log.Category == 1 || log.Category == 2)
                {
                    Application.Run(new frmAdministrador());
                }
                else
                {
                    Application.Run(new frmAppPrincipal());
                }
            }*/
            Application.Run(new frmAdministrador());
        }
    }
}
