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
        private int idPelicula;
        private string nombre;
        private string descripcion;
        private string duracion;
        private int genero;
        private int calificacion;
        private int estreno;

        // Constructor
        public Pelicula()
        {
            nombre = "";
            descripcion = "";
            duracion = "";
            genero = 0;
            calificacion = 0;
            estreno = 0;
        }
        public Pelicula(string nombre, string descripcion, string duracion, int genero, int calificacion, int estreno)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.duracion = duracion;
            this.genero = genero;
            this.calificacion = calificacion;
            this.estreno = estreno;
        }

        // Propiedades
        public int IdPelicula
        {
            set { idPelicula = value; }
            get { return idPelicula; }
        }

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
        public int Estreno
        {
            set { estreno = value; }
            get { return estreno; }
        }

        // Metodos toString
        public override string ToString()
        {
            return "Nombre: " + nombre + " Estreno: " + toStringEstreno() + " Duración: " + duracion;
        }

        public string toStringEstreno()
        {
            string es;
            if (estreno == 1)
                es = "Si";
            else
                es = "No";

            return es;
        }
        // Otros metodos
    }
}
