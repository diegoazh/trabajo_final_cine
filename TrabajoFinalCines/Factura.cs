using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinalCines
{
    class Factura
    {
        // Atributos
        private int nroFactura;
        private DateTime fecha;
        private Cine cine;
        private Cliente cliente;
        private int formaDePago;
        private int butaca;
        private double precio;
        private int promocion;
        private int descuento;

        // Constructor
        public Factura()
        {
            nroFactura = 0;
            fecha = DateTime.Today;
            cine = null;
            cliente = null;
            formaDePago = 0;
            butaca = 0;
            precio = 0;
            promocion = 0;
            descuento = 0;
        }
        public Factura( int nroFactura, DateTime fecha, Cine cine, Cliente cliente, int formaDePago,
            int butaca, double precio, int promocion, int descuento)
        {
            this.nroFactura = nroFactura;
            this.fecha = fecha;
            this.cine = cine;
            this.cliente = cliente;
            this.formaDePago = formaDePago;
            this.butaca = butaca;
            this.precio = precio;
            this.promocion = promocion;
            this.descuento = descuento;
        }

        // Propiedades
        public int NroFactura
        {
            set { nroFactura = value; }
            get { return nroFactura; }
        }
        public DateTime Fecha
        {
            set { fecha = value; }
            get { return fecha; }
        }
        public Cine Cine
        {
            set { cine = value; }
            get { return cine; }
        }
        public Cliente Cliente
        {
            set { cliente = value; }
            get { return cliente; }
        }
        public int FormaDePago
        {
            set { formaDePago = value; }
            get { return formaDePago; }
        }
        public int Butaca
        {
            set { butaca = value; }
            get { return butaca; }
        }
        public double Precio
        {
            set { precio = value; }
            get { return precio; }
        }
        public int Promocion
        {
            set { promocion = value; }
            get { return promocion; }
        }
        public int Descuento
        {
            set { descuento = value; }
            get { return descuento; }
        }

        // Metodos toString
        public override string ToString()
        {
            return base.ToString();
        }

        // Otros Metodos
    }
}
