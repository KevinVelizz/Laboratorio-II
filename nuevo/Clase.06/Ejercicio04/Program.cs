/*
Crear un proyecto de biblioteca de clases que contenga las clases Jugador y Equipo:

Clase Jugador
● Todos los datos estadísticos del jugador se inicializarán en 0 dentro del
constructor privado.
● El promedio de gol sólo se calculará cuando invoquen al método
GetPromedioGoles.
● MostrarDatos retornará una cadena de string con todos los datos y estadísticas
del jugador.
● Dos jugadores serán iguales si tienen el mismo DNI.
Clase Equipo
● La lista de jugadores se inicializará sólo en el constructor privado de Equipo.

● La sobrecarga del operador + agregará jugadores a la lista siempre y cuando no
exista aún en el equipo y la cantidad de jugadores no supere el límite establecido
por el atributo cantidadDeJugadores.
Crear un proyecto de consola y generar las invocaciones necesarias en el método Main
para probar el código.
*/

using Entidades;

internal class Program
{
    private static void Main(string[] args)
    {
        Jugador jugador = new Jugador(10, "Kevin", 10, 2);
        Jugador jugador2 = new Jugador(10, "Elias", 10, 2);

        Equipo equipo = new Equipo(5,"dinamita");

        if(equipo + jugador)
        {
            Console.WriteLine("Se insertó jugador");
            Console.WriteLine(jugador.MostrarDatos());
        }
        else
        {
            Console.WriteLine("No se insertó jugador");
        }

        if (equipo + jugador2)
        {
            Console.WriteLine("Se insertó jugador");
        }
        else
        {
            Console.WriteLine("No se insertó jugador");
        }
    }
}