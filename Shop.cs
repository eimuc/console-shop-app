using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShopApp
{
    public class Shop
    {
        public List<Item> Items { get; set; }
        public Shop()
        {
            Items = new List<Item>();
        }
        public string Itemlist()
        {
            var itemList = new StringBuilder();
            foreach (var item in Items.Where(item => item.Quantity > 0))
            {
                itemList.Append($"\n{item.Name}\tquantity: {item.Quantity}, price: {item.Price}£\n\n");
            }

            return itemList.Length > 0 ? itemList.ToString() : "\nThere not any items at the shop!";
        }
        public string BuyItem(string name, int quantity)
        {
            return "";
        }
        public string AddItem(string name, int quantity)
        {
            var toAdd = Items.Find(item =>
                item.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (toAdd != null)
            {
                toAdd.Quantity += quantity;
                
                return Message.ItemAdded;
            }

            return Message.ItemNotAdded;
        }
    }
}
