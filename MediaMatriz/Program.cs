internal class Program
{
    private static void Main(string[] args)
    {
        double[,] matriz = new double[5, 3];

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Insira os valores da " + (i + 1) + "° linha " + ": ");
            for (int j = 0; j < 2; j++)
            {
                Console.Write("Coluna " + (j + 1) + ": ");
                matriz[i, j] = double.Parse(Console.ReadLine());
            }

            double media = (matriz[i, 0] + matriz[i, 1]) / 2;
            matriz[i, 2] = media;
        }
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(matriz[i, j] + " ");
                Console.Write(matriz[i,2] + " ");
            }
            Console.WriteLine();
        }
    }
}