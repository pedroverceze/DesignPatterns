using System;

namespace DesignPatterns.Facade.Shopping
{
    public class Stock
    {
        public bool CheckItemStockByItemId(string itemId){
            Console.WriteLine($"Checking item {itemId} in stock...");
            return true;
        }
    }
}