namespace _43_matrizes
{
    class Program
    {
        static void Main()
        {
            double[,] mat = new double[2, 3];

            //multiplica linhas por colunas
            Console.WriteLine(mat.Length);

            // quantidade de linhas
            Console.WriteLine(mat.Rank);

            // retorna a quantidade de linhas e colunas, 0 para linhas, 1 para colunas
            Console.WriteLine(mat.GetLength(0));
            Console.WriteLine(mat.GetLength(1));
        }
    }
}