internal class Program
{
    private static void Main(string[] args)
    {
        int año_inicio;
        int año_fin;

        Console.WriteLine("Ingrese año inicio: ");
        año_inicio = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese año fin: ");
        año_fin = int.Parse(Console.ReadLine());

        while (año_inicio <= año_fin) 
        { 
            if(año_inicio % 4 == 0)
            {
                if(!(año_inicio % 100 == 0) || año_inicio % 400 == 0)
                {
                    Console.WriteLine(año_inicio);
                }
            }
            año_inicio++;
        }
    }
}