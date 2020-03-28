using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMSimulator
{
    public class User
    {
        public User(string fName, string lName, string cardNumber, string pinHash, float balance)
        {
            this.fName = fName;
            this.lName = lName;
            this.cardNumber = cardNumber;
            this.pinHash = pinHash;
            this.balance = balance;
        }

        public string fName { get; set; }
        public string lName { get; set; }
        private string cardNumber { get; set; }
        private string pinHash { get; set; }
        private float balance { get; set; }

        public float getBalance()
        {
            return this.balance;
        }

        public bool BalanceWithdraw(float amount)
        {
            if (CanWithdraw(amount))
            {
                this.balance -= amount;
                return true;
            }
            return false;
        }

        public void BalanceDeposit(float amount)
        {
            this.balance += amount;
        }

        private bool CanWithdraw(float amount)
        {
            if ((this.balance - amount) <= 0)
                return false;
            return true;
        }

        public string GetCardNumber()
        {
            return cardNumber;
        }

        public string GetPinHash()
        {
            return pinHash;
        }
    }
}
