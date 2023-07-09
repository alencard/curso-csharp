namespace _73ExercicioFixacao
{
    class Program
    {
        static void Main()
        {
            string sourcePath;
            string targetPath;
            string[] lines;

            try
            {
                sourcePath = @"C:\Users\thith\OneDrive\programacao\back-end\csharp\curso-csharp\73ExercicioFixacao\73ExercicioFixacao\Files\file.txt";
                targetPath = @"C:\Users\thith\OneDrive\programacao\back-end\csharp\curso-csharp\73ExercicioFixacao\73ExercicioFixacao\Files\summary.csv";

                lines = File.ReadAllLines(sourcePath);

                using StreamWriter sw = File.AppendText(targetPath);

                foreach(string line in lines)
                {
                    sw.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}