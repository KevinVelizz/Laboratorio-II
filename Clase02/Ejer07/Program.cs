internal class Program
{
    private static void Main(string[] args)
    {
        int año;
        int mes;
        int dia;

        Console.WriteLine("Ingrese el año: ");
        año = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el mes: ");
        mes = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el dia: ");
        dia = Int32.Parse(Console.ReadLine());


        var tiempo2 = new DateTime(año,mes,dia);

        var tiempo_actual = DateTime.Today;

        Console.WriteLine(tiempo2);

        Console.ReadKey();
    }
}