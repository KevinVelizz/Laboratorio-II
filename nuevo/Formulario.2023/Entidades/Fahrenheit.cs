using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Fahrenheit
    {
        double grados;
        double valorKelvin;

        public Fahrenheit()
        {
            this.valorKelvin = 0;
        }

        public Fahrenheit(double grados) :this()
        {
            this.grados = grados;
        }

        public Fahrenheit(double grados, double valorKelvin) : this(grados)
        {
            this.valorKelvin = valorKelvin;
        }

        public static implicit operator Fahrenheit(double grados)
        {
            return new Fahrenheit(grados);
        }

        public static explicit operator Celsius(Fahrenheit fahrenheit)
        {
            double valor;
            valor = (fahrenheit.grados - 32) * 5 / 9;
            return (Celsius)valor;
        }

        public static explicit operator Kelvin(Fahrenheit fahrenheit)
        {
            double valor;
            valor = ((Celsius)fahrenheit.grados).GetCelsius() + 273.15;
            return (Kelvin)valor;
        }
    }
}
