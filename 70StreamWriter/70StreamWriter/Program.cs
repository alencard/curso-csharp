namespace _70SreamWriter
{
    class Program
    {
        static void Main()
        {
            string sourcePath = @"..\..\..\Files\file.txt";
            string targetPath = @"..\..\..\Files\file1.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                //append adiciona conteudo no fim do arquivo
                using StreamWriter sw = File.AppendText(targetPath);

                foreach (string line in lines)
                {
                    sw.WriteLine(line.ToUpper());
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}