using Bank.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class LegalEntity : Client
    {
        private string taxNumber;
        public string Name { get; set; }
        public ActivityOfTheCompany ActivityOfTheCompany { get; set; }
        public int NumberOfEmployees { get; set; }
        public List<string> Owners { get; set; }
        private decimal profit;

        public string TaxNumber
        {
            get { return taxNumber; }
            set
            {
                if (value.Length != 10)
                    throw new ArgumentException("Tax number must have 10 digits");

                taxNumber = value;
            }
        }

        public decimal Profit
        {
            get { return profit; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Profit cannot be negative");

                profit = value;
            }
        }

        public void CheckOwner(Person person)
        {
            if (Owners.Contains(person.SSN))
            {
                throw new ArgumentException("The owner of the company is already a bank client.");
            }
        }
    }
}
