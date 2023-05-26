using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Biblioteca
    {
        int codigoJuego;
        string genero;
        string juego;
        string usuario;

        public Biblioteca(int codigoJuego, string genero, string juego, string usuario)
        {
            this.codigoJuego = codigoJuego;
            this.genero = genero;
            this.juego = juego;
            this.usuario = usuario;
        }

        public int CodigoJuego { get { return this.codigoJuego; } }
        public string Genero { get { return this.genero; } }
        public string Juego { get { return this.juego; } }
        public string Usuario { get { return this.usuario; } }

    }
}
