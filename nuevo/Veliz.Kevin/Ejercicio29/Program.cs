/*
Consigna
Partiendo del ejercicio Conversor binario, se pide agregar las clases:
NumeroBinario:
1. Único atributo numero de tipo string.
2. Único constructor privado (recibe un parámetro de tipo string).
NumeroDecimal:
1. Único atributo numero de tipo double.
2. Único constructor privado (recibe un parámetro de tipo double).
Utilizando los métodos de la clase Conversor donde corresponda, agregar las
sobrecargas de operadores:
NumeroBinario:
1. string + (NumeroBinario, NumeroDecimal)
2. string - (NumeroBinario, NumeroDecimal)
3. bool == (NumeroBinario, NumeroDecimal)
4. bool != (NumeroBinario, NumeroDecimal)
NumeroDecimal:
1. double + (NumeroDecimal, NumeroBinario)
2. double - (NumeroDecimal, NumeroBinario)
3. bool == (NumeroDecimal, NumeroBinario)
4. bool != (NumeroDecimal, NumeroBinario)
Agregar conversiones implícitas para poder ejecutar:
NumeroBinario objBinario = "1001";
NumeroDecimal objDecimal = 9;
Agregar conversiones explícitas para poder ejecutar:
string binario = (string)objBinario;
double numeroDecimal = (double)objDecimal;
Generar el código en el método Main para instanciar un objeto de cada tipo y operar
entre ellos, imprimiendo cada resultado por pantalla.
*/
using Entidades;

internal class Program
{
    private static void Main(string[] args)
    {
     
    }

}