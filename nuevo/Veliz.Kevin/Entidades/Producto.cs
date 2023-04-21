using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        string codigoDeBarra;
        string marca;
        float precio;

        public Producto(string marca, string codigoDeBarra, float precio)
        {
            this.marca = marca;
            this.codigoDeBarra = codigoDeBarra;
            this.precio = precio;
        }

        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        public static explicit operator string(Producto producto)
        {
            return producto.codigoDeBarra;
        }

        public static string MostrarProducto(Producto producto)
        {
            return $"Codigo de barra: {producto.codigoDeBarra}\nMarca: {producto.GetMarca()}\n Precio: {producto.GetPrecio()}";
        }


        public static bool operator ==(Producto producto, Producto producto1)
        {
            return producto.marca == producto1.marca && producto.codigoDeBarra == producto1.codigoDeBarra;
        }  

        public static bool operator !=(Producto producto, Producto producto1)
        {
            return !(producto == producto1);
        }

        public static bool operator ==(Producto producto, string marca)
        {
            return producto.marca == marca;
        }

        public static bool operator !=(Producto producto, string marca)
        {
            return !(producto.marca == marca);
        }

    }


}
