using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    internal class Factorial
    {
        public static ulong Calcular(uint num_ingresado)
        {
            ulong factorial = 1;

            for (uint i = 1; i <= num_ingresado; i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }
    }
}
