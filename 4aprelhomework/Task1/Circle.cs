using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4aprelhomework.Task1
{
    public class Circle : Shape
    {
        double r = 6;
        public override double CalculateArea()
        {
            return Math.PI * r * r;
        }

    }
}
