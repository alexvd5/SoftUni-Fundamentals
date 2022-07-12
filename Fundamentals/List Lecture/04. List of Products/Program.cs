using System;
using System.Collections.Generic;

namespace _04._List_of_Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<string> products = new List<string>();

            for (int i = 1; i <= lines; i++)
            {
                string product = Console.ReadLine();
                products.Add(product);             
            }
            products.Sort();

            int counter = 1;
            foreach (var product in products)
            {
                Console.WriteLine($"{counter}.{product}");
                counter++;
            }
            

        }
    }
}
