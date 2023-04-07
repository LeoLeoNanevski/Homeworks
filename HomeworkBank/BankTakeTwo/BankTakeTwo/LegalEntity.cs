using BankTakeTwo.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTakeTwo
{
    public class LegalEntity : Client
    {
        public string Name { get; set; }
        private int taxNumber;
        public CompanyActivity ActivityOfTheCompany { get; set; }
        public int NumberOfTheEmployee { get; set; }
        public List<Person> Owners { get; set; }
        private decimal profit;

        public LegalEntity()
        {
            taxNumber = new Random().Next(1000000000);
            Owners = new List<Person>();
        }

        public void CheckOwners(List<Client> clients)
        {
            foreach (var owner in Owners)
                if (!clients.Any(c => c == owner))
                    throw new Exception("Owner is not a bank client.");
        }
    }

}
