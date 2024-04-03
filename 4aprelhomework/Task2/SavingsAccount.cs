using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4aprelhomework.Task2
{
    public class SavingsAccount : Account, IAccount
    {

        public double Deposit(double amouunt)
        {
            return Balance += amouunt;
        }

        public double Withdraw(double amouunt)
        {
            return Balance -= amouunt;
        }
        public double CalculateInterest()
        {
            return Balance + Balance * 10 / 100;
        }
    }
}
