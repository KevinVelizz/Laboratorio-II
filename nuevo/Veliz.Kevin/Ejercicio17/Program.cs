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


        DateTime tiempo2 = new DateTime(año, mes, dia);

        DateTime tiempo_actual = DateTime.Today;

        TimeSpan dif_tiempo = tiempo_actual.Subtract(tiempo2);

        Console.WriteLine($"Pasaron: {dif_tiempo.Days} días");

        Console.ReadKey();
    }
}