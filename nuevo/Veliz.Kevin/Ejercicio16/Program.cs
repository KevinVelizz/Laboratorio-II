using Ejercicio16;

internal class Program
{
    private static void Main(string[] args)
    {

        double base_triangulo;
        double altura_triangulo;
        double hipotenusa;

        Console.WriteLine("ingrese la base del triangulo: ");

        base_triangulo = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la altura del triangulo: ");

        altura_triangulo = double.Parse(Console.ReadLine());

        hipotenusa = Pitagoras.CalcularHipotenusa(base_triangulo, altura_triangulo);

        Console.WriteLine($"La hipotenusa es: {hipotenusa}");

        Console.ReadKey();
    }
}