using System;

namespace _07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double coinsSum = 0.0;
            double coins = 0.0;

            while (command != "End")
            {
                if (command != "Start")
                {
                    coins = double.Parse(command);

                    if (coins != 0.1 && coins != 0.2
                        && coins != 0.5 && coins != 1
                        && coins != 2)
                    {
                        Console.WriteLine($"Cannot accept {coins}");
                        command = Console.ReadLine();
                        continue;
                    }
                    coinsSum += coins;

                    if (command != "Start")
                    {
                        command = Console.ReadLine();
                        continue;
                    }
                }

                string secondCommand = command;

                while (command == "Start")
                {
                    secondCommand = Console.ReadLine();
                    if (secondCommand == "End")
                    {
                        command = secondCommand;
                        break;
                    }
                    string products = secondCommand;
                    double productPrice = 0.0;
                    string productName = string.Empty;

                    switch (products)
                    {
                        case "Nuts":
                            productPrice = 2.0;
                            productName = "nuts";
                            break;
                        case "Water":
                            productPrice = 0.7;
                            productName = "water";
                            break;
                        case "Crisps":
                            productPrice = 1.5;
                            productName = "crisps";
                            break;
                        case "Soda":
                            productPrice = 0.8;
                            productName = "soda";
                            break;
                        case "Coke":
                            productPrice = 1.0;
                            productName = "coke";
                            break;
                        default:
                            Console.WriteLine("Invalid product");
                            break;
                    }

                    if (coinsSum >= productPrice)
                    {
                        if (productPrice <= 0)
                            continue;
                        Console.WriteLine($"Purchased {productName}");
                        coinsSum -= productPrice;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }

                }

            }
            double change = coinsSum;
            Console.WriteLine($"Change: {change:f2}");
        }
    }
}
