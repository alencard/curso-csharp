namespace _80Conjuntos
{
    class Program
    {
        static void Main()
        {
            SortedSet<int> set = new() { 10, 2, 4, 5, 6, 8, 0 };
            SortedSet<int> set2 = new() { 5, 6, 7, 8, 9, 10 };

            //union
            SortedSet<int> union = new(set);
            union.UnionWith(set2);
            PrintCollection(union);

            //intersection
            SortedSet<int> intersection = new(set);
            intersection.IntersectWith(set2);
            PrintCollection(intersection);

            //difference - exclui elementos da lista que é passada como parametro
            SortedSet<int> difference = new(set);
            difference.ExceptWith(set2);
            PrintCollection(difference);
        }

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T item in collection)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
        }
    }
}
/*
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
*/

