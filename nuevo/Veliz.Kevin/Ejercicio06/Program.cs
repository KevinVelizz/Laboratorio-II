﻿/*Escribir un programa que determine si un año es bisiesto.
Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos,
salvo si ellos también son múltiplos de 400. Por ejemplo: el año 2000 es bisiesto
pero 1900 no.
Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en
ese rango.
Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).
*/

internal class Program
{
    private static void Main(string[] args)
    {
        int año_inicio;
        int año_fin;

        Console.WriteLine("Ingrese año inicio: ");
        año_inicio = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese año fin: ");
        año_fin = int.Parse(Console.ReadLine());

        while (año_inicio <= año_fin)
        {
            if (año_inicio % 4 == 0)
            {
                if (!(año_inicio % 100 == 0) || año_inicio % 400 == 0)
                {
                    Console.WriteLine(año_inicio);
                }
            }
            año_inicio++;
        }
    }
}