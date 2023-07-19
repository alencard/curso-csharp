HashSet<int> courseA = new();
HashSet<int> courseB = new();
HashSet<int> courseC = new();

Console.Write("How many students for course A? ");
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    courseA.Add(int.Parse(Console.ReadLine()));
}

Console.Write("How many students for course B? ");
n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    courseB.Add(int.Parse(Console.ReadLine()));
}

Console.Write("How many students for course C? ");
n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    courseC.Add(int.Parse(Console.ReadLine()));
}

HashSet<int> all = new(courseA);
all.UnionWith(courseB);
all.UnionWith(courseC);

Console.WriteLine($"Total students: {all.Count}");