/*
Un número perfecto es un entero positivo, que es igual a la suma de todos los
enteros positivos (excluido 3 el mismo) que son divisores del número.
El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.

Escribir una aplicación que encuentre los 4 primeros números perfectos.
Nota: Utilizar estructuras repetitivas y selectivas.
*/

internal class Program
{
    private static void Main(string[] args)
    {
        int num = 2;
        int suma;
        int limite = 0;

        while (limite < 4)
        {
            suma = 0;

            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    suma += i;
                }
            }

            if (suma == num)
            {
                Console.WriteLine(num);
                limite++;
            }
            num++;
        }
    }
}