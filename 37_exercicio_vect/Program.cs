namespace _37_exercicio_vect
{
    class Program
    {
        static void Main()
        {
            Estudante[] quartos = new Estudante[10];
            int qtdEst = 0;

            while (!(qtdEst >= 1 && qtdEst <= 10))
            {
                Console.Write("Insira a quantidade de estudantes: ");
                qtdEst = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < qtdEst; i++)
            {
                Console.Write($"Insira o quarto desejado para o estudante {i + 1} (0 - 9): ");
                int numQuarto = int.Parse(Console.ReadLine());
                Console.Write("Nome do estudante: ");
                string nome = Console.ReadLine();
                Console.Write("Email do estudante: ");
                string email = Console.ReadLine();
                Estudante estudante = new(nome, email);
                quartos[numQuarto] = estudante;
            }

            for (int i = 0; i < quartos.Length; i++)
            {
                if (quartos[i] != null)
                {
                    Console.WriteLine($"Quarto {i}: {quartos[i]}");
                }
                else
                {
                    Console.WriteLine($"Quarto {i}: Vago");
                }
            }
        }
    }
}