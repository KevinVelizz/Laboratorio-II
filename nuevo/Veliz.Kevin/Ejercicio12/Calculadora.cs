using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    internal class Calculadora
    {
        public static double Calcular(float num1, float num2, char operador)
        {
            double resultado = 0;

            switch (operador)
            {
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                case '/':

                    if (Validar(num2))
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir por 0.");
                    }
                    break;
                default:
                    Console.WriteLine("Error operador ingresado.");
                    break;

            }

            return resultado;
        }


        private static bool Validar(float num2)
        {
            return num2 != 0;
        }

    }
}
