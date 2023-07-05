namespace _44_exercicio_matriz
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] mtz = new int[n, n];
            int[] mainDiagonal = new int[n];
            int negNums = 0;

            for (int i = 0; i < mtz.GetLength(0); i++)
            {
                string[] rows = Console.ReadLine().Split(' ');

                for (int j = 0; j < mtz.GetLength(1); j++)
                {
                    int item = int.Parse(rows[j]);
                    mtz[i, j] = item;

                    if (i == j)
                    {
                        mainDiagonal[i] = item;
                    }

                    if (item < 0)
                    {
                        negNums++;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Main diagonal:");

            foreach (int item in mainDiagonal)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
            Console.WriteLine($"Negative numbers = {negNums}");
        }
    }
}