/*
Ejercicio I01 - Sumador

Consigna
Crear un proyecto de tipo biblioteca de clases y agregar la clase Sumador.

1. Crear dos constructores:
1. Sumador(int) inicializa cantidadSumas en el valor recibido por parámetro.
2. Sumador() inicializa cantidadSumas en cero. Reutilizará al primer
constructor.

2. El método Sumar incrementará cantidadSumas en 1 y adicionará sus parámetros
con la siguiente lógica:
1. En el caso de Sumar(long, long) sumará los valores numéricos
2. En el de Sumar(string, string) concatenará las cadenas de texto.
Crear un proyecto de consola y agregar un objeto del tipo Sumador en el método Main y
probar el código.
Seguido:
1. Generar una conversión explícita que retorne cantidadSumas.
2. Sobrecargar el operador + (suma) con dos operadores de tipo Sumador. El
resultado será un long correspondiente al resultado de la suma del atributo
cantidadSumas de cada argumento.
3. Sobrecargar el operador | (pipe) con dos operadores de tipo Sumador. Deberá
retornar true si ambos sumadores tienen igual valor en el atributo
cantidadSumas.
Agregar un segundo objeto del tipo Sumador en el método Main y probar el código.
*/


using Entidades;

internal class Program
{
    private static void Main(string[] args)
    {
        Sumador sumador = new Sumador(5);
        Sumador sumador1 = new Sumador(5);

        int cantidadSumas = (int)sumador;
        int cantidadSumas1 = (int)sumador1;

        Console.WriteLine(sumador | sumador1); //True.
        sumador.Sumar(cantidadSumas,cantidadSumas1);

        Console.WriteLine(sumador | sumador1); // False debido al incremento de cantidadSumas.

        Console.WriteLine(sumador.Sumar(cantidadSumas, cantidadSumas1));
    }
}