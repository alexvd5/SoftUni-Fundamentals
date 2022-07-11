using System;

namespace _05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            CalculateOrder(product, quantity);
        }

        static void CalculateOrder(string name, int quantityy)
        {
            double productPrice = 0;
            double totalPrice = 0;
            switch (name)
            {
                case "coffee":
                    productPrice = 1.50;
                    break;
                case "water":
                    productPrice = 1.00;
                    break;
                case "coke":
                    productPrice = 1.40;
                    break;
                case "snacks":
                    productPrice = 2.00;
                    break;
            }
            totalPrice = productPrice * quantityy;
            Console.WriteLine($"{totalPrice:f2}");
        }

    }
}
