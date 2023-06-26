namespace _21_metodos
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double Area()
        {
            double p = (A + B + C) / 2;
            double area = Math.Pow((p * (p - A) * (p - B) * (p - C)), 0.5);

            return area;
        }
    }
}
