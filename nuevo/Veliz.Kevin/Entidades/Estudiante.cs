using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estudiante
    {
        string nombre;
        string apellido;
        int legajo;
        int notaPrimerParcial;
        int notaSegundoParcial;
        static Random random;


        static Estudiante()
        {
            random = new Random();
        }

        public Estudiante(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public void SetNotaPrimerParcial(int notaPrimerParcial)
        {
            this.notaPrimerParcial = notaPrimerParcial;
        }

        public void SetNotaSegundoParcial(int notaSegundoParcial)
        {
            this.notaSegundoParcial = notaSegundoParcial;
        }

        int CalcularPromedio()
        {
            int promedio = (this.notaPrimerParcial + this.notaSegundoParcial) / 2;

            return promedio;
        }

        int CalcularNotaFinal()
        {
            int retorno = -1;

            if (CalcularPromedio() > 3)
            {
                retorno = random.Next(6, 10);
            }
            return retorno;
        }

        public string mostrar()
        {
            StringBuilder mensaje = new StringBuilder();

            mensaje.AppendLine($"nombre: {this.nombre}");
            mensaje.AppendLine($"apellido: {this.apellido}");
            mensaje.AppendLine($"legajo: {this.legajo}");
            mensaje.AppendLine($"Nota 1er Parcial: {this.notaPrimerParcial}");
            mensaje.AppendLine($"Nota 2do Parcial: {this.notaSegundoParcial}");
            mensaje.AppendLine($"Promedio: {CalcularPromedio()}");

            if (CalcularNotaFinal() != -1)
            {
                mensaje.Append($"Nota Final: {CalcularNotaFinal()}");
            }
            else
            {
                mensaje.Append("Alumno Desaprobado.");
            }

            return mensaje.ToString();
        }
    }
}
