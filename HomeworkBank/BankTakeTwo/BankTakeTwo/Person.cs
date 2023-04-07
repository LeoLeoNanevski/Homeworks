using BankTakeTwo.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTakeTwo
{
    public class Person : Client
    {
        private int ssn;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Occupation Occupation { get; set; }
        public Education Education { get; set; }
        private decimal monthlyWage;
        public List<BankProduct> BankProducts { get; set; }

        public int Age { get; set; }

        public Person()
        {
            ssn = new Random().Next(1000000000);
            BankProducts = new List<BankProduct>();
        }

        public bool IsLoanCandidate()
        {
            return monthlyWage > 18000 && BankProducts.Contains(BankProduct.Deposit) && Age >= 25 && Age <= 60;
        }

        public void CheckAge()
        {
            if (Age < 16)
                throw new Exception("Cannot be registered at the system.");
            else if (Age < 18)
                Occupation = Occupation.Student;
            else if (Age > 64)
                Occupation = Occupation.Pensioner;
        }
    }
}
