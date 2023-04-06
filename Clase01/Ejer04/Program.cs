
internal class Program
{
    private static void Main(string[] args)
    {
        int num = 2;
        int suma;
        int limite = 0;

        while (limite < 4) 
        {
            suma = 0;

            for (int i = 1; i < num; i++) 
            {
                if (num % i == 0)
                {
                    suma += i;
                }
            }

            if (suma == num)
            {
                Console.WriteLine(num);
                limite++;
            }
            num++;
        }
    }
}