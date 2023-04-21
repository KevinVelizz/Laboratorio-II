/*
Ejercicio I02 - Cotizador

Consigna
Crear un proyecto de tipo biblioteca de clases. Construir tres clases dentro de un
namespace llamado Billetes: Pesos, Euro y Dolar.
Se debe lograr que los objetos de estas clases se puedan sumar, restar y comparar
entre sí con total normalidad como si fueran tipos numéricos, teniendo presente que 1
Euro equivale a 1,17 Dólares y 1 Dólar equivale a 102,65 Pesos.
TIP
Para operar dos tipos de monedas distintos, primero se deberá convertir todo a una
misma moneda y luego realizar la operación. Por ejemplo, si quiero sumar Dolar y Euro,
deberé convertir el Euro a Dólar y luego sumarlos.
1. El atributo cotizRespectoDolar y el método GetCotizacion son estáticos.
2. Los constructores estáticos le darán a las clases una cotización por defecto
respecto del dólar.
3. Sobrecargar los operadores explicit y/o implicit para lograr compatibilidad entre
los distintos tipos de datos.
4. Los operadores de comparación == compararán cantidades.
5. Reutilizar el código. Sólo realizar las conversiones dentro de los operadores para
dicho uso.
6. Crear un proyecto de consola y colocar dentro del método Main el código
necesario para probar todas las funcionalidades.
*/

using Billetes;
internal class Program
{
    private static void Main(string[] args)
    {

        Dolar dolar = new Dolar(25);
        Pesos peso1 = new Pesos(25);

        Dolar dolar1 = (Dolar)peso1;

        dolar1 = dolar;

        Euro euro = new Euro(25);

        Dolar dolar2 = (Dolar)euro;


        Console.WriteLine(dolar2.GetCantidad());

    }
}