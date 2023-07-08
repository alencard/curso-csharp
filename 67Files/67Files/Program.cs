namespace _67Files
{
    class Program
    {
        static void Main()
        {
            string sourcePath = @"C:\Users\thith\OneDrive\curso.txt";
            string targetPath = @"C:\Users\thith\OneDrive\curso2.txt";

            try
            {
                // criacao de um novo file a partir de um existente
                FileInfo fileInfo = new(sourcePath);
                fileInfo.CopyTo(targetPath);

                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error has occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}