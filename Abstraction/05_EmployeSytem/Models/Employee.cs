namespace _05_EmployeSytem.Models
{
    internal abstract class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        protected Employee(string name,double salary)
        {
            Name = name;Salary = salary;
        }
        public abstract double   CalculateBonus();
        public void ShowInfo()
        {
            Console.WriteLine($"Name:{Name}, Salary:{Salary}");
        }
    }
}
