using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4aprelhomework.Task2
{
    public abstract class Account
    {
        public double AccountNumber = 114;
        public double Balance = 0;
        public double ShowAccountDetails()
        {
            return Balance;
        }
    }
}
