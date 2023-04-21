namespace Billetes
{
    public class Pesos
    {
        double cantidad;
        double cotzRespectoDolar;

        public Pesos()
        {
            this.cantidad = 0;
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

        public double GetCotzRespectoDolar()
        {
            return this.cotzRespectoDolar;
        }

        public static implicit operator Pesos(double dolar)
        {
            return new Pesos(dolar);
        }


        public static explicit operator Euro(Pesos pesos)
        {
            return new Euro(pesos.GetCantidad() / 1.17);
        }

        public static explicit operator Dolar(Pesos pesos)
        {
            return new Dolar(pesos.GetCantidad() / pesos.GetCotzRespectoDolar());
        }

        public static bool operator ==(Pesos pesos, Pesos pesos1)
        {
            return pesos.GetCantidad() == pesos1.GetCantidad();
        }

        public static bool operator !=(Pesos pesos, Pesos pesos1)
        {
            return !(pesos.GetCantidad() == pesos1.GetCantidad());
        }

        public static bool operator ==(Pesos pesos, Euro euro)
        {
            return pesos.cantidad == euro.GetCantidad();
        }

        public static bool operator !=(Pesos pesos, Euro euro)
        {
            return !(pesos == euro);
        }

        public static bool operator ==(Pesos pesos, Dolar dolar)
        {
            return pesos.cantidad == dolar.GetCantidad();
        }

        public static bool operator !=(Pesos pesos, Dolar dolar)
        {
            return !(pesos == dolar);
        }

        public static Dolar operator -(Pesos pesos, Euro euro)
        {
            return pesos.cantidad - euro.GetCantidad();
        }

        public static Dolar operator -(Pesos pesos, Dolar dolar)
        {
            return pesos.cantidad - dolar.GetCantidad();
        }

        public static Dolar operator +(Pesos pesos, Euro euro)
        {
            return pesos.cantidad + euro.GetCantidad();
        }

        public static Dolar operator +(Pesos pesos, Dolar dolar)
        {
            return pesos.cantidad + dolar.GetCantidad();
        }
    }
}