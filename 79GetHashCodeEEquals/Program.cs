using _79GetHashCodeEEquals.Entities;

/*
string a = "Maria";
string b = "Lucas";

for (int i = 0; i < 5; i++)
{
    int num1 = a.GetHashCode();
    int num2 = b.GetHashCode();
    int num3 = a.GetHashCode();

    Console.WriteLine(num1);
    Console.WriteLine(num2);
    Console.WriteLine(num3);
    Console.WriteLine();
}

while (num1 != num2)
{
    Console.WriteLine(num1 == num2);
}
*/

Client a = new("Maria", "maria@email.com");
Client b = new("Alex", "alex@email.com");

Console.WriteLine(a.Equals(b));
Console.WriteLine(a == b);
Console.WriteLine(a.GetHashCode());
Console.WriteLine(b.GetHashCode());
