﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4aprelhomework.Task1
{
    public class Triangle : Shape
    {
        double a = 3;
        double h = 4;
        public override double CalculateArea()
        {
            return a * h / 2;
        }
    }
}
