using _77Generics1.Entities;


try
{
    var printService = new PrintService<string>();

    Console.Write("How many numbers? ");
    int qttNums = int.Parse(Console.ReadLine());

    for(int i = 1; i <= qttNums; i++)
    {
        string x = Console.ReadLine();
        printService.AddValues(x);
    }
}
catch (IndexOutOfRangeException e)
{
    Console.WriteLine($"Error: {e.Message}");
}