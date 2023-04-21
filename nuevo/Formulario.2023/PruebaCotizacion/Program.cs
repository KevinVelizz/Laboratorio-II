using Entidades;

internal class Program
{
    private static void Main(string[] args)
    {


        Dolar dolar = new Dolar(1);
        Pesos pesos = new Pesos(102.65);
        Euro euro = new Euro(1 / 1.17);

        Pesos pesos1 = pesos - pesos;
        Dolar dolar1 = (Dolar)euro;

        Console.WriteLine(pesos1.GetCantidad());
    }
}