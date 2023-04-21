using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sumador
    {
        int cantidadSumas;

        public Sumador() 
        {
            this.cantidadSumas = 0;
        }

        public Sumador(int cantidadSumas) :this()
        {
            this.cantidadSumas = cantidadSumas;
        }


        public long Sumar(long num1, long num2)
        {
            this.cantidadSumas++;
            return num1 + num2;
        }

        public string Sumar(string num1, string num2)
        {
            this.cantidadSumas++;
            return num1 + num2;
        }

        public static long operator +(Sumador sumador1, Sumador sumador2)
        {
            return sumador1 + sumador2;
        }

        public static bool operator |(Sumador sumador1, Sumador sumador2)
        {
            return sumador1.cantidadSumas == sumador2.cantidadSumas;
        }

        public static explicit operator int(Sumador sumador)
        {
            return sumador.cantidadSumas;
        }


    }
}
