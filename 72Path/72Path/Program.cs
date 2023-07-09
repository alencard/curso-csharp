namespace _72Path
{
    class Program
    {
        static void Main()
        {
            string path = @"..\..\..\MyFolder\file.txt";

            Console.WriteLine(Path.DirectorySeparatorChar);
            Console.WriteLine(Path.PathSeparator);
            Console.WriteLine(Path.GetDirectoryName(path));
            Console.WriteLine(Path.GetFileName(path));
            Console.WriteLine(Path.GetExtension(path));
            Console.WriteLine(Path.GetFileNameWithoutExtension(path));
            Console.WriteLine(Path.GetFullPath(path));
            Console.WriteLine(Path.GetTempPath());
        }
    }
}