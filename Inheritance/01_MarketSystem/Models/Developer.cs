using System;


namespace MarketSystem
{
    public class Developer : Employee
    {
        public string ProgrammingLanguage;
        public int ExperienceYears;


        public Developer()
        {
             
        }
        public Developer(string name,string surname,int age,double salary,string programmingLanguage,int experienceYears):base(name,surname,age,salary)
        {
            ProgrammingLanguage = programmingLanguage;
            ExperienceYears = experienceYears;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"ProgrammingLanguage: {ProgrammingLanguage}");
            Console.WriteLine($"ExperienceYears: {ExperienceYears}");

            if (ExperienceYears > 3)
            {
                Console.WriteLine("Senior Developer");
            }
            else
            {
                Console.WriteLine("Junior/Mid Developer");
            }
        }
        public override double CalculateSalary()
        {
            double experienceBonus = ExperienceYears * 50;

            return Salary + experienceBonus;
        }
    }
}
