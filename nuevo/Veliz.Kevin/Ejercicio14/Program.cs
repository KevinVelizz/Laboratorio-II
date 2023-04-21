using Ejercicio14;

internal class Program
{
    private static void Main(string[] args)
    {
        string resultado;
        int num_ingresado;

        Console.WriteLine("Ingrese un número: ");
        num_ingresado = Int32.Parse(Console.ReadLine());

        resultado = Tabla.Multiplicar(num_ingresado);

        Console.WriteLine(resultado);

        Console.ReadKey();
    }
}