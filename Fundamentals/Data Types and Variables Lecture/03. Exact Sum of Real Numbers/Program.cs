using System;

namespace _03._Exact_Sum_of_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numbers = double.Parse(Console.ReadLine());
            decimal sum = 0m;
            for (int i = 1; i <= numbers; i++)
            {
                decimal numS = decimal.Parse(Console.ReadLine());
                sum += numS;
            }
            Console.WriteLine($"{sum}");
        }
    }
}
