namespace _04_UniversitySystem.Models
{
    internal class Teacher : Human
    {
        public string Subject { get; set; }
        public int ExperienceYears { get; set; }
        public decimal Salary { get; set; }

        public Teacher(
            string fullName,
            int age,
            string subject,
            int experienceYears,
            decimal salary
        ) : base(fullName, age)
        {
            Subject = subject;
            ExperienceYears = experienceYears;
            Salary = salary;
        }

        public override void Info()
        {
            base.Info();
            Console.WriteLine(
                $"Subject: {Subject}, Experience: {ExperienceYears} years, Salary: {Salary}"
            );
        }
    }
}