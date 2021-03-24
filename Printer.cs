using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShopApp
{
    public class Printer
    {
        public string message = "yo";
        public void Print(string text)
        {
            Console.Write($"{text}");
        }
    }
}
