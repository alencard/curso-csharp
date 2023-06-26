using System.Globalization;

namespace _23_exercicios
{
    class Aluno
    {
        public string Nome;
        public double N1;
        public double N2;
        public double N3;

        public double NotaFinal()
        {
            return (N1 + N2 + N3) / 3;
        }

        public void SituacaoFinal()
        {
            if (NotaFinal() > 60.0)
            {
                Console.WriteLine("Aprovado!");
            }
            else
            {
                Console.WriteLine("Reprovado!");
                Console.WriteLine($"Faltaram {(60.0 - NotaFinal()).ToString("f2", CultureInfo.InvariantCulture)} pontos");
            }
        }
    }
}
