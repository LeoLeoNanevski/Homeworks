using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    public class Contractor : Employee
    {
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }
        public Manager Responsible { get; set; }

        public override double GetSalary()
        {
            double salary = WorkHours * PayPerHour;
            Salary = salary;
            return salary;
        }

        public string CurrentPosition()
        {
            return Responsible.GetInfo();
        }
    }
}
