using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinalCines
{
    class Cliente
    {
        // Atributos
        private int dni;
        private int cuil;
        private int cuit;
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private int telefono;
        private int celular;
        private string mail;
        private string direccion;
        private int barrio;
        private int localidad;
        private int provincia;
        private int condicionFiscal;
        private int razonSocial;
        private int beneficio;
        private bool socio;
        private DateTime fechaIngresoSocio;

        // Constructor
        public Cliente()
        {
            dni = 0;
            cuil = 0;
            cuit = 0;
            nombre = "";
            apellido = "";
            fechaNacimiento = DateTime.Today;
            telefono = 0;
            celular = 0;
            mail = "";
            direccion = "";
            barrio = 0;
            localidad = 0;
            provincia = 0;
            condicionFiscal = 0;
            beneficio = 0;
            socio = false;
            fechaIngresoSocio = DateTime.Today;
        }
        public Cliente(int dni, int cuil, int cuit, string nombre, string apellido, DateTime fechaNacimiento,
            int telefono, int celular, string mail, string direccion, int barrio, int localidad, int provincia,
            int condicionFiscal, int razonSocial, int beneficio, bool socio, DateTime fechaIngresoSocio)
        {
            this.dni = dni;
            this.cuil = cuil;
            this.cuit = cuit;
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNacimiento = fechaNacimiento;
            this.telefono = telefono;
            this.celular = celular;
            this.mail = mail;
            this.direccion = direccion;
            this.barrio = barrio;
            this.localidad = localidad;
            this.provincia = provincia;
            this.condicionFiscal = condicionFiscal;
            this.beneficio = beneficio;
            this.socio = socio;
            this.fechaIngresoSocio = fechaIngresoSocio;
        }

        // Propiedades
        public int Dni
        {
            set { dni = value; }
            get { return dni; }
        }
        public int Cuil
        {
            set { cuil = value; }
            get { return cuil; }
        }
        public int Cuit
        {
            set { cuit = value; }
            get { return cuit; }
        }
        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public string Apellido
        {
            set { apellido = value; }
            get { return apellido; }
        }
        public DateTime FechaNacimiento
        {
            set { fechaNacimiento = value; }
            get { return fechaNacimiento; }
        }
        public int Telefono
        {
            set { telefono = value; }
            get { return telefono; }
        }
        public int Celular
        {
            set { celular = value; }
            get { return celular; }
        }
        public string Mail
        {
            set { mail = value; }
            get { return mail; }
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
        public int CondicionFiscal
        {
            set { condicionFiscal = value; }
            get { return condicionFiscal; }
        }
        public int Beneficio
        {
            set { beneficio = value; }
            get { return beneficio; }
        }
        public bool Socio
        {
            set { socio = value; }
            get { return socio; }
        }
        public DateTime FechaIngresoSocio
        {
            set { fechaIngresoSocio = value; }
            get { return fechaIngresoSocio; }
        }

        // Metodos toString
        public override string ToString()
        {
            return base.ToString();
        }

        // Otros metodos
    }
}
