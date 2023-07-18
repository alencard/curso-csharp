using System.Globalization;

namespace _76IComparable.Entities
{
    class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmployee)
        {
            string[] data = csvEmployee.Split(',');
            Name = data[0];
            Salary = double.Parse(data[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return $"Name: {Name}, Salary: R${Salary.ToString("f2", CultureInfo.InvariantCulture)}";
        }

        public int CompareTo(object obj)
        {
            if (obj is not Employee)
            {
                throw new ArgumentException("");
            }

            Employee other = obj as Employee;

            return Name.CompareTo(other.Name);
        }
    }
}
