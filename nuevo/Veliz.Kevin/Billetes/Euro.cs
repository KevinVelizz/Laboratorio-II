using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        double cantidad;
        static double cotzRespectoDolar;

        public Euro()
        {
            this.cantidad = 0;
            Euro.cotzRespectoDolar = 1.17;
        }

        public Euro(double cantidad) :this()
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotzRespectoDolar) :this(cantidad)
        {
            Euro.cotzRespectoDolar = cotzRespectoDolar;
        }

        public double GetCantidad() 
        {
            return this.cantidad;
        }

        public static double GetCotzRespectoDolar() 
        {
            return Euro.cotzRespectoDolar;
        }

        public static implicit operator Euro(double euro)
        {
            return new Euro(euro);
        }

        public static explicit operator Dolar(Euro euro)
        {
            return (Dolar)(euro.cantidad * Euro.GetCotzRespectoDolar());
        }

        public static explicit operator Pesos(Euro euro)
        {
            return (Pesos)(euro.cantidad * 120.10);
        }

        public static bool operator ==(Euro euro, Euro euro1)
        {
            return euro.cantidad == euro1.cantidad;
        }

        public static bool operator !=(Euro euro, Euro euro1)
        {
            return !(euro == euro1);
        }

        public static bool operator ==(Euro euro, Dolar dolar)
        {
            return euro.cantidad == dolar.GetCantidad();
        }

        public static bool operator !=(Euro euro, Dolar dolar)
        {
            return !(euro == dolar);
        }

        public static bool operator ==(Euro euro, Pesos pesos)
        {
            return euro.cantidad == pesos.GetCantidad();
        }

        public static bool operator !=(Euro euro, Pesos pesos)
        {
            return !(euro == pesos);
        }

        public static Euro operator -(Euro euro, Dolar dolar)
        {
            return euro.cantidad - dolar.GetCantidad();
        }

        public static Euro operator -(Euro euro, Pesos pesos)
        {
            return euro.cantidad - pesos.GetCantidad();
        }

        public static Euro operator +(Euro euro, Dolar dolar)
        {
            return euro.cantidad + dolar.GetCantidad();
        }

        public static Euro operator +(Euro euro, Pesos pesos)
        {
            return euro.cantidad + pesos.GetCantidad();
        }

    }
}
