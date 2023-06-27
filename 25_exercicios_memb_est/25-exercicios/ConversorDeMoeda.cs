namespace _25_exercicios
{
    class ConversorDeMoeda
    {
        public static double Dolar;
        public static double IOF = 0.06;

        public static double CompraDolar(double qtd)
        {
            double total = (qtd * Dolar) + (qtd * Dolar * IOF);

            return total;
        }
    }
}
