using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Kelvin
    {
        double grados;
        double valorKelvin;


        public Kelvin()
        {
            valorKelvin = 0;
        }

        public Kelvin(double grados) : this()
        {
            this.grados = grados;
        }

        public Kelvin(double grados, double valorKelvin) :this()
        {
            this.valorKelvin = valorKelvin;
        }

        public static implicit operator Kelvin(double grados)
        {
            return new Kelvin(grados);
        }

        public static explicit operator Celsius(Kelvin kelvin)
        {
            double valor;
            valor = kelvin.grados - 273.15;
            return (Celsius)valor;
        }

        public static explicit operator Fahrenheit(Kelvin kelvin)
        {
            double valor;
            valor = (Fahrenheit)(((Celsius)(kelvin.grados)).GetCelsius());
            return (Celsius)valor;
        }
    }
}
