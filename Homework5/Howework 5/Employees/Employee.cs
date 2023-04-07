using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public RoleEnum Role { get; set; }
        public double Salary { get; set; }

        public virtual double GetSalary()
        {
            return Salary;
        }

        public virtual string GetInfo()
        {
            return $"{FirstName} {LastName} ({Role})";
        }
    }
}
