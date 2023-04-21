using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Euro
    {
        private double cantidad;
        private double cotzRespectoDolar;

        private Euro() 
        {
            this.cotzRespectoDolar = 1.17;
        }

        public Euro(double cantidad) :this()
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad,  double cotzRespectoDolar) :this(cantidad)
        {
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

        public static implicit operator Euro(double euro)
        {
            return new Euro(euro);
        }

        public static explicit operator Dolar(Euro euro)
        {
            double dolar;
            dolar = euro.GetCantidad() * euro.GetCotizacion();
            return (Dolar)dolar;
        }

        public static explicit operator Pesos(Euro euro)
        {
            return (Pesos)((Dolar)euro);
        }

        public static bool operator ==(Euro euro1, Euro euro2)
        { 
            return euro1.cantidad == euro2.cantidad;
        }

        public static bool operator !=(Euro euro1, Euro euro2)
        {
            return !(euro1 == euro2);
        }

        public static bool operator ==(Euro euro, Pesos pesos)
        {
            Euro euro1 = (Euro)pesos;
            return euro == euro1;
        }

        public static bool operator !=(Euro euro, Pesos pesos)
        {
            return !(euro == pesos);
        }

        public static bool operator ==(Euro euro, Dolar dolar)
        {
            Euro euro1 = (Euro)dolar;
            return euro == euro1;
        }

        public static bool operator !=(Euro euro, Dolar dolar)
        {
            return !(euro == dolar);
        }

        public static Euro operator +(Euro euro1, Euro euro2)
        {
            return (Euro)(euro1.cantidad + euro2.cantidad);
        }

        public static Euro operator +(Euro euro, Pesos pesos)
        {
            return (Euro)(euro + ((Euro)pesos));
        }
        
        public static Euro operator +(Euro euro, Dolar dolar)
        {
            return (Euro)(euro + ((Euro)dolar));
        }

        public static Euro operator -(Euro euro1, Euro euro2)
        {
            return (Euro)(euro1.cantidad - euro2.cantidad);
        }
        public static Euro operator -(Euro euro, Dolar dolar)
        {
            return (Euro)(euro - ((Euro)dolar));
        }

        public static Euro operator -(Euro euro, Pesos pesos)
        {
            return (Euro)(euro - ((Euro)pesos));
        }
    }
}
