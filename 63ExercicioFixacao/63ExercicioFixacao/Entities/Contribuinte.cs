namespace _63ExercicioFixacao.Entities
{
    internal abstract class Contribuinte
    {
        public string Name { get; private set; }
        public double RendaAnual { get; protected set; }

        public Contribuinte()
        {

        }

        public Contribuinte(string name, double rendaAnual)
        {
            Name = name;
            RendaAnual = rendaAnual;
        }

        public abstract double Imposto();
    }
}
