using _62MetodosAbstratos.Entities.Enums;

namespace _62MetodosAbstratos.Entities
{
    internal abstract class Shape
    {
        public Color Color { get; private set; }

        public Shape()
        {

        }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
