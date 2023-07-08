namespace _59ExercicioFixacao.Entities
{
    class Employee
    {
        public string Name { get; private set; }
        public int Hours { get; private set; }
        public double ValuePerHour { get; private set; }

        public Employee()
        {

        }

        public Employee(string name, int hours, double valuePH)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePH;
        }

        public virtual double Payment()
        {
            return ValuePerHour * Hours;
        }
    }
}
