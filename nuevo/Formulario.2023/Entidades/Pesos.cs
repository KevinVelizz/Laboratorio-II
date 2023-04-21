using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pesos
    {
        double cantidad;
        double cotzRespectoDolar;


        public Pesos()
        {
            this.cotzRespectoDolar = 102.65;
        }

        public Pesos(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, double cotzRespectoDolar) : this(cantidad)
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

        public static implicit operator Pesos(double pesos)
        {
            return new Pesos(pesos);
        }

        public static explicit operator Dolar(Pesos pesos)
        {
            double dolar;
            dolar = pesos.GetCantidad() / pesos.GetCotizacion();

            return (Dolar)dolar;
        }

        public static explicit operator Euro(Pesos pesos)
        {
            return (Euro)((Dolar)pesos);
        }

        public static bool operator ==(Pesos pesos1, Pesos pesos2)
        {
            return pesos1.cantidad == pesos2.cantidad;
        }

        public static bool operator !=(Pesos pesos1, Pesos pesos2)
        {
            return !(pesos1 == pesos2);
        }

        public static bool operator ==(Pesos pesos, Dolar dolar)
        {
            Pesos pesos1 = (Pesos)dolar;
            return pesos == pesos1;
        }

        public static bool operator !=(Pesos pesos, Dolar dolar)
        {
            return !(pesos == dolar);
        }

        public static bool operator ==(Pesos pesos, Euro euro)
        {
            Pesos pesos1 = (Pesos)euro;
            return pesos == pesos1;
        }

        public static bool operator !=(Pesos pesos, Euro euro)
        {
            return !(pesos == euro);
        }

        public static Pesos operator +(Pesos pesos1, Pesos pesos2)
        {
            return (Pesos)(pesos1.cantidad + pesos2.cantidad);
        }

        public static Pesos operator +(Pesos pesos, Dolar dolar)
        {
            return (Pesos)(pesos + ((Pesos)dolar));
        }

        public static Pesos operator +(Pesos pesos, Euro euro)
        {
            return (Pesos)(pesos + ((Pesos)euro));
        }

        public static Pesos operator -(Pesos pesos1, Pesos pesos2)
        {
            return (Pesos)(pesos1.cantidad - pesos2.cantidad);
        }

        public static Pesos operator -(Pesos pesos, Dolar dolar)
        {
            return (Pesos)(pesos - (Pesos)dolar);
        }

        public static Pesos operator -(Pesos pesos, Euro euro)
        {
            return (Pesos)(pesos - (Pesos)euro);
        }
    }
}
