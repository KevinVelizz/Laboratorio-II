using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    internal class Tabla
    {
        public static string Multiplicar(int numero)
        {
            StringBuilder mensaje = new StringBuilder();
            int resultado;

            mensaje.Append($"Tabla de multiplicar del número {numero}");
            mensaje.AppendLine(": ");

            for (int i = 1; i <= 10; i++)
            {
                resultado = numero * i;
                mensaje.Append($"{numero} * {i}");
                mensaje.AppendLine($" = {resultado}");
            }
            return mensaje.ToString();
        }
    }
}
