

namespace _04_UniversitySystem.Models
{
    internal class Human
    {

        public string FullName { get; set; }
        public int Age { get; set; }

        public Human()
        {
            
        }
        public Human(string fullName,int age)
        {
            FullName = fullName;
            Age = age;
        }
        public virtual void Info()
        {
            Console.WriteLine($"FullName:{FullName}, Age:{Age}");

        }
    }
}
