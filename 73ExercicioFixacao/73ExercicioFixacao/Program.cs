using System.Globalization;

namespace _73ExercicioFixacao
{
    class Program
    {
        static void Main()
        {
            string sourcePath;
            string targetPath;
            string[] lines;
            string[] linesItems;
            double price;
            int qtt;
            double finalValue;

            try
            {
                sourcePath = @"C:\Users\thith\OneDrive\programacao\back-end\csharp\curso-csharp\73ExercicioFixacao\73ExercicioFixacao\Files\file.txt";
                targetPath = @"C:\Users\thith\OneDrive\programacao\back-end\csharp\curso-csharp\73ExercicioFixacao\73ExercicioFixacao\Files\summary.csv";

                lines = File.ReadAllLines(sourcePath);

                using StreamWriter sw = File.AppendText(targetPath);

                foreach (string line in lines)
                {
                    linesItems = line.Split(',');
                    price = double.Parse(linesItems[^2], CultureInfo.InvariantCulture);
                    qtt = int.Parse(linesItems[^1]);
                    finalValue = price * qtt;

                    sw.WriteLine($"{linesItems[0]},{finalValue.ToString("f2", CultureInfo.InvariantCulture)}");
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