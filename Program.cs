using DesignPatterns.CalculateFactory;
using DesignPatterns.Singleton;

#region singleton
Console.WriteLine("Singleton pattern");

//Singleton
Logger obj = Logger.GetInstance();
Logger obj2 = Logger.GetInstance();
Logger obgInst = Logger.Instance;
Logger obgInst2 = Logger.Instance;
Console.WriteLine(obj.GetHashCode());
Console.WriteLine(obj2.GetHashCode());
Console.WriteLine(obgInst.GetHashCode());
Console.WriteLine(obgInst2.GetHashCode());

//Non-Singleton

NonSingleton obj3 = new NonSingleton();
NonSingleton obj4 = new NonSingleton();
Console.WriteLine(obj3.GetHashCode());
Console.WriteLine(obj4.GetHashCode());

Console.ReadKey();

Console.WriteLine("--------------------");

#endregion

#region Factory

Console.WriteLine("Factory pattern");

var factory = new CalculateFactory();

Console.WriteLine("Choose your calc mode: Enter add, subject or divide");

ICalculate calculateObj = factory.GetCalculation(Console.ReadLine());

var resul = calculateObj.Calculate(1, 2);

Console.WriteLine(resul);

#endregion

public class NonSingleton
{

}

