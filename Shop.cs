using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleShopApp
{
    public class Shop
    {
        public List<Item> Items { get; set; }

        public Shop()
        {
            Items = new List<Item>();
        }

        public string ListItem()
        {
            var itemList = new StringBuilder();
            foreach (var item in Items.Where(item => item.Quantity > 0))
            {
                itemList.Append($"\n{item.Name}\tquantity: {item.Quantity}, price: {item.Price}£\n");
            }

            return itemList.Length > 0 ? itemList.ToString() : "\nNo items found!";
        }

        public string BuyItem(User user, string name, int quantity)
        {
            var validItems = Items.Find(item =>
                  item.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (validItems != null)
            {
                if (validItems.Quantity >= quantity)
                {
                    var hasUserEnoughMoney = quantity * validItems.Price <= user.Balance;
                    if (!hasUserEnoughMoney)
                    {
                        return Message.InvalidBalance;
                    }

                    validItems.Quantity -= quantity;
                    user.Balance -= validItems.Price * quantity;
                    return Message.Bought;
                }

                if (validItems.Quantity == 0)
                {
                    return Message.SoldOut;
                }

                return Message.TooHigh;
            }

            return Message.NotFound;
        }

        public string AddItem(string name, int quantity)
        {
            var validItems = Items.Find(item =>
                item.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (validItems != null)
            {
                validItems.Quantity += quantity;

                return Message.Added;
            }

            return Message.NotFound;
        }
    }
}