namespace _63ExercicioFixacao.Entities
{
    internal class PessoaFisica : Contribuinte
    {
        public double GastosComSaude { get; private set; }

        public PessoaFisica()
        {

        }

        public PessoaFisica(string name, double rendaAnual, double gastosComSaude) : base(name, rendaAnual)
        {
            GastosComSaude = gastosComSaude;
        }

        public override double Imposto()
        {
            double impostoBruto;
            double descontoPorSaude;

            descontoPorSaude = GastosComSaude * 0.5;
            impostoBruto = RendaAnual * 0.15;

            if (RendaAnual >= 20000)
            {
                impostoBruto = RendaAnual * 0.25;
            }

            return impostoBruto - descontoPorSaude;
        }
    }
}
