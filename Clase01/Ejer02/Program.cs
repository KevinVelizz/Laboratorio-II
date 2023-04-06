
internal class Program
{
    private static void Main(string[] args)
    {

        int numero;
        bool condicion = true;

        Console.WriteLine("Ingrese un numero: ");
        numero = Int32.Parse(Console.ReadLine());

        while (numero < 0)
        {
            Console.WriteLine("ERROR reingresar número!");
            numero = Int32.Parse(Console.ReadLine());
        }

        Console.WriteLine("El cuadrado del numero es: " + Math.Pow(numero, 2));
        Console.WriteLine("El cubo del numero es: " + Math.Pow(numero, 3));

        Console.ReadKey();
    }
}