using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4aprelhomework.Task2
{
    public class CurrentAccount : Account, IAccount
    {
        public double CalculateInterest()
        {
            return Balance + Balance * 10 / 100;
        }

        public double Deposit(double amount)
        {
            return Balance += amount;
        }

        public double Withdraw(double amount)
        {
            return Balance -= amount;
        }
    }
}
