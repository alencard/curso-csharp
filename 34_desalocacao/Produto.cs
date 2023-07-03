namespace _34_desalocacao
{
    internal class Produto
    {
        public int Id;
        public string Nome;
        public double Valor;

        public Produto(int id, string nome, double valor)
        {
            Id = id;
            Nome = nome;
            Valor = valor;
        }

        public override string ToString()
        {
            return $"{Id}, {Nome}, {Valor}";
        }
    }
}
