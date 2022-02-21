using System;

namespace DesignPatterns.Facade.Shopping
{
    public class ItemCost
    {
        public double GetItemCost(string itemId){
            Console.WriteLine($"Quering item {itemId} cost from database..");
            var random = new Random();

            return random.NextDouble();
        }
    }
}