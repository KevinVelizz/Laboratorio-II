using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    internal class Pitagoras
    {
        public static double CalcularHipotenusa(double base_triangulo, double altura_triangulo)
        {
            double hipotenusa;

            hipotenusa = Math.Sqrt(Math.Pow(base_triangulo, 2) + Math.Pow(altura_triangulo, 2));

            return hipotenusa;
        }
    }
}
