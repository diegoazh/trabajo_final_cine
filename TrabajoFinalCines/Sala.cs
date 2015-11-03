﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinalCines
{
    class Sala
    {
        // Atributos: Convención los atributos siempre empiezan con "minúscula"
        private string nombre;
        private int cantButacas;
        private int tipo;
        
        // Constructores
        public Sala()
        {
            nombre = "";
            cantButacas = 0;
            tipo = 0;
        }
        public Sala(string nombre, int cantButacas, int tipo)
        {
            this.nombre = nombre;
            this.cantButacas = cantButacas;
            this.tipo = tipo;
        }

        // Propiedades: Convención las propiedades siempre empiezan con "MAYÚSCULA"
        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public int CantButacas
        {
            set { cantButacas = value; }
            get { return cantButacas; }
        }
        public int Tipo
        {
            set { tipo = value; }
            get { return tipo; }
        }

        // Metodos a String
        public override string ToString()
        {
            // Actualizar el metodo despues
            return base.ToString();
        }

        // Otros metodos
    }
}
