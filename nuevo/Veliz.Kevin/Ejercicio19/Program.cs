using Entidades;

public class Program
{
    private static void Main(string[] args)
    {
        Cuenta cuenta = new Cuenta("Kevin",20000);
        
        if(cuenta.retirar(15933))
        {
            Console.WriteLine("Se pudo hacer el retiro.");
        }

        if(cuenta.ingresar(-2344))
        {
            Console.WriteLine("Se pudo ingresar dinero.");
        }
        else
        {
            Console.WriteLine("No se pudo ingresar dinero");
        }


        Console.WriteLine(cuenta.mostrar());

    }
}