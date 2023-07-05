using System.Collections.Generic;
using System.Globalization;

namespace _42_exercicio_list
{
    class Program
    {
        static void Main()
        {
            List<Funcionarios> listFuncionarios = new();

            Console.Write("How many employees will be registered? ");
            int numFuncionarios = int.Parse(Console.ReadLine());

            for (int i = 0; i < numFuncionarios; i++)
            {
                Console.WriteLine($"Employee #{i + 1}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string nome = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                listFuncionarios.Add(new(id, nome, salary));
                Console.WriteLine();
            }

            Console.WriteLine("List of employees:");
            foreach (var funcionario in listFuncionarios)
            {
                Console.WriteLine(funcionario);
            }

            Console.WriteLine();
            Console.Write("Enter the employee id that will have salary increase: ");
            int idAumentoSalarial = int.Parse(Console.ReadLine());

            foreach (var item in listFuncionarios)
            {
                if (item.Id == idAumentoSalarial)
                {
                    Console.Write("Enter the porcentage: ");
                    double porcentagem = double.Parse(Console.ReadLine());

                    int indiceAumento = listFuncionarios.FindIndex(x => x.Id == idAumentoSalarial);
                    listFuncionarios[indiceAumento].AumentoSalarial(10);
                }
                else
                {
                    Console.WriteLine("This id doesn't exist!");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (var funcionario in listFuncionarios)
            {
                Console.WriteLine(funcionario);
            }
        }
    }
}