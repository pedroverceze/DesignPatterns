using System;

namespace DesignPatterns.Facade.Shopping
{
    public class Taxes
    {
        public double GetItemTax(double value){
            Console.WriteLine($"Getting item tax from database..");
            var tax = (value * 12) / 100;

            return tax;
        }
    }
}