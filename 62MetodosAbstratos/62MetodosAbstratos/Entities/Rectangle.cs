using _62MetodosAbstratos.Entities.Enums;

namespace _62MetodosAbstratos.Entities
{
    internal class Rectangle : Shape
    {
        public double Width { get; private set; }
        public double Height { get; private set; }

        public Rectangle()
        {

        }

        public Rectangle(Color color, double width, double height) : base(color)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}
