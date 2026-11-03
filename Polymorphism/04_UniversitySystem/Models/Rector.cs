

namespace _04_UniversitySystem.Models
{
    internal class Rector : Human
    {
        public int FacultyCount { get; set; }
        public int ExperienceYears { get; set; }

        public string UniversityName { get; set; }


        public Rector()
        {
            
        }
        public Rector(string fullName,int age,int facultyCount,int experienceYears,string universityname):base(fullName,age)
        {
            FacultyCount = facultyCount;
            ExperienceYears = experienceYears;
            UniversityName = universityname;
        }

        public override void Info()
        {
            base.Info();
            Console.WriteLine($"Fakültələrin sayı: {FacultyCount}");
            Console.WriteLine($"İş təcrübəsi: {ExperienceYears} il");
            Console.WriteLine($"Universitet: {UniversityName}");
        }
    }
}
