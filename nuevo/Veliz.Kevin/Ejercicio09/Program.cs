internal class Program
{
    private static void Main(string[] args)
    {
        int limite;
        int altura;
        int i;

        string estrella;
        string pilas;

        limite = 0;

        Console.WriteLine("Ingrese la altura: ");
        altura = int.Parse(Console.ReadLine());

        estrella = "*";
        pilas = "";

        while (limite < altura)
        {

            for (i = 0; i < altura;i++)
            {
                estrella += "**";
                pilas += estrella + "\n";
                break;
            }
            limite++;
        }

        Console.WriteLine(estrella);
    }
}