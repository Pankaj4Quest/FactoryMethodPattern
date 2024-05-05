using FactoryMethodPattern.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    internal class InstanceProvider<T>
    {
        public T Instance { get; set; }

        public InstanceProvider(BaseFactory<T> factoryType)
        {
            Instance = factoryType.createObject();
        }

        public T getInstance()
        {
            return Instance;
        }
    }
}
