
using System;
namespace MarketSystem
{
    public class Manager:Employee
    {

        public string Department;
        public double Bonus;

        public Manager()
        {
            
        }

       
        public Manager(string name, string surname,int age, double salary ,string department,double bonus):base(name,surname,age,salary)
        {
            Department = department;
            Bonus = bonus;
     
          


        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            double totalSalary = Salary + Bonus;

            Console.WriteLine($"Department: {Department}");
            Console.WriteLine($" bonus: {Bonus}");
            Console.WriteLine($"TotalSalary: {totalSalary}");

        }

        public override double CalculateSalary()
        {
            return Salary + Bonus;
        }

    }
}











