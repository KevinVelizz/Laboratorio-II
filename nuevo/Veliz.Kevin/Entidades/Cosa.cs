using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cosa
    {
        int numero;
        string cadena;
        DateTime fecha;

         public Cosa()
        {
            this.numero = 10;
            this.cadena = "sin valor";
            this.fecha = DateTime.Now;
        }

        public Cosa(string cadena) : this()
        {
            this.cadena = cadena;
        }

        public Cosa(int numero, string cadena) : this(cadena)
        {
            this.numero = numero;
        }

        public Cosa(DateTime fecha, int numero, string cadena) : this(numero, cadena)
        {
            this.fecha = fecha;
        }

        public void EstablecerValor(int numero)
        {
            this.numero = numero;
        }

        public void EstablecerValor(string cadena)
        {
            this.cadena = cadena;
        }

        public void EstablecerValor(DateTime fecha)
        {
            this.fecha = fecha;
        }

        private string Mostrar()
        {
            return $"{this.numero} | {this.cadena} | {this.fecha.ToLongDateString()}";
        }

        public static string Mostrar(Cosa cosa)
        {
            return cosa.Mostrar();
        }

    }
}
