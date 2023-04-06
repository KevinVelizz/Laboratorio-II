internal class Program
{
    private static void Main(string[] args)
    {
        DateTime tiempo_actual = DateTime.Now.Date;

        int dia, mes, año;
        int dias_vividos = 0;

        Console.WriteLine("Ingrese el dia: ");
        dia = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el mes: ");
        mes = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el año: ");
        año = int.Parse(Console.ReadLine());

        DateTime fecha_nac = new DateTime(año, mes, dia);

        while(fecha_nac != tiempo_actual)
        {
            fecha_nac = fecha_nac.AddDays(1.0);

            dias_vividos++;
        }
        Console.WriteLine($"Dias vividos: {dias_vividos}");
    }
}