using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4aprelhomework.Task1
{
    public class Square : Shape
    {
        double n = 3;
        public override double CalculateArea()
        {
            return n * n;
        }

    }
}
