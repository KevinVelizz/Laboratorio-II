﻿
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int n = 2;

        Console.WriteLine("Ingrese un numero: ");
        int numero_ingresado = Int32.Parse(Console.ReadLine()); 

        while (n <= numero_ingresado)
        {
        
            bool esPrimo = true;

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    esPrimo = false;
                    break;
                }
            }
            if (esPrimo)
            {
                Console.WriteLine(n);
            }
            n++;
        }

        Console.ReadKey();
    }
}