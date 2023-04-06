using Ejercicio05;

internal class Program
{
    private static void Main(string[] args)
    {

        double longitud_cuadrado;
        double base_triangulo;
        double altura_triangulo;
        double radio_circulo;
        string operacion = "";

        double resultado;

        Console.WriteLine("Ingrese 'c' area cuadrado, 't' area triangulo, 'r' area circulo");
       
       operacion = Console.ReadLine();

        switch (operacion)
        {
            case "c":
                Console.WriteLine("Ingrese la longitud: ");
                longitud_cuadrado = double.Parse(Console.ReadLine());

                resultado = CalculadoraDeArea.CalcularAreaCuadrado(longitud_cuadrado);

                Console.WriteLine($"El area del cuadrado es: {resultado}");

                break;

            case "t":
                Console.WriteLine("Ingrese la base: ");
                base_triangulo = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la altura: ");
                altura_triangulo = double.Parse(Console.ReadLine());

                resultado = CalculadoraDeArea.CalcularAreaTriangulo(base_triangulo, altura_triangulo);

                Console.WriteLine($"El area del triangulo es: {resultado}");
                break;

            case "r":
                Console.WriteLine("Ingrese el radio: ");
                radio_circulo = double.Parse(Console.ReadLine());

                resultado = CalculadoraDeArea.CalcularAreaCirculo(radio_circulo);

                Console.WriteLine($"El area del circulo es: {resultado}");

                break;
            default:
                Console.WriteLine("Error opción ingresada.");
                break;
        }
        Console.ReadKey();
    }
}