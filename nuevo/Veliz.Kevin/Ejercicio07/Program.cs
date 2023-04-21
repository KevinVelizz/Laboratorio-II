/*Hacer un programa que pida por pantalla la fecha de nacimiento de una persona
(día, mes y año) y calcule el número de días vividos por esa persona hasta la fecha
actual (tomar la fecha del sistema con DateTime.Now).
Nota: Utilizar estructuras selectivas. Tener en cuenta los años bisiestos.
*/

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

        TimeSpan dias_viv = tiempo_actual.Subtract(fecha_nac);
        Console.WriteLine($"Dias vividos: {dias_viv.Days}");

        //Sin timeSpan
        /*
        while (fecha_nac != tiempo_actual)
        {
            fecha_nac = fecha_nac.AddDays(1.0);

            dias_vividos++;
        }
        */
        //Console.WriteLine($"Dias vividos: {dias_vividos}");

        //Con TimeSpan

    }
}