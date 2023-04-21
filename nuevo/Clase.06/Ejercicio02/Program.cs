/*
Consigna
Crear una aplicación de consola que cargue en una Lista, Pila y Cola 20 números
enteros (positivos y negativos) distintos de cero de forma aleatoria utilizando la clase
Random.
1. Mostrar la colección tal como fue cargada.
2. Luego mostrar los positivos ordenados en forma decreciente.
3. Por último, mostrar los negativos ordenados en forma creciente.
*/


internal class Program
{
    private static void Main(string[] args)
    {

        Queue<int> numerosQueue = new Queue<int>(); 
        Stack<int> numerosStack = new Stack<int>();
        Random random = new Random();

        for (int i = 0; i < 20; i++)
        {
            int numeroRandom = 0;

            do
            {
                numeroRandom = random.Next(-100,100);

                numerosQueue.Enqueue(numeroRandom);
                numerosStack.Push(numeroRandom);

            } while (numeroRandom == 0);
        }

        Queue<int> positivosQueue = new Queue<int>(numerosQueue.Where(n => n > 0).OrderByDescending(n => n));
        Stack<int> positivosStack = new Stack<int>(numerosStack.Where(n => n > 0).OrderBy(n => n));

        Console.WriteLine("Positivos de manera decreciente tipo Cola");
        foreach (int i in positivosQueue)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("Positivos demanera decreciente tipo Pila");
        foreach (int i in positivosStack)
        {
            Console.WriteLine(i);
        }

        Queue<int> negativosQueue = new Queue<int>(numerosQueue.Where(n => n < 0).OrderBy(n => n));
        Stack<int> negativosStack = new Stack<int>(numerosStack.Where(n => n < 0).OrderByDescending(n => n));

        Console.WriteLine("Negativos de manera creciente tipo Cola");
        foreach (int i in negativosQueue)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("Negativos de manera creciente tipo Pila");
        foreach (int i in negativosStack)
        {
            Console.WriteLine(i);
        }

    }
}