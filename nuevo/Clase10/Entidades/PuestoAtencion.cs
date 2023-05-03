using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Entidades;

namespace Entidades
{
    public class PuestoAtencion
    {
        static int _numeroActual;
        Puesto _puesto;

        public static int NumeroActual
        {
            get 
            {
                PuestoAtencion._numeroActual++;
                return PuestoAtencion._numeroActual;
            }
        }

        static PuestoAtencion()
        {
            PuestoAtencion._numeroActual = 0;
        }
        public PuestoAtencion(Puesto puesto) => this._puesto = puesto;

        public bool Atender(Cliente cliente)
        {
            // Simulamos un tiempo de atención de 1 segundo
            Thread.Sleep(10000);

            return true;
        }



    }
}
