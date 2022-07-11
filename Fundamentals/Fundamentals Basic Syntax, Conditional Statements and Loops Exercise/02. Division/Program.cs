using System;

namespace _02._Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (num % 10 == 0)
            {
                int divisibleNumer = 10;
                Console.WriteLine($"The number is divisible by {divisibleNumer}");
            }
            else if (num % 7 == 0)
            {
                int divisibleNumer = 7;
                Console.WriteLine($"The number is divisible by {divisibleNumer}");
            }
            else if (num % 6 == 0)
            {
                int divisibleNumer = 6;
                Console.WriteLine($"The number is divisible by {divisibleNumer}");
            }
            else if (num % 3 == 0)
            {
                int divisibleNumer = 3;
                Console.WriteLine($"The number is divisible by {divisibleNumer}");
            }
            else if (num % 2 == 0)
            {
                int divisibleNumer = 2;
                Console.WriteLine($"The number is divisible by {divisibleNumer}");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }

        }
    }
}
