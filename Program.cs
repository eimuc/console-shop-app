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
            var runApp = true;
            var welcomeMessage = true;
            string input;
            string[] commands;

            while (runApp)
            {
                try
                {
                    if (welcomeMessage) Console.WriteLine(Message.Welcome);
                    input = Console.ReadLine().ToLower();
                    commands = input.Split(" ");
                    input = commands[0];

                    switch (commands[0])
                    {
                        case "exit":
                            runApp = false;
                            welcomeMessage = false;
                            break;
                        case "commands":
                            Console.WriteLine(Message.Commands);
                            welcomeMessage = false;
                            break;
                        case "itemlist":
                            Console.WriteLine(shop.ListItem());
                            welcomeMessage = false;
                            break;
                        case "buy":
                            var buyName = commands[1];
                            var buyQuantity = int.Parse(commands[2]);
                            shop.BuyItem(user, buyName, buyQuantity);
                            Console.WriteLine(Message.Bought);
                            welcomeMessage = false;
                            break;
                        case "add":
                            var addName = commands[1];
                            var addQuantity = int.Parse(commands[2]);
                            Console.WriteLine(shop.AddItem(addName, addQuantity));
                            welcomeMessage = false;
                            break;
                        case "balance":
                            Console.WriteLine($"\nYour balance:\t{user.Balance}\n");
                            welcomeMessage = false;
                            break;
                        case "topup":
                            var topup = decimal.Parse(commands[1]);
                            Console.WriteLine(user.Topup(user, topup));
                            welcomeMessage = false;
                            break;
                        default:
                            throw new ArgumentException();
                    }
                }
                catch (ArgumentException e)
                {
                    welcomeMessage = false;
                    Console.WriteLine(Message.UndefinedCommand);
                }
                catch (Exception e)
                {
                    welcomeMessage = false;
                    runApp = false;
                    Console.WriteLine(e);
                }
            }
        }
    }
}
