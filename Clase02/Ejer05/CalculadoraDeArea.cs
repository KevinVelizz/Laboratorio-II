using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    internal class CalculadoraDeArea
    {

        public static double CalcularAreaCuadrado (double longitudLado)
        {
         
            double area_cuadrado = 0;
            area_cuadrado = Math.Pow(longitudLado, 2);

            return area_cuadrado;

        }

        public static double CalcularAreaTriangulo(double longitudBase, double longitudAltura)
        {
            double area_triangulo = 0;
            
            area_triangulo = longitudBase * longitudAltura / 2;

            return area_triangulo;
        }

        public static double CalcularAreaCirculo (double radio)
        {
            double area_circulo = 0;

            area_circulo = Math.PI * Math.Pow(radio, 2);

            return area_circulo;

        }

    }
}
