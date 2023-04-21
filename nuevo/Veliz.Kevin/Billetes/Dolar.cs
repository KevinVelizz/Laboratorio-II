using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        double cantidad;
        double cotzRespectoDolar;

        public Dolar()
        {
            this.cantidad = 0;
            this.cotzRespectoDolar = 1;
        }

        public Dolar(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, double cotzRespectoDolar) : this(cantidad)
        {
            this.cotzRespectoDolar = cotzRespectoDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public double GetCotzRespectoDolar()
        {
            return this.cotzRespectoDolar;
        }

        public static implicit operator Dolar(double dolar)
        {
            return new Dolar(dolar);
        }


        public static explicit operator Euro(Dolar dolar)
        {
            return new Euro(dolar.cantidad * 1.17);
        }

        public static explicit operator Pesos(Dolar dolar)
        {
            return new Pesos(dolar.cantidad * 120.10);
        }

        public static bool operator ==(Dolar dolar, Dolar dolar1)
        {
            return dolar.cantidad == dolar1.cantidad;
        }

        public static bool operator !=(Dolar dolar, Dolar dolar1)
        {
            return !(dolar.cantidad == dolar1.cantidad);
        }

        public static bool operator ==(Dolar dolar, Euro euro)
        {
            return dolar.cantidad == euro.GetCantidad();
        }

        public static bool operator !=(Dolar dolar, Euro euro)
        {
            return !(dolar.cantidad == euro.GetCantidad());
        }

        public static bool operator ==(Dolar dolar, Pesos pesos)
        {
            return dolar.cantidad == pesos.GetCantidad();
        }

        public static bool operator !=(Dolar dolar, Pesos pesos)
        {
            return !(dolar.cantidad == pesos.GetCantidad());
        }

        public static Dolar operator -(Dolar dolar, Euro euro)
        {
            return dolar.cantidad - euro.GetCantidad();
        }

        public static Dolar operator -(Dolar dolar, Pesos pesos)
        {
            return dolar.cantidad - pesos.GetCantidad();
        }

        public static Dolar operator +(Dolar dolar, Euro euro)
        {
            return dolar.cantidad + euro.GetCantidad();
        }

        public static Dolar operator +(Dolar dolar, Pesos pesos)
        {
            return (Dolar)(dolar.cantidad + pesos.GetCantidad());
        }

    }
}
