namespace _23_exercicios
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return (Largura * 2) + (Altura * 2);
        }

        public double Diagonal()
        {
            return Math.Pow((Math.Pow(Largura, 2) + Math.Pow(Altura, 2)), 0.5);
        }
    }
}
