using Ejercicio12;
internal class Program
{
    private static void Main(string[] args)
    {

        float num1;
        float num2;
        char caracter;
        double resultado;

        while (true)
        {
            Console.WriteLine("Ingrese el 1er operando: ");
            num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el 2do operando: ");
            num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la operación matemática: ");
            caracter = char.Parse(Console.ReadLine());

            resultado = Calculadora.Calcular(num1, num2, caracter);

            Console.WriteLine($"El resultado es {resultado}");


            Console.ReadKey();
        }

    }
}