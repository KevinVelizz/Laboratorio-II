/*
Consigna
Crear un proyecto de tipo biblioteca de clases que contenga la clase Producto.

1. Todos sus atributos son privados.
2. Posee sólo un constructor de instancia.
3. El método GetMarca, retornará el valor correspondiente al atributo marca.
4. También poseerá el atributo codigoDeBarras, el cual se publicará sólo a través
de la conversión explícita nombrada más adelante.
5. El método de clase (estático) MostrarProducto es público y retornará una
cadena detallando los atributos de la clase.
6. Posee las siguientes sobrecargas de operadores:
1. explicit: Realizará la conversión de un objeto Producto a string. Sólo
retornará el atributo codigoDeBarras del producto.
2. == (Producto, Producto): Retornará true si las marcas y códigos de
barra son iguales, false caso contrario.
3. == (Producto, string): Retornará true si la marca del producto coincide
con la cadena pasada como argumento, false caso contrario.

Generar la clase Estante.

1. Posee dos atributos privados. Uno será un entero que indicará la ubicación del
estante y el otro es un array de tipo Producto.
2. El constructor de instancia privado será el único que incializará el array. La
sobrecarga pública del constructor inicializará la ubicación del estante,
recibiendo como parámetros la capacidad y la ubicación. Reutilizar código.
3. El método público GetProductos, retornará el array de productos.
4. El método público de clase (estático) MostrarEstante, retornará una cadena con
toda la información del estante incluyendo el detalle de cada uno de sus
productos. Reutilizar código.
5. Posee las siguientes sobrecargas de operadores:
1. ==: Retornará true si es que el producto ya se encuentra en el estante,
false caso contrario.
2. +: Retornará true y agregará el producto si el estante posee capacidad de
almacenar al menos un producto más y dicho producto no se encuentra
en el estante, false caso contrario. Reutilizar código.
3. -: Retornará un estante sin el producto, siempre y cuando el producto se
encuentre en el listado. Reutilizar código.
*/



using Entidades;
internal class Program
{
    private static void Main(string[] args)
    {
    
        Producto p1 = new Producto("Pepsi", "PESDS97413", (float)18.5);
        Producto p2 = new Producto("Coca-Cola", "COSDS55752", (float)11.5);
        Producto p3 = new Producto("Manaos", "MASDS51292", (float)20.5);

        Producto p4 = new Producto("Crush", "CRSDS54861", (float)10.75);

        Estante estante = new Estante(3, 1,new Producto[]{p1,p2});

        if (estante + p3)
        {
            Console.WriteLine("Agregó {0} {1} {2}", p1.GetMarca(), (string)p1,
            p1.GetPrecio());
        }

    }
}