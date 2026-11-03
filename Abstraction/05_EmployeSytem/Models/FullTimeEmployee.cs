

namespace _05_EmployeSytem.Models
{
    internal class FullTimeEmployee:Employee
    {
        public FullTimeEmployee(string name, double  salary) : base(name, salary)
        {

        }
        public override double   CalculateBonus()
        {

            return Salary * 0.10;
        }
        
    }
}
