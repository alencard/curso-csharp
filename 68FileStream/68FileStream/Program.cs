namespace _68FileStream
{
    class Program
    {
        static void Main()
        {
            string path = @"..\..\..\Files\file.txt";
            StreamReader sr = null;

            try
            {
                sr = File.OpenText(path);
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
            finally
            {
                sr?.Close();
            }
        }
    }
}