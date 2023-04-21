using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        short cantidadDeJugadores;
        List<Jugador> jugadores;
        string nombre;


        private Equipo()
        {
            this.nombre = "";
            this.cantidadDeJugadores = 0;
            this.jugadores = new List<Jugador>();
        }

        public Equipo(short cantidadDeJugadores, string nombre) :this()
        {
            this.cantidadDeJugadores = cantidadDeJugadores;
            this.nombre = nombre;
        }

        public static bool operator +(Equipo equipo,Jugador jugador)
        {
            bool retorno = true;

            if (equipo.jugadores.Count <= equipo.cantidadDeJugadores)
            {
               
                foreach (Jugador jugador1 in equipo.jugadores)
                {
                    if(jugador1 == jugador)
                    {
                        retorno = false;
                    }
                }
                if(retorno)
                {
                    equipo.jugadores.Add(jugador);
                }

            }
            return retorno;
        }
    }
}
