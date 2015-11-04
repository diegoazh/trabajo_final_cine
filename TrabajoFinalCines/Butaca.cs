using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinalCines
{
    class Butaca
    {
        // Atributos
        private int numero;
        private int estado;

        // Constructores
        public Butaca()
        {
            numero = 0;
            estado = 0;
        }
        public Butaca(int numero, int estado)
        {
            this.numero = numero;
            this.estado = estado;
        }

        // Propiedades
        public int Numero
        {
            set { numero = value; }
            get { return numero; }
        }
        public int Estado
        {
            set { estado = value; }
            get { return estado; }
        }

        // Métodos toString
        public override string ToString()
        {
            return base.ToString();
        }

        // Otros metodos
    }
}
