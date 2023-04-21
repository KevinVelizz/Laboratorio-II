using Ejercicio13;

internal class Program
{
    private static void Main(string[] args)
    {

        uint num_ingresado;
        ulong resultado;

        Console.WriteLine("Ingrese un numero: ");
        num_ingresado = uint.Parse(Console.ReadLine());

        if (num_ingresado > 0)
        {

            resultado = Factorial.Calcular(num_ingresado);

            Console.WriteLine($"El factorial de {num_ingresado} es: {resultado}");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("Error");
        }


    }
}