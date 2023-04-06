using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase02
{
    internal class validador
    {
        public static bool Validar(int valor, int min = -100, int max = 100)
        {

            bool retorno = false;

            if(valor > min && valor < max)
            {
                retorno = true; 
            }
            return retorno;
        }
    }
}
