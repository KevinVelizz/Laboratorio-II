using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estante
    {
        int ubicacionEstante;
        Producto[] productos;

        private Estante(int capacidad) 
        {
            this.productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacionEstante) :this(capacidad)
        {
            this.ubicacionEstante = ubicacionEstante;
        }

        public Estante(int capacidad, int ubicacionEstante, Producto[] productos) :this(capacidad,ubicacionEstante) 
        {
            for (int i = 0; i < productos.Length; i++)
            {
                this.productos[i] = productos[i];
            }
        }

        public Producto[] GetProductos()
        {
            return this.productos;
        }

        public static string MostrarEstante(Estante estante)
        {
            string EstantePrincipal = $"Ubicación: {estante.ubicacionEstante}";

            for (int i = 0; i < estante.productos.Length; i++)
            {
                if (estante.productos[i] is not null)
                {
                    EstantePrincipal += Producto.MostrarProducto(estante.productos[i]);
                }
                else
                {
                    EstantePrincipal += "Sin productos\n";
                }
            }
            return EstantePrincipal;
        }

        public static bool operator ==(Estante estante, Producto producto)
        {
            bool retorno = false;

            for (int i = 0;i < estante.productos.Length;i++)
            {
                if (estante.productos[i] is not null)
                {
                    if (producto == estante.productos[i])
                    {
                        retorno = true;
                    }
                }

            }
            return retorno;
        }

        public static bool operator !=(Estante estante, Producto producto)
        {
            return !(estante == producto);
        }

        public static bool operator +(Estante estante, Producto producto)
        {
            bool retorno = false;

            if(estante != producto)
            {
                for (int i = 0;i < estante.productos.Length;i++)
                {
                    if (estante.productos[i] is not null)
                    {
                        estante.productos[i] = producto;
                        retorno = true;
                    }
                }
            }
            return retorno;
        }
        public static Estante operator -(Estante estante, Producto producto)
        {

            if( estante == producto) 
            {
                for (int i = 0; i < estante.productos.Length;i++)
                {
                    if (estante.productos[i] == producto)
                    {
                        estante.productos = null;
                        break;
                    }
                }
            }
            return estante;
        }

    }
}
