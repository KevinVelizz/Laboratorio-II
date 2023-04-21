internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = new int[2];
        array[0] = 1;
        array[1] = 2;
        array[2] = 3;


        int[,] array2 = new int[2, 2];

        array2[0,0] = 3;
        array2[1,0] = 4;
        array2[1,1] = 5;
        array2[0,1] = 6;

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.WriteLine(i + " - " + j + " = " + array2[i,j]);
            }
        }
    }
}