using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DepositoDeAutos
    {
        private int _capacidadMaxima;
        private static List<Auto> _lista;
        
        public DepositoDeAutos(int _capacidadMaxima)
        {
            this._capacidadMaxima = _capacidadMaxima;
        }

        private static int GetIndice(int _capacidad)
        {
            if (DepositoDeAutos._lista.Count > 0)
            {
                foreach (Auto auto in DepositoDeAutos._lista)
                {
                    if (_capacidad == )
                }
            }
        }
    }
}
