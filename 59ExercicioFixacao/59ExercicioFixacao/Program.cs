using _59ExercicioFixacao.Entities;
using System.Globalization;

namespace _59ExercicioFixacao
{
    class Program
    {
        static void Main()
        {
            List<Employee> listEmployees = new();
            int n;

            Console.Write("How many employees do you want to register? ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Employee employee;
                char outsourced;
                string name;
                int hours;
                double valuePerHour;

                Console.WriteLine();
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                outsourced = char.Parse(Console.ReadLine());

                Console.Write("Insert the employee's name: ");
                name = Console.ReadLine();
                Console.Write("Insert the employee's hours: ");
                hours = int.Parse(Console.ReadLine());
                Console.Write("Insert the employee's value per hour: ");
                valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (outsourced == 'y')
                {
                    double additionalCharge;

                    Console.Write("Insert the additional charge: ");
                    additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    employee = new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge);

                    listEmployees.Add(employee);

                    continue;
                }

                employee = new(name, hours, valuePerHour);
                listEmployees.Add(employee);
            }

            Console.WriteLine("Payments:");
            foreach (Employee employee in listEmployees)
            {
                Console.WriteLine($"{employee.Name} - R${employee.Payment().ToString("f2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}