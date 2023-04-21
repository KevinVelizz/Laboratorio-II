using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Celsius
    {
        double grados;
        double valorKelvin;
        

        public Celsius() 
        {
            this.valorKelvin = 273.15;
        }

        public Celsius(double grados) :this() 
        {
            this.grados = grados;
        }

        public Celsius(double grados, double valorKelvin) : this(grados)
        {
            this.valorKelvin = valorKelvin;
        }

        public double GetCelsius()
        {
            return this.grados;
        }

        public static implicit operator Celsius(double grados)
        {
            return new Celsius(grados);
        }

        public static explicit operator Fahrenheit(Celsius celsius)
        {
            double valor;
            valor = (celsius.GetCelsius() * 9 / 5) + 32;
            return (Fahrenheit)valor;
        } 

        public static explicit operator Kelvin(Celsius celsius)
        {
            double valor;
            valor = celsius.GetCelsius() + 273.15;
            return (Kelvin)valor;
        }
    }
}
