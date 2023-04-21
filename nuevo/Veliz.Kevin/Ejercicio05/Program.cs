/*Un centro numérico es un número que separa una lista de números enteros
(comenzando en 1) en dos grupos de números, cuyas sumas son iguales.
El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: (1; 2; 3;
4; 5) y (7; 8) cuyas sumas son ambas iguales a 15. El segundo centro numérico es el
35, el cual separa la lista (1 a 49) en los grupos: (1 a 34) y (36 a 49) cuyas sumas son
ambas iguales a 595.
Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el
número que el usuario ingrese por consola.
Nota: Utilizar estructuras repetitivas y selectivas.
*/

internal class Program
{
    private static void Main(string[] args)
    {

        int i;
        int centro_num;
        int num_ingresado;
        int suma_ant;
        int suma_post;

        Console.WriteLine("Ingrese un numero: ");
        num_ingresado = int.Parse(Console.ReadLine());

        for (i = 1; i < num_ingresado; i++)
        {
            suma_ant = 0;
            suma_post = 0;

            for (int j = 0; j < i; j++)
            {
                suma_ant += j;
            }

            for (int k = i + 1; k < num_ingresado; k++)
            {
                suma_post += k;

                if (suma_ant == suma_post)
                {
                    Console.WriteLine(i);
                }

                if (suma_post > suma_ant)
                {
                    break;
                }
            }
        }
    }
}