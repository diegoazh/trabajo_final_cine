using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinalCines
{
    class Pelicula
    {
        // Atributos
        private string nombre;
        private string descripcion;
        private string duracion;
        private int genero;
        private int calificacion;

        // Constructor
        public Pelicula()
        {
            nombre = "";
            descripcion = "";
            duracion = "00:00:00";
            genero = 0;
            calificacion = 0;
        }
        public Pelicula(string nombre, string descripcion, string duracion, int genero, int calificacion)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.duracion = duracion;
            this.genero = genero;
            this.calificacion = calificacion;
        }

        // Propiedades
        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public string Descripcion
        {
            set { descripcion = value; }
            get { return descripcion; }
        }
        public string Duracion
        {
            set { duracion = value; }
            get { return duracion; }
        }
        public int Genero
        {
            set { genero = value; }
            get { return genero; }
        }
        public int Calificacion
        {
            set { calificacion = value; }
            get { return calificacion; }
        }

        // Metodos toString
        public override string ToString()
        {
            return base.ToString();
        }

        // Otros metodos
    }
}
