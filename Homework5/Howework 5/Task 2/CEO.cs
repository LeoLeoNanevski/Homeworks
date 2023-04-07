using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class CEO : Employee
    {
        private double sharesPrice;
        public Employee[] Employees { get; set; }
        public int Shares { get; set; }

        public CEO(string firstName, string lastName, double salary, Employee[] employees) : base(firstName, lastName, salary)
        {
            Employees = employees;
        }

        public void AddSharesPrice(double price)
        {
            sharesPrice = price;
        }

        public void PrintEmployees()
        {
            Console.WriteLine("Employees:");
            foreach (Employee e in Employees)
            {
                Console.WriteLine(e.FirstName + " " + e.LastName);
            }
        }

        public override double GetSalary()
        {
            return base.GetSalary() + Shares * sharesPrice;
        }

        public void PrintInfo()
        {
            Console.WriteLine("CEO:");
            Console.WriteLine("First Name: " + FirstName + ", Last Name: " + LastName + ", Salary: " + Salary);
        }
    }
}
