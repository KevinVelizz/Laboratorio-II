internal class Program
{
    private static void Main(string[] args)
    {
        int i;
        int numero_mayor = 0;
        int numero_menor = 0;
        int numero;
        int acumulador = 0;
        int promedio;

        for (i = 0; i < 5; i++)
        {
            Console.WriteLine("Ingrese un numero: ");
            numero = Int32.Parse(Console.ReadLine()); 
           
            if (i == 0)
            {
                numero_mayor = numero;
                numero_menor = numero;
            }

            if (numero > numero_mayor)
            {
                numero_mayor = numero;
            }
            
            if (numero < numero_menor)
            {
                numero_menor = numero;
            }
            acumulador += numero;
        }
        promedio = acumulador / 5;

        Console.WriteLine($"El numero mayor es {numero_mayor}");
        Console.WriteLine($"El numero menor es {numero_menor}");
        Console.WriteLine($"El promedio es {promedio}");
        Console.ReadKey();
    }

}