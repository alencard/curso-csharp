using _54_exercicio_composicao.Entities;
using _54_exercicio_composicao.Entities.Enums;
using System.Globalization;

namespace _54_exercicio_composicao
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter department's name: ");
            string? departName = Console.ReadLine();

            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string? workerName = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Base Salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departament depart = new(departName);
            Worker worker = new(workerName, level, salary, depart);

            Console.Write("How many contracts to this worker? ");
            int numContracts = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < numContracts; i++)
            {
                Console.WriteLine($"Enter #{i + 1} contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime dateContract = DateTime.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Duration (hours): ");
                int hrs = int.Parse(Console.ReadLine());

                HourContract contract = new(dateContract, valuePerHour, hrs);

                worker.AddContract(contract);
            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            DateTime dateIncome = DateTime.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Department: {depart.Name}");
            Console.WriteLine($"Income for {dateIncome.Month}/{dateIncome.Year}: {worker.Income(dateIncome.Year, dateIncome.Month).ToString("f2", CultureInfo.InvariantCulture)}");
        }
    }
}