using Bank.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
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

        public bool Has007Mobile()
        {
            return Mobile.StartsWith("007");
        }
    }
}
