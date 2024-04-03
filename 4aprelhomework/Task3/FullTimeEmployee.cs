using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _4aprelhomework.Task3
{
    public class FullTimeEmployee : Employee
    {
        public override string Name { get; set; } = "Samir";
        public override int EmployeeId { get ; set ; } = 1;
        public override double BasicSalary { get; set; } = 7;
        

        public override double CalculateSalary(double saat)
        {
            return saat * BasicSalary;
        }
    }
}
