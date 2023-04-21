/*
Consigna
Crear una aplicación de consola y una biblioteca de clases que contenga la clase del
siguiente diagrama:

La clase Estudiante:
● Tendrá un constructor estático que inicializará el atributo estático random.
● Tendrá un constructor de instancia que inicializará los atributos nombre, apellido
y legajo.

● El método setter SetNotaPrimerParcial permitirá cambiar el valor del atributo
notaPrimerParcial.
● El método setter SetNotaSegundoParcial permitirá cambiar el valor del atributo
notaSegundoParcial.
● El método privado CalcularPromedio retornará el promedio de las dos notas.

● El método CalcularNotaFinal deberá retornar la nota del final con un numero
aleatorio entre 6 y 10 incluidos siempre y cuando las notas del primer y segundo
parcial sean mayores o iguales a 4, caso contrario la inicializará con el valor -1.
● El método Mostrar utilizará StringBuilder para armar una cadena de texto con
todos los datos de los alumnos:
○ Nombre, apellido y legajo.
○ Nota del primer y segundo parcial.
○ Promedio.
○ Nota final. Se mostrará sólo si el valor es distinto de -1, caso contrario se
mostrará la leyenda "Alumno desaprobado".

1. Crear tres instancias de la clase Estudiante (tres objetos) en el método Main.
2. Cargar las notas del primer y segundo parcial a todos los alumnos. Dos deberán
estar aprobados y uno desaprobado.
3. Mostrar los datos de todos los alumnos.
IMPORTANTE
Para darle un valor aleatorio a la nota final utilice el método de instancia Next de la
clase Random.
*/

using Entidades;

internal class Program
{
    private static void Main(string[] args)
    {

        Estudiante estudiante = new Estudiante("Kevin", "Veliz", 1555);
        Estudiante estudiante2 = new Estudiante("Esteban", "Fernadez", 1534);
        Estudiante estudiante3 = new Estudiante("Elias", "Veliz", 1845);

        estudiante.SetNotaPrimerParcial(10);
        estudiante.SetNotaSegundoParcial(10);

        estudiante2.SetNotaPrimerParcial(7);
        estudiante2.SetNotaSegundoParcial(8);

        estudiante3.SetNotaPrimerParcial(3);
        estudiante3.SetNotaSegundoParcial(2);

        Console.WriteLine(estudiante.mostrar() + "\n");
        Console.WriteLine(estudiante2.mostrar() + "\n");
        Console.WriteLine(estudiante3.mostrar());
    }
}