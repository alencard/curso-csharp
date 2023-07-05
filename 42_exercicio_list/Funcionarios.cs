using System.Globalization;

namespace _42_exercicio_list
{
    internal class Funcionarios
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public double Salary { get; private set; }

        public Funcionarios(int id, string nome, double salary)
        {
            Id = id;
            Nome = nome;
            Salary = salary;
        }

        public void AumentoSalarial(double porcentagem)
        {
            Salary += (Salary * (porcentagem / 100));
        }

        public override string ToString()
        {
            return $"{Id}, {Nome}, {Salary.ToString("f2", CultureInfo.InvariantCulture)}";
        }
    }
}
