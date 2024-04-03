using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4aprelhomework.Task3
{
    public class PartTimeEmployee : Employee
    {
        public override string Name { get; set; } = "Ramil";
        public override int EmployeeId { get; set; } = 2;
        public override double BasicSalary { get; set; } = 5;


        public override double CalculateSalary(double saat)
        {
            return saat * BasicSalary;
        }
    }
}
