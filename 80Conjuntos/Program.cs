HashSet<string> set = new()
{
    "TV",
    "Notebook",
    "Tablet",
    "Notebook",
    "Computer"
};

//Console.WriteLine(set.Contains("computer"));

foreach (var item in set)
{
    Console.WriteLine(item);
}