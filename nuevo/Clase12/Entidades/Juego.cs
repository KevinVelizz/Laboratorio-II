using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Juego
    {
        int codigoJuego;
        int codigoUsuario;
        string? genero;
        string? nombre;
        double precio;

        public Juego(string nombre, double precio, string genero, int codigoUsuario)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.genero = genero;
            this.codigoUsuario = codigoUsuario;
        }

        public Juego(string nombre, double precio, string genero, int codigoJuego, int codigoUsuario) : this(nombre, precio, genero, codigoUsuario)
        {
            this.codigoJuego = codigoJuego;
        }

        public int CodigoJuego
        {
            get { return this.codigoJuego; }
        }

        public int CodigoUsuario
        {
            get { return this.codigoUsuario; }
        }

        public string Genero
        {
            get { return this.genero ?? ""; }
        }

        public string Nombre
        {
            get { return this.nombre ?? ""; }
        }

        public double Precio
        {
            get { return this.precio; }
        }
    }
}
