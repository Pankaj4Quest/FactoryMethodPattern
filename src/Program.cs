using FactoryMethodPattern;
using FactoryMethodPattern.EmployeeManager;
using FactoryMethodPattern.Factories;

internal class Program
{
    private static void Main(string[] args)
    {
        //use generic base factories if you have multiple type of factories in your project,
        //let all inherit from generic base
        BaseFactory<IEmployeeManager> baseFactory;

        //method 1 directly getting the basefactory object
        baseFactory = new PermanentEmpFactory();
        var PermanentEmpObject = baseFactory.createObject();
        PermanentEmpObject.getBasicSalary();
        PermanentEmpObject.getBonus();

        //method 2 Use Provider class to get the instance
        baseFactory = new TemporaryEmpFactory();
        InstanceProvider<IEmployeeManager> provider = new InstanceProvider<IEmployeeManager>(baseFactory);
        var obj = provider.getInstance();
        obj.getBasicSalary();
        obj.getBonus();

        Console.ReadKey();

    }
}