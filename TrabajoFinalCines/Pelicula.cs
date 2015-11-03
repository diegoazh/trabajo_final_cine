using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinalCines
{
    class Pelicula
    {
        private string nombre;
        private string descripcion;
        private string duracion;
        private int genero;
        private int calificacion;

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

    }
}
