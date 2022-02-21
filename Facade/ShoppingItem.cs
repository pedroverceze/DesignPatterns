using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatterns.Facade.Shopping;

namespace DesignPatterns.Facade
{
    public class ShoppingItem
    {
        private ItemCost _itemCost;
        private Stock _stock;
        private Taxes _taxes;
        
        public ShoppingItem()
        {
            _itemCost = new ItemCost();
            _stock = new Stock();
            _taxes = new Taxes();
        }

        public double GetShippingPrice(string itemId, int qty){

            if(_stock.CheckItemStockByItemId(itemId)){
                var cost = (_itemCost.GetItemCost(itemId) * qty) ;
                var finalValue = _taxes.GetItemTax(cost);

                return finalValue;
            }

            return 0;
        }
    }
}