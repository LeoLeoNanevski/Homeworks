using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    public class SalesPerson : Employee
    {
        public double SuccessRevenue { get; set; }

        public override double GetSalary()
        {
            return base.GetSalary() + (SuccessRevenue * 0.1);
        }

        public void AddSuccessRevenue(double revenue)
        {
            SuccessRevenue += revenue;
        }

        public SalesPerson(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = RoleEnum.Marketing;
        }
    }
}
