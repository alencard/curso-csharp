namespace _63ExercicioFixacao.Entities
{
    internal class PessoaJuridica : Contribuinte
    {
        public int QtdFuncionarios { get; private set; }

        public PessoaJuridica()
        {

        }

        public PessoaJuridica(string name, double rendaAnual, int qtdFuncionarios) : base(name, rendaAnual)
        {
            QtdFuncionarios = qtdFuncionarios;
        }

        public override double Imposto()
        {
            double taxa;

            taxa = 0.16;

            if (QtdFuncionarios > 10)
            {
                taxa = 0.14;
            }

            return RendaAnual * taxa;
        }
    }
}
