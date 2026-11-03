

namespace _05_EmployeSytem.Models
{
    internal class PartTimeEmployee:Employee
    {
        public PartTimeEmployee(string name, double salary) : base(name, salary)
        {
        }
        public override double  CalculateBonus()
        {

            return Salary * 0.05;
        }


    }
}
