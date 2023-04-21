/*
Requerimiento
De una empresa de transporte de cargas se quiere guardar el nombre de los
conductores y los kilómetros que conducen cada día de la semana.
Para guardar esta información, la empresa de transporte tendrá un array de
conductores.
De cada conductor se tendrá la siguiente información:
● Nombre del conductor.
● Kilómetros recorridos cada día de la semana. Por ejemplo:
○ Día 1: 200
○ Día 2: 599
○ Día 3: 899
○ Día 4: 0 (tiene franco)
○ Día 5: 256
○ Día 6: 0
○ Día 7: 0

Consigna
Desarrollar las clases y métodos necesarios. Toda la lógica de negocio deberá estar
encapsulada en clases y dentro de un proyecto de tipo biblioteca de clases.
Crear un proyecto de consola y en el método Main cargar 3 conductores a la empresa
de transportes.
Luego mostrar:
● El conductor que hizo más km en esa semana.
● El conductor que hizo más km el día 3.
● El conductor que hizo más km el día 5.
*/
using Entidades;

internal class Program
{
    private static void Main(string[] args)
    {
        Conductor conductor1 = new Conductor("Kevin", new int[7] { 1, 1, 6, 0, 45, 1, 7 });
        Conductor conductor2 = new Conductor("Pedro", new int[7] { 1, 1, 1, 0, 6, 1, 100 });
        Conductor conductor3 = new Conductor("Juan", new int[7] { 1, 1, 1, 0, 45, 1, 7});
        Conductor conductor4 = new Conductor("Jose", new int[7] { 143, 45, 75, 0, 244, 452,7});
        Conductor conductor5 = new Conductor("Mario", new int[7] { 1, 1, 1, 0, 6, 1, 100 });
        Conductor conductor6 = new Conductor("Elias", new int[7] { 1, 1, 1, 0,1, 1, 232 });

        Conductor[] conductores = new Conductor[] {conductor1,conductor2,conductor3,conductor4,conductor5,conductor6};

        string nombreM = conductor1.GetNombre();
        string nombreMayorDia3 = conductor1.GetNombre();
        string nombreMayorDia5 = conductor1.GetNombre();

        foreach (var conductor in conductores)
        {
            if(conductor.EsMayor(conductores))
            {
                nombreM = conductor.GetNombre();
            }

            if(conductor.EsMayorDeterminadoDia(3,conductores))
            {
                nombreMayorDia3 = conductor.GetNombre();
            }

            if(conductor.EsMayorDeterminadoDia(5,conductores))
            {
                nombreMayorDia5 = conductor.GetNombre();
            }
        }
        Console.WriteLine(nombreM);
        Console.WriteLine(nombreMayorDia3);
        Console.WriteLine(nombreMayorDia5);
    }
}