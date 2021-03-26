using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShopApp
{
    public class Message
    {
        public const string Welcome = "==========================================" + "\n" + "\tWelcome to the Console Shop!" + 
            "\n" + "==========================================" + "\n" + "\n" + "\n" + "Type \"commands\" or \"exit\":" +
            "\n" + "\n" + "\n";
        public const string Commands = "\n" + "1. itemlist - shows available items in the shop" + "\n" + "2. buy" + "\n" + "3. add" + "\n" + 
            "4. balance" + "\n" + "5. topup" + "\n" + "\n";
        public const string UndefinedCommand = "\n" + "Inccorect command, please try again!" + "\n" + "\n";
        public const string ItemAdded = "Item was successfully added!";
        public const string ItemNotAdded = "Item not found!";
        public const string ItemBought = "Item was successfully bought!";
    }
}
