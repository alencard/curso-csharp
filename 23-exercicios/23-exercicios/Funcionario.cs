using System.Globalization;

namespace _23_exercicios
{
    class Funcionario
    {
        public string Nome;
        public double Salary;
        public double Tax;

        public double SalarioLiquido()
        {
            return Salary - Tax;
        }

        public void AumentarSalario(double porcentagem)
        {
            Salary += (Salary * (porcentagem / 100));
        }

        public override string ToString()
        {
            return $"{Nome}, R${SalarioLiquido().ToString("f2", CultureInfo.InvariantCulture)}";
        }
    }
}
