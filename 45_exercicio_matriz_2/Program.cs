namespace _45_exercicio_matriz_2
{
    class Program
    {
        static void Main()
        {
            string[] rowCol = Console.ReadLine().Split(' ');
            int rows = int.Parse(rowCol[0]);
            int cols = int.Parse(rowCol[1]);
            int[,] mtz = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] numsRows = Console.ReadLine().Split(' ');

                for (int j = 0; j < cols; j++)
                {
                    int item = int.Parse(numsRows[j]);
                    mtz[i, j] = item;
                }
            }

            int choseNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (mtz[i, j] == choseNum)
                    {
                        Console.WriteLine($"Position: Row {i + 1}, Column {j + 1}");
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + mtz[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + mtz[i - 1, j]);
                        }
                        if (j < cols - 1)
                        {
                            Console.WriteLine("Right: " + mtz[i, j + 1]);
                        }
                        if (i < rows - 1)
                        {
                            Console.WriteLine("Down: " + mtz[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}