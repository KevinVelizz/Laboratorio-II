using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Conductor
    {
        string nombre;
        int[] kilometrosRecorridos = new int [7];

        public Conductor(string nombre, int[] kilometrosRecorridos) 
        { 
            this.nombre = nombre;
            this.kilometrosRecorridos = kilometrosRecorridos;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public int[] GetKilometrosRecorridos()
        {
            return kilometrosRecorridos;
        }
        
        public int CalcularKmTotales()
        {
            int acumulador = 0;
            for (int i = 0; i < kilometrosRecorridos.Length; i++)
            {
               acumulador += kilometrosRecorridos[i];
            }
            return acumulador;
        }

        public bool EsMayor(Conductor[] conductores)
        {
           
            bool esMayorr = true;

            foreach (var conductor in conductores)
            {
                if (this.CalcularKmTotales() < conductor.CalcularKmTotales() && this.nombre != conductor.GetNombre())
                {
                    esMayorr = false;
                    break;
                }
            }
            return esMayorr;
        }
        private int GetKmDia(int dia)
        {
            return this.kilometrosRecorridos[dia - 1];

        }

        public bool EsMayorDeterminadoDia(int dia, Conductor[] conductores)
        {
            bool esMayor = true;

            foreach (var conductor in conductores)
            {
                if (this.GetKmDia(dia) < conductor.GetKmDia(dia) && this.nombre != conductor.GetNombre())
                {
                    esMayor = false;
                    break;
                }
            }
            return esMayor;
        }
    }
}
