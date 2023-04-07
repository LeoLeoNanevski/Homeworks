using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankTakeThree.enums;



namespace BankTakeThree
{
    public class LegalEntity : Client
    {
        public string Name { get; set; }
        private int taxNumber; // Private property for taxNumber
        public Activity ActivityOfTheCompany { get; set; }
        public int NumberOfTheEmployee { get; set; }
        public List<Person> Owners { get; set; } // List of owners as Person objects
        private decimal profit; // Private property for profit

        // Constructor that generates random number for taxNumber
        public LegalEntity()
        {
            Random random = new Random();
            taxNumber = random.Next(1000000000); // Assuming 9-digit taxNumber
        }// Property to get or set the profit with validation
        public decimal Profit
        {
            get { return profit; }
            set
            {
                if (value >= 0)
                {
                    profit = value;
                }
                else
                {
                    throw new ArgumentException("Profit cannot be negative");
                }
            }
        }

        // Method to check if the owner of the company is already bank client and throw error if not
        public void CheckOwner()
        {
            foreach (Person owner in Owners)
            {
                if (owner.BankProducts == null || owner.BankProducts.Count == 0)
                {
                    throw new Exception("Owner is not a bank client");
                }
            }
        }
    }
}
