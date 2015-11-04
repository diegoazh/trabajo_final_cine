using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinalCines
{
    class Promocion
    {
        // Atributo
        private string nombre;
        private string caracteristicas;
        private int cupo;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private DateTime fechaCreacion;
        private int descuento;
        private bool acumulable;

        // Constructor
        public Promocion()
        {
            nombre = "";
            caracteristicas = "";
            cupo = 0;
            fechaInicio = DateTime.Today;
            fechaFin = DateTime.Today;
            fechaCreacion = DateTime.Today;
            descuento = 0;
            acumulable = false;
        }
        public Promocion(string nombre, string caracteristicas, int cupo, DateTime fechaInicio, DateTime fechaFin,
            DateTime fechaCreacion, int descuento, bool acumulable)
        {
            this.nombre = nombre;
            this.caracteristicas = caracteristicas;
            this.cupo = cupo;
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
            this.fechaCreacion = fechaCreacion;
            this.descuento = descuento;
            this.acumulable = acumulable;
        }

        // Propiedades
        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public string Caracteristicas
        {
            set { caracteristicas = value; }
            get { return caracteristicas; }
        }
        public int Cupo
        {
            set { cupo = value; }
            get { return cupo; }
        }
        public DateTime FechaInicio
        {
            set { fechaInicio = value; }
            get { return fechaInicio; }
        }
        public DateTime FechaFin
        {
            set { fechaFin = value; }
            get { return fechaFin; }
        }
        public DateTime FechaCreacion
        {
            set { fechaCreacion = value; }
            get { return fechaCreacion; }
        }
        public int Descuento
        {
            set { descuento = value; }
            get { return descuento; }
        }
        public bool Acumulable
        {
            set { acumulable = value; }
            get { return acumulable; }
        }

        // Métodos toString
        public override string ToString()
        {
            return base.ToString();
        }

        //Otros métodos
    }
}
