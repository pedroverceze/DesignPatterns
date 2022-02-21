using System;
using DesignPatterns.CalculateFactory;
using DesignPatterns.Facade;
using DesignPatterns.Singleton;
using DesignPatterns.Template;


class Program
{
    public static void Main(string[] args)
    {
        Facade();
    }

    private static void Singleton()
    {
        //This pattern allows you a assure that one class have just one instance
        //and it can be used globally

        Console.WriteLine("Singleton pattern");

        //Singleton, all instances with the same hash code.
        Logger obj = Logger.GetInstance();
        Logger obj2 = Logger.GetInstance();
        Logger obgInst = Logger.Instance;
        Logger obgInst2 = Logger.Instance;
        Console.WriteLine(obj.GetHashCode());
        Console.WriteLine(obj2.GetHashCode());
        Console.WriteLine(obgInst.GetHashCode());
        Console.WriteLine(obgInst2.GetHashCode());

        //Non-Singleton, each instance with its own hash code

        NonSingleton obj3 = new NonSingleton();
        NonSingleton obj4 = new NonSingleton();
        Console.WriteLine(obj3.GetHashCode());
        Console.WriteLine(obj4.GetHashCode());

        Console.ReadKey();

        Console.WriteLine("--------------------");
    }

    public static void Factory()
    {
        //Factory method is a pattern that provides an interface to create objects in a superclass,
        //but allow the subclasses change the type of objects that will be created.

        Console.WriteLine("Factory pattern");

        var factory = new CalculateFactory();

        Console.WriteLine("Choose your calc mode: Enter add, subject or divide");

        ICalculate calculateObj = factory.GetCalculation(Console.ReadLine());

        var resul = calculateObj.Calculate(1, 2);

        Console.WriteLine(resul);
    }

    public static void TemplateMethod()
    {
        //Template method is a pattern that defines the algorithm scaffolding in the superclass,
        //but allows the subclasses to override specific algorithm steps without modify its structure.

        var objTemp = new ExcelFile();
        objTemp.ProcessData();

        var objTemp2 = new TextFile();
        objTemp2.ProcessData();
    }

    public static void Facade(){

        //t is presented as a single class with a straightforward interface which allows callers to execute common tasks. 
        //The Facade may wrap a type with a very complex interface or multiple components which need to be used together

        //Facade instance class
        var facade = new ShoppingItem();

        var finalPrice = facade.GetShippingPrice("34", 2);

        Console.WriteLine($"The final price is: {finalPrice}");
    }
}

public class NonSingleton
{

}

