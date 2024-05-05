using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.EmployeeManager
{
    internal class PermanentEmployee : IEmployeeManager
    {
        public void getBasicSalary()
        {
            Console.WriteLine("Permanent Employee Basic Salary = 55000 INR");
        }

        public void getBonus()
        {
            Console.WriteLine("Permanent Employee Bonus = 10000 INR");
        }
    }
}
