using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMSimulator
{
    class User
    {
        public User(string fName, string lName, string cardNumber, string pinHash)
        {
            this.fName = fName;
            this.lName = lName;
            this.cardNumber = cardNumber;
            this.pinHash = pinHash;
        }

        public string fName { get; set; }
        public string lName { get; set; }
        public string cardNumber { get; set; }
        public string pinHash { get; set; }
    }
}
