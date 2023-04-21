using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        string nombre;
        DateTime fechaDeNacimiento;
        int dni;

        public Persona(string nombre, DateTime fechaDeNacimiento, int dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni; 
        }

        public string obtenerValorNombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
            
        }

        public DateTime obtenerValorFechaDeNacimiento
        {
            get
            {
                return this.fechaDeNacimiento;
            }
            set
            {
                this.fechaDeNacimiento = value;
            }

        }

        public int obtenerValorFechaDeDni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }

        }

        private int CalcularEdad()
        {
            
            int edad = DateTime.Today.Year - this.fechaDeNacimiento.Year;

            return edad;
        }

        public string Mostrar()
        {
            StringBuilder mensaje = new StringBuilder();

            mensaje.AppendLine(EsMayorDeEdad());
            mensaje.AppendLine($"Nombre: {this.nombre}");
            mensaje.AppendLine($"Edad: {CalcularEdad()}");
            mensaje.AppendLine($"DNI: {this.dni}");
            mensaje.AppendLine($"Fecha de Nacimiento: {this.fechaDeNacimiento}");

            return mensaje.ToString();
        }

        private string EsMayorDeEdad()
        {
            StringBuilder mensaje = new StringBuilder();
            if (CalcularEdad() > 17)
            {
                mensaje.Append("Es mayor de edad");
            }    
            else
            {
                mensaje.Append("Es menor de edad");
            }

            return mensaje.ToString();
        }

       
    }
}
