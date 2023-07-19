namespace _82ExercicioProposto.Entities
{
    internal class Student
    {
        public int Id { get; private set; }

        public Student(int id)
        {
            Id = id;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj is not Student)
            {
                throw new ArgumentException("");
            }

            return base.Equals(obj);
        }
    }
}
