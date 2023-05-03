using Entidades;
using System.Linq.Expressions;

internal class Program
{
    private static void Main(string[] args)
    {
        Negocio negocio = new Negocio("Hola");
        Cliente cliente = new Cliente(24);

        if (negocio + cliente)
        {
            Console.WriteLine("se agregoó");
        }
        else
        {
            Console.WriteLine("No se agregó");
        }
    }
}