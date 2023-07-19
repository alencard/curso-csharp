namespace _82ExercicioProposto.Entities
{
    internal class Course
    {
        public List<Student> Students { get; set; } = new();

        public void AddStudents(int qtt)
        {
            for (int i = 0; i < qtt; i++)
            {
                int newStudentId = int.Parse(Console.ReadLine());
                Students.Add(new Student(newStudentId));
            }
        }
    }
}
