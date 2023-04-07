using Bank.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Person : Client
    {
        private string ssn;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Occupation Occupation { get; set; }
        public Education Education { get; set; }
        private decimal monthlyWage;
        public List<BankProduct> BankProducts { get; set; }
        public DateTime Birthdate { get; set; }

        public string SSN
        {
            get { return ssn; }
            set
            {
                if (value.Length != 11)
                    throw new ArgumentException("SSN must have 11 digits");

                ssn = value;
            }
        }

        public decimal MonthlyWage
        {
            get { return monthlyWage; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Monthly wage cannot be negative");

                monthlyWage = value;
            }
        }


        public static bool LoanCandidates(Person person)
        {
            var age = person.GetAge();
            var hasDeposit = person.BankProducts.Contains(BankProduct.Deposit);
            var hasCredit = person.BankProducts.Contains(BankProduct.Credit);
            var wage = person.MonthlyWage;

            if (age >= 25 && age <= 60 && wage > 18000 && hasDeposit && !hasCredit)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
