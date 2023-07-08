using _62MetodosAbstratos.Entities;
using _62MetodosAbstratos.Entities.Enums;
using System.Globalization;

namespace _62MetodosAbstratos
{
    class Program
    {
        static void Main()
        {
            List<Shape> shapes = new();
            int n;

            Console.Write("Enter the number of shapes: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                char shape;
                Color color;

                Console.WriteLine();
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle or Circle (r/c)? ");
                shape = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                color = Enum.Parse<Color>(Console.ReadLine());

                if (shape == 'r')
                {
                    double width;
                    double height;

                    Console.Write("Width: ");
                    width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    shapes.Add(new Rectangle(color, width, height));
                }
                else
                {
                    double radius;

                    Console.Write("Radius: ");
                    radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    shapes.Add(new Circle(color, radius));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Shape Areas");
            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.Area().ToString("f2", CultureInfo.InvariantCulture));
            }
        }
    }
}