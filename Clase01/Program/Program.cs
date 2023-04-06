
internal class Program
{
    private static void Main(string[] args)
    {

        int num;
        int num_mayor = 0;
        int num_menor = 0;
        int acumulador = 0;
        int i;
        int promedio;

        for (i = 0; i < 3; i++) 
        {
            Console.WriteLine("Ingrese un numero entre -100 y 100: ");
            num = Int32.Parse(Console.ReadLine());

            while (!(validador.Validar(num))) 
            {
                Console.WriteLine("Error, ingrese un numero entre -100 y 100: ");
                num = Int32.Parse(Console.ReadLine());
            }

            if(i == 0)
            {
                num_mayor = num;
                num_menor = num;
            }

            if(num > num_mayor)
            {
                num_mayor = num;
            }
            else
            {
                if(num < num_menor)
                {
                    num_menor = num;
                }
            }

            acumulador += num;
        }

        promedio = acumulador / i;

        Console.WriteLine($"El numero mayor ingresado es {num_mayor}.\n" +
            $"El numero menor ingresado es {num_menor}. \n" +
            $"El promedio es {promedio}");

        Console.ReadKey();
    }
}