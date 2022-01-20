using DesignPatterns.CalculateFactory;
using DesignPatterns.Singleton;
using DesignPatterns.Template;

#region Singleton

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

#endregion

#region Factory

//Factory method is a pattern that provides an interface to create objects in a superclass,
//but allow the subclasses change the type of objects that will be created.

Console.WriteLine("Factory pattern");

var factory = new CalculateFactory();

Console.WriteLine("Choose your calc mode: Enter add, subject or divide");

ICalculate calculateObj = factory.GetCalculation(Console.ReadLine());

var resul = calculateObj.Calculate(1, 2);

Console.WriteLine(resul);

#endregion

#region Template Method

//Template method is a pattern that defines the algorithm scaffolding in the superclass,
//but allows the subclasses to override specific algorithm steps without modify its structure.

var objTemp = new ExcelFile();
objTemp.ProcessData();

var objTemp2 = new TextFile();
objTemp2.ProcessData();

#endregion

public class NonSingleton
{

}

