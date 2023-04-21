/*
Ejercicio I04 - Invento argentino

Consigna
En un proyecto de biblioteca de clases, crear la clase Boligrafo a partir del siguiente
diagrama:

● La cantidad máxima de tinta para todos los bolígrafos será de 100. Generar una
constante cantidadTintaMaxima en Boligrafo donde se guardará dicho valor.
● Generar los métodos getter GetColor y GetTinta para los correspondientes
atributos (sólo retornarán el valor de los mismos).

● Generar un método setter privado SetTinta que valide el nivel de tinta y, si es
válido, modifique el valor del atributo tinta.
○ El argumento tinta contedrá la cantidad de tinta a agregar o quitar. Podrá
ser positivo (cargar tinta) o negativo (gastar tinta).
○ Se deberá validar que el nivel de tinta resultante sea mayor o igual a cero
y menor o igual a cantidadTintaMaxima. Si no es válido, no se deberá
modificar el atributo ni realizar ninguna acción.

● El método Recargar colocará la tinta en su nivel máximo. Reutilizar código.
● El método Pintar restará la tinta gastada (reutilizar código). El parámetro gasto
representará la cantidad de unidades de tinta a utilizar y utilizará tanta tinta como
tenga disponible sin quedar en negativo. Utilizando el parámetro dibujo
informará el resultado retornando tantos * como unidades de tinta haya gastado,
por ejemplo:
○ Si no había nada de tinta retornará una cadena de texto vacía.
○ Si el nivel de tinta era 10 y la cantidad a gastar 2, entonces retonará **.
○ Si el nivel de tinta era 3 y la cantidad a gastar 10, entonces retornará ***.
1. Agregar un proyecto de consola.
2. En el método Main, crear un bolígrafo de tinta azul (ConsoleColor.Blue) y una
cantidad inicial de tinta de 100 y otro de tinta roja (ConsoleColor.Red) y 50 de
tinta.
3. Utilizar todos los métodos y mostrar los resultados por consola.
4. Al utilizar el método Pintar, si corresponde, se deberá dibujar por pantalla con el
color de dicho bolígrafo.

*/

using Entidades;

internal class Program
{
    private static void Main(string[] args)
    {
        Boligrafo boligrafo = new Boligrafo(5,ConsoleColor.Blue);
        Boligrafo boligrafo1 = new Boligrafo(50, ConsoleColor.Red);

        Console.WriteLine("Bolígrafo azul");
        Console.WriteLine($"Color: {boligrafo.GetColor()}");
        Console.WriteLine($"Nivel de tinta: {boligrafo.GetTinta()}");

        Console.WriteLine("\nDibujo:");
        boligrafo.Pintar(110, out string dibujo);
        Console.WriteLine($"{dibujo}\n");
        Console.ResetColor();

        Console.WriteLine($"Nivel de tinta después de pintar: {boligrafo.GetTinta()}");
        boligrafo.Recargar();
        Console.WriteLine($"Nivel de tinta después de recargar: {boligrafo.GetTinta()}");


        Console.WriteLine("\nBolígrafo Rojo");
        Console.WriteLine($"Color: {boligrafo1.GetColor()}");
        Console.WriteLine($"Nivel de tinta: {boligrafo1.GetTinta()}");
        

        Console.WriteLine("\nDibujo:");
        boligrafo1.Pintar(10, out string dibujo1);
        Console.WriteLine($"{dibujo1}\n");
        Console.ResetColor();

        Console.WriteLine($"Nivel de tinta después de pintar: {boligrafo1.GetTinta()}");
        boligrafo1.Recargar();
        Console.WriteLine($"Nivel de tinta después de recargar: {boligrafo1.GetTinta()}");
    }
}