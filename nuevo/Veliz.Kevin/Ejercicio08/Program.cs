/*
Por teclado se ingresa el valor hora, el nombre, la antigüedad (en años) y la cantidad
de horas trabajadas en el mes de N empleados de una fábrica.

Se pide calcular el importe a cobrar teniendo en cuenta que el total (que resulta de
multiplicar el valor hora por la cantidad de horas trabajadas), hay que sumarle la
cantidad de años trabajados multiplicados por $15000, y al total de todas esas
operaciones restarle el 13% en concepto de descuentos.
Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total
a cobrar en bruto, el total de descuentos y el valor neto a cobrar de todos los
empleados ingresados.
Nota: Utilizar estructuras repetitivas y selectivas.
 */

internal class Program
{
    private static void Main(string[] args)
    {
        int valor_hora;
        string nombre;
        int antiguedad;
        int cant_horas;
        int importe_cobrar;
        int importe_anios;
        int importe_bruto;
        int descuento;
        int importe_neto;

        string condicion;

        while (true)
        {
            Console.WriteLine("Ingrese valor hora: ");
            valor_hora = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese la antiguedad en años: ");
            antiguedad = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cant. de horas trabajadas: ");
            cant_horas = int.Parse(Console.ReadLine());

            importe_cobrar = valor_hora * cant_horas;

            importe_anios = antiguedad * 15000;

            importe_bruto = importe_cobrar + importe_anios;

            descuento = 13 * importe_bruto / 100;

            importe_neto = importe_bruto - descuento;

            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Antiguedad: {antiguedad}");
            Console.WriteLine($"Valor hora: ${valor_hora}");
            Console.WriteLine($"Importe Bruto: ${importe_bruto}");
            Console.WriteLine($"Importe Neto: ${importe_neto}");

            Console.WriteLine("Desea ingresar otro dato 's' si o 'n' no : ");
            condicion = Console.ReadLine().ToLower();

            if (condicion != "s")
            {
                break;
            }

        }


    }
}