namespace _37_exercicio_vect
{
    class Estudante
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }

        public Estudante(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Email: {Email}";
        }
    }
}
