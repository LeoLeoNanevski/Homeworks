using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTakeTwo
{
    public class Client
    {
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }

        public bool IsValidEmail()
        {
            return Email.Contains("@") && Email.EndsWith(".com");
        }

        public bool IsValidMobile()
        {
            return Mobile.StartsWith("007");
        }
    }
}
