using FactoryMethodPattern.EmployeeManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Factories
{
    internal abstract class BaseFactory<T>
    {
        public abstract T createObject();
    }
}
