using _62MetodosAbstratos.Entities.Enums;

namespace _62MetodosAbstratos.Entities
{
    internal class Circle : Shape
    {
        public double Radius { get; private set; }

        public Circle() { }

        public Circle(Color color, double radius) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
