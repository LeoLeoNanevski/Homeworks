using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    public class Manager : Employee
    {
        public double Bonus { get; set; }

        public override double GetSalary()
        {
            return base.GetSalary() + Bonus;
        }

        public void AddBonus(double bonus)
        {
            Bonus += bonus;
        }

        public Manager(string firstName, string lastName, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = RoleEnum.Manager;
            Salary = salary;
        }
    }
}
