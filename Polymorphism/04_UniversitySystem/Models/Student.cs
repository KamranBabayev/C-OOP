namespace _04_UniversitySystem.Models
{
    internal class Student : Human
    {
        public string Group { get; set; }
        public string Specialty { get; set; }
        public decimal GPA { get; set; }

        public Student(
            string fullName,
            int age,
            string group,
            string specialty,
            decimal gpa
        ) : base(fullName, age)
        {
            Group = group;
            Specialty = specialty;
            GPA = gpa;
        }

        public override void Info()
        {
            base.Info();

            Console.WriteLine(
                $"Group: {Group}, Specialty: {Specialty}, GPA: {GPA}"
            );
        }
    }
}