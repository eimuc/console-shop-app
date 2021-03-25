using System;

namespace ConsoleShopApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var shop = new Shop();
            shop.Items.Add(new Item("Book", 10.99M, 3));
            shop.Items.Add(new Item("Cup", 3.50M, 10));
            shop.Items.Add(new Item("Pencil", 0.89M, 40));
            var user = new User(400);
            var printer = new Printer();
            var runApp = true;
            var welcomeMessage = true;
            string command;

            while (runApp)
            {
                try
                {

                    if (welcomeMessage) printer.Print(Message.Welcome);
                    command = Console.ReadLine().ToLower();

                    switch (command)
                    {
                        case "exit":
                            runApp = false;
                            welcomeMessage = false;
                            break;
                        case "commands":
                            printer.Print(Message.Commands);
                            welcomeMessage = false;
                            break;
                        case "itemlist":
                            printer.Print(shop.Itemlist());
                            welcomeMessage = false;
                            break;
                        case "buy":
                            break;
                        default:
                            throw new ArgumentException();
                    }
                }
                catch (ArgumentException e)
                {
                    printer.Print(Message.UndefinedCommand);
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
