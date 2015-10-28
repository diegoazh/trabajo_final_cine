using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoFinalCines
{
    class Validaciones
    {
        public void soloLetras(KeyPressEventArgs e)
        {
            try
            {
                if(Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsSeparator(e.KeyChar))
                    e.Handled = false;
                else
                    e.Handled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void soloNumeros(KeyPressEventArgs e)
        {
            try
            {
                if(Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsSeparator(e.KeyChar))
                    e.Handled = false;
                else
                    e.Handled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void alfaNumerico(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsLetterOrDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsSeparator(e.KeyChar))
                    e.Handled = false;
                else
                    e.Handled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void alfaNumericoYEspeciales(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsLetterOrDigit(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsSeparator(e.KeyChar))
                    e.Handled = false;
                else
                    e.Handled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
