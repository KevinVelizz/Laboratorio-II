using Entidades;

public class Program
{
    private static void Main(string[] args)
    {
        
        Creadora tiempo1 = new Creadora();
        Console.WriteLine(tiempo1.obtenerCantidadObjetosCreados());
        Console.WriteLine(tiempo1.ObtenerDiferencia());

        Creadora tiempo2 = new Creadora();
        Console.WriteLine(tiempo2.obtenerCantidadObjetosCreados());
        Console.WriteLine(tiempo2.ObtenerDiferencia());

        Creadora tiempo3 = new Creadora();
        Console.WriteLine(tiempo3.obtenerCantidadObjetosCreados());
        Console.WriteLine(tiempo3.ObtenerDiferencia());

        Creadora tiempo4 = new Creadora();
        Console.WriteLine(tiempo4.obtenerCantidadObjetosCreados());
        Console.WriteLine(tiempo4.ObtenerDiferencia());

    }
}