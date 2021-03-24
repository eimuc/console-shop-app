using System;

namespace ConsoleShopApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var shop = new Shop();
            var user = new User(400);
            var item1 = new Item("Book", 10.99M, 3);
            var item2 = new Item("Cup", 2.5M, 10);
            var item3 = new Item("Pencils", 0.99M, 45);
            var printer = new Printer();
            var runApp = true;

            while (runApp)
            {
                try
                {
                    printer.Print(Message.Welcome);

                    Console.WriteLine();
                    Console.WriteLine(item1.GetInfo());
                    Console.WriteLine(item2.GetInfo());
                    Console.WriteLine(item3.GetInfo());
                    Console.WriteLine();
                    Console.WriteLine(user.Balance);
                    Console.ReadLine();
                }
                catch (Exception e)
                {
                    runApp = false;
                    Console.WriteLine(e);
                }
            }
        }
    }
}
