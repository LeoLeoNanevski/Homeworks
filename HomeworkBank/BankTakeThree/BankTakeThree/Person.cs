using BankTakeThree.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTakeThree
{
    public class Person : Client
    {
        private int ssn; // Private property for ssn
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Occupation Occupation { get; set; }
        public Education Education { get; set; }
        private decimal monthlyWage; // Private property for monthlyWage
        public List<BankProduct> BankProducts { get; set; } // List of bankProducts

        // Constructor that generates random number for ssn
        public Person()
        {
            Random random = new Random();
            ssn = random.Next(1000000000); // Assuming 9-digit ssn
        }

        // Property to get or set the monthlyWage with validation
        public decimal MonthlyWage
        {
            get { return monthlyWage; }
            set
            {
                if (value >= 0)
                {
                    monthlyWage = value;
                }
                else
                {
                    throw new ArgumentException("Monthly wage cannot be negative");
                }
            }
        }

        // Method to check the age of a person based on the ssn (assuming the first two digits are the year of birth)
        public int GetAge()
        {
            int year = ssn / 10000000;
            if (year < 21) // Assuming 21st century
            {
                year += 2000;
            }
            else // Assuming 20th century
            {
                year += 1900;
            }
            int currentYear = DateTime.Now.Year;
            return currentYear - year;
        }

        // Method to check the occupation of a person based on the age and throw error if under 16
        public void CheckOccupation()
        {
            int age = GetAge();
            if (age < 16)
            {
                throw new Exception("Cannot be registered at the system");
            }
            else if (age < 18)
            {
                Occupation = Occupation.Student;
            }
            else if (age > 64)
            {
                Occupation = Occupation.Pensioner;
            }
        }

        // Method to check if Person is good candidate for credit based on wage, deposit and age
        public bool IsLoanCandidate()
        {
            bool hasDeposit = BankProducts.Any(p => p == BankProduct.Deposit);
            int age = GetAge();
            return MonthlyWage > 18000 && hasDeposit && age >= 25 && age <= 60;
        }
    }
}
