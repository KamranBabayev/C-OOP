using System;

namespace MarketSystem
{
    public  class Employee
    {
        public string Name;
        public string Surname;
        public int Age;
        public double Salary;


        public Employee()
        {
            
        }

        public Employee(string name,string surname, int age, double salary)
        {
           Name = name;
           Surname = surname;
           Age = age;
           Salary = salary;

           
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"name; {Name}");
            Console.WriteLine($"surname; {Surname}");
            Console.WriteLine($"age; {Age}");
            Console.WriteLine($"salary; {Salary}");
        }

        public virtual double CalculateSalary()
        {
            return Salary;

        }
    }
}
