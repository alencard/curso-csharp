namespace _69UsingBlock
{
    class Program
    {
        static void Main()
        {
            try
            {

                string path = @"..\..\..\Files\file.txt";

                using StreamReader sr = File.OpenText(path);

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}