using FactoryMethodPattern.EmployeeManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Factories
{
    internal class TemporaryEmpFactory : BaseFactory<IEmployeeManager>
    {
        public override IEmployeeManager createObject()
        {
            return new TemporaryEmployee();
        }
    }
}
