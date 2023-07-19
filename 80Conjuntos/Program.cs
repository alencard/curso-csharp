using _80Conjuntos.Entities;

namespace _80Conjuntos
{
    class Program
    {
        static void Main()
        {
            /*
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
            */

            HashSet<Product> a = new();
            a.Add(new Product("TV", 900.0));
            a.Add(new Product("Notebook", 1200.0));

            HashSet<Point> b = new();
            b.Add(new Point(3, 4));
            b.Add(new Point(5, 10));

            Product prod = new("TV", 900);
            Console.WriteLine(a.Contains(prod));

            Point point = new(3, 4);
            Console.WriteLine(b.Contains(point));
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

