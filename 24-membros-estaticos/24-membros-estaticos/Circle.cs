namespace _24_membros_estaticos
{
    static class Circle
    {
        public static double radius;

        public static double Circunferencia()
        {
            return 2 * Math.PI * radius;
        }

        public static double Volume()
        {
            return (4 * Math.PI * Math.Pow(radius, 3)) / 3;
        }
    }
}
