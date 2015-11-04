using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinalCines
{
    class Funcion
    {
        // Atributos
        private Sala sala;
        private Pelicula pelicula;
        private string hsInicio;
        private string hsFin;

        // Constructor
        public Funcion()
        {
            sala = null;
            pelicula = null;
            hsInicio = "00:00:00";
            hsFin = "00:00:00";
        }
        public Funcion(Sala sala, Pelicula pelicula, string hsInicio, string hsFin) 
        {
            this.sala = sala;
            this.pelicula = pelicula;
            this.hsInicio = hsInicio;
            this.hsFin = hsFin;
        }

        // Propiedades
        public Sala Sala
        {
            set { sala = value; }
            get { return sala; }
        }
        public Pelicula Pelicula
        {
            set { pelicula = value; }
            get { return pelicula; }
        }
        public string HsInicio
        {
            set { hsInicio = value; }
            get { return hsInicio; }
        }
        public string HsFin
        {
            set { hsFin = value; }
            get { return hsFin; }
        }

        // Métodos toString
        public override string ToString()
        {
            return base.ToString();
        }

        // Otros métodos
    }
}
