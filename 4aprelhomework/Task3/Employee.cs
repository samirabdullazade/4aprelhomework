using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4aprelhomework.Task3
{
    public abstract class Employee
    {
        public abstract string Name { get; set; }
        public abstract int EmployeeId { get; set; }
        public abstract double BasicSalary { get; set; }
        public abstract double CalculateSalary(double saat);
    }
}
