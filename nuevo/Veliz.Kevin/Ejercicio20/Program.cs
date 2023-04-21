/*
Crear una aplicación de consola y una biblioteca de clases que contenga la clase
Persona.
Deberá tener los atributos:
● nombre
● fechaDeNacimiento
● dni
Deberá tener un constructor que inicialice todos los atributos.
Construir los siguientes métodos para la clase:
● Setter y getter para cada uno de los atributos.
● CalcularEdad será privado y retornará la edad de la persona calculándola a
partir de la fecha de nacimiento.

● Mostrar retornará una cadena de texto con todos los datos de la persona,
incluyendo la edad actual.
● EsMayorDeEdad si es mayor de edad devuelve el valor “Es mayor de edad", sino
devuelve “es menor”.
1. Instanciar 3 objetos de tipo Persona en el método Main.
2. Mostrar quiénes son mayores de edad y quiénes no. 
*/

using Entidades;

internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Ingrese su nombre: ");
        string nombre = Console.ReadLine(); 

        Console.WriteLine("Ingrese fecha nac. formato dd/mm/yyyy");
        DateTime fechaDeNacimiento = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese su DNI: ");
        int dni = int.Parse(Console.ReadLine());

        Persona persona = new Persona(nombre,fechaDeNacimiento,dni);

        Console.WriteLine("Ingrese su nombre: ");
        string nombre2 = Console.ReadLine();

        Console.WriteLine("Ingrese fecha nac. formato dd/mm/yyyy");
        DateTime fechaDeNacimiento2 = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese su DNI: ");
        int dni2 = int.Parse(Console.ReadLine());

        Persona persona2 = new Persona(nombre2, fechaDeNacimiento2, dni2);

        Console.WriteLine("Ingrese su nombre: ");
        string nombre3 = Console.ReadLine();

        Console.WriteLine("Ingrese fecha nac. formato dd/mm/yyyy");
        DateTime fechaDeNacimiento3 = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese su DNI: ");
        int dni3 = int.Parse(Console.ReadLine());

        Persona persona3 = new Persona(nombre3, fechaDeNacimiento3, dni3);

        Console.WriteLine(persona.Mostrar());
        Console.WriteLine(persona2.Mostrar());
        Console.WriteLine(persona3.Mostrar());
    }
}