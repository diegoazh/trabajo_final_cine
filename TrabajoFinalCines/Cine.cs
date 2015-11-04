using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinalCines
{
    class Cine
    {
        // Atributos
        private string nombre;
        private int razonSocial;
        private int cuit;
        private int condicionFiscal;
        private string direccion;
        private int barrio;
        private int localidad;
        private int provincia;
        private Sala[] salas;

        // Constructor
        public Cine()
        {
            nombre = "";
            razonSocial = 0;
            cuit = 0;
            condicionFiscal = 0;
            direccion = "";
            barrio = 0;
            localidad = 0;
            provincia = 0;
            salas = null;
        }
        public Cine(string nombre, int razonSocial, int cuit, int condicionFiscal, string direccion, int barrio,
            int localidad, int provincia, Sala[] salas)
        {
            this.nombre = nombre;
            this.razonSocial = razonSocial;
            this.cuit = cuit;
            this.condicionFiscal = condicionFiscal;
            this.direccion = direccion;
            this.barrio = barrio;
            this.localidad = localidad;
            this.provincia = provincia;
            this.salas = salas;
        }

        // Atributos
        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public int RazonSocial
        {
            set { razonSocial = value; }
            get { return razonSocial; }
        }
        public int Cuit
        {
            set { cuit = value; }
            get { return cuit; }
        }
        public int CondicionFiscal
        {
            set { condicionFiscal = value; }
            get { return condicionFiscal; }
        }
        public string Direccion
        {
            set { direccion = value; }
            get { return direccion; }
        }
        public int Barrio
        {
            set { barrio = value; }
            get { return barrio; }
        }
        public int Localidad
        {
            set { localidad = value; }
            get { return localidad; }
        }
        public int Provincia
        {
            set { provincia = value; }
            get { return provincia; }
        }
        public Sala[] Salas
        {
            set { salas = value; }
            get { return salas; }
        }

        // Métodos toString
        public override string ToString()
        {
            return base.ToString();
        }

        // Otros métodos
    }
}
