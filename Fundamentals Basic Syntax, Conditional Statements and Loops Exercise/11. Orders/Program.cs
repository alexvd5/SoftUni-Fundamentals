using System;

namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ordersReceived = int.Parse(Console.ReadLine());
            double orderPrice = 0;
            double totalPrice = 0;

            for (int i = 1; i <= ordersReceived; i++)
            {
                double capsulePrice = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());
                orderPrice = ((days * capsulesCount) * capsulePrice);
                totalPrice += orderPrice;
                Console.WriteLine($"The price for the coffee is: ${orderPrice:f2}");
            }

            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
