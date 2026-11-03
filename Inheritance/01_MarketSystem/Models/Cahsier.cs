using System;

namespace MarketSystem
{
    public class Cahsier:Employee
    {
        public string CashRegisterNumber;
        public int WorkingHours;

        public Cahsier()
        {
            
        }
        public Cahsier(string name,string surname, int age, double salary,string cashRegisterNumber,int workingHours):base(name,surname,age,salary)
        {
            CashRegisterNumber = cashRegisterNumber;
            WorkingHours = workingHours;

        }
        public override void ShowInfo()
        {
            base.ShowInfo();

            Console.WriteLine($"CashRegstrNumber:{ CashRegisterNumber}");
            Console.WriteLine($"WorkingHours: {WorkingHours}");

            if (WorkingHours > 8)
            {
                Console.WriteLine("Overtime: Yes");
            }
            else
            {
                Console.WriteLine("Overtime: No");
            }
        }
        public override double CalculateSalary()
        {
            double overtimePayment = 0;

            if (WorkingHours > 8)
            {
                overtimePayment = (WorkingHours - 8) * 20;
            }

            return Salary + overtimePayment;
        }
    }
}
