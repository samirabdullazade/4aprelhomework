using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4aprelhomework.Task2
{
    public interface IAccount
    {
        public double Deposit(double amount);
        public double Withdraw(double amouunt);
        public double CalculateInterest();

    }
}
