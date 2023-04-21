using Entidades;

internal class Program
{
    private static void Main(string[] args)
    {
        Cosa cosa1 = new Cosa();
        cosa1.EstablecerValor(DateTime.Now);
        cosa1.EstablecerValor(20);
        cosa1.EstablecerValor("hola");
        Console.WriteLine(Cosa.Mostrar(cosa1));
    }
}