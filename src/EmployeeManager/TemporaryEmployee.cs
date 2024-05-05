using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.EmployeeManager
{
    internal class TemporaryEmployee : IEmployeeManager
    {
        public void getBasicSalary()
        {
            Console.WriteLine("Temporary Employee Basic Salary = 30000 INR");
        }

        public void getBonus()
        {
            Console.WriteLine("Temporary Employee Bonus = 5000 INR");
        }
    }
}
