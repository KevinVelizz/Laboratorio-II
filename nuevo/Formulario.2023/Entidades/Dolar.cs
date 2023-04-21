using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Dolar
    {
        private double cantidad;
        private double cotzRespectoDolar;
    
        
        public Dolar()
        {
            this.cotzRespectoDolar = 1;
        }

        public Dolar(double cantidad) :this()
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, double cotzRespectoDolar) :this(cantidad)
        {
            this.cantidad = cantidad;
            this.cotzRespectoDolar = cotzRespectoDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public double GetCotizacion() 
        {
            return this.cotzRespectoDolar;
        }

        public void SetCotizacion(double cotzRespectoDolar)
        {
            this.cotzRespectoDolar = cotzRespectoDolar;
        }

        public static implicit operator Dolar(double cantidad)
        {
            return new Dolar(cantidad);
        }

        public static explicit operator Euro(Dolar dolar)
        {
            Euro valorCotz = new Euro(1);
            double euro;
            euro = dolar.GetCantidad() / valorCotz.GetCotizacion();
            return (Euro)euro;
        }

        public static explicit operator Pesos(Dolar dolar)
        {
            Pesos valorCotz = new Pesos(1);
            double peso;
            peso = dolar.GetCantidad() * valorCotz.GetCotizacion();
            return (Pesos)peso; 
        }

        public static bool operator ==(Dolar dolar1, Dolar dolar2)
        {
            return dolar1.cantidad == dolar2.cantidad;
        }

        public static bool operator !=(Dolar dolar1, Dolar dolar2)
        {
            return !(dolar1 == dolar2);
        }

        public static bool operator ==(Dolar dolar, Pesos pesos)
        {
            Dolar dolar1 = (Dolar)pesos;
            return dolar == dolar1;
        }

        public static bool operator !=(Dolar dolar, Pesos pesos)
        {
            return !(dolar == pesos);
        }

        public static bool operator ==(Dolar dolar, Euro euro) 
        { 
            Dolar dolar1 = (Dolar)euro;
            return dolar == dolar1;
        }

        public static bool operator !=(Dolar dolar, Euro euro)
        {
            return !(dolar == euro);
        }

        public static Dolar operator +(Dolar dolar1, Dolar dolar2)
        {
            return (Dolar)(dolar1.cantidad + dolar2.cantidad);
        }

        public static Dolar operator +(Dolar dolar, Pesos pesos)
        {
            return (Dolar)(dolar + ((Dolar)pesos));
        }

        public static Dolar operator +(Dolar dolar, Euro euro)
        {
            return (Dolar)(dolar + ((Dolar)euro));
        }

        public static Dolar operator -(Dolar dolar1, Dolar dolar2)
        {
            return (Dolar)(dolar1.cantidad - dolar2.cantidad);
        }

        public static Dolar operator -(Dolar dolar, Euro euro)
        {
            return (Dolar)(dolar - (Dolar)euro);
        }

        public static Dolar operator -(Dolar dolar, Pesos pesos)
        {
            return (Dolar)(dolar - ((Dolar)pesos));
        }
    }
}
