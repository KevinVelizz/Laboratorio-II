/*
Consigna
Crear una aplicación de consola que cargue 20 números enteros (positivos y negativos)
distintos de cero de forma aleatoria utilizando la clase Random.
1. Mostrar el vector tal como fue ingresado.
2. Luego mostrar los positivos ordenados en forma decreciente.
3. Por último, mostrar los negativos ordenados en forma creciente.
*/


internal class Program
{
    private static void Main(string[] args)
    {
        /*
        int[] numeros = new int[20];
        Random random = new Random();

        for (int i = 0; i < numeros.Length; i++)
        {
            int numeroRandom = 0;
            do
            {
                numeroRandom = random.Next(-100, 100);

            } while (numeroRandom == 0);

            numeros[i] = numeroRandom;
        }
        
        int[] positivos = Array.FindAll(numeros, n => n > 0);
        Array.Sort(positivos);
        Array.Reverse(positivos);

        foreach (int positivo in positivos)
        {
            Console.WriteLine(positivo);
        }

        int[] negativos = Array.FindAll(numeros, n => n < 0);
        Array.Sort(negativos);

        foreach (int negativo in negativos)
        {
            Console.WriteLine(negativo);
        }
        */

        List<int> numeros1 = new List<int>();
        Random random1 = new Random();

        for (int i = 0; i < 20; i++)
        {
            int numeroRandom1 = 0;
            
            do
            {
                numeroRandom1 = random1.Next(-100,100);
                numeros1.Add(numeroRandom1);

            }while(numeroRandom1 == 0);
        }

        List<int> positivos = numeros1.FindAll(n => n > 0);
        positivos.Sort();
        positivos.Reverse();

        Console.WriteLine("Numeros Positivos: ");
        foreach (int i in positivos)
        {
            Console.WriteLine(i);
            
        }

        List<int> negativos = numeros1.FindAll(n => n < 0);
        negativos.Sort();
        Console.WriteLine("Numeros negativos: ");
        foreach (int i in negativos)
        {
            Console.WriteLine(i);
        }
    } 
}