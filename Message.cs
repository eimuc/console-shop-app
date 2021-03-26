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
        public const string Commands = "\n1. itemlist\n2. buy name quantity\n3. add name quantity\n" +
            "4. balance\n5. topup quantity\n\n";
        public const string UndefinedCommand = "\nInccorect command, please try again!\n";
        public const string Added = "\nItem was successfully added!\n";
        public const string NotFound = "\nItem not found!\n";
        public const string Bought = "\nItem was successfully bought!\n";
        public const string InvalidBalance = "\nYour balance is 0 :(\n";
        public const string SoldOut = "\nSorry, item was sold out...\n";
        public const string TooHigh = "\nQuantity you have entered is too high!\n";
        public const string Topup = "\nYour balance was topped up!\n";
        public const string InvalidTopup = "\nWrong quantity!\n";
    }
}
