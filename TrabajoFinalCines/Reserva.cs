using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinalCines
{
    class Reserva
    {
        // Atributos
        private DateTime fecha;
        private Funcion funcion;
        private Butaca butaca;
        private Cliente cliente;

        // Constructor
        public Reserva()
        {
            fecha = DateTime.Today;
            funcion = null;
            butaca = null;
            cliente = null;
        }
        public Reserva(DateTime fecha, Funcion funcion, Butaca butaca, Cliente cliente)
        {
            this.fecha = fecha;
            this.funcion = funcion;
            this.butaca = butaca;
            this.cliente = cliente;
        }

        // Propiedades
        public DateTime Fecha
        {
            set { fecha = value; }
            get { return fecha; }
        }
        public Funcion Funcion
        {
            set { funcion = value; }
            get { return funcion; }
        }
        public Butaca Butaca
        {
            set { butaca = value; }
            get { return butaca; }
        }
        public Cliente Cliente
        {
            set { cliente = value; }
            get { return cliente; }
        }

        // Método toString
        public override string ToString()
        {
            return base.ToString();
        }

        // Otros métodos
    }
}
