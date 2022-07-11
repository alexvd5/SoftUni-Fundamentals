using System;

namespace _02._Pounds_to_Dollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal britishPound = decimal.Parse(Console.ReadLine());
            decimal usDollars = britishPound * (decimal)1.31;
            Console.WriteLine($"{usDollars:f3}");

        }
    }
}
