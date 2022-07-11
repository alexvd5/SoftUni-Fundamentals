using System;

namespace Fund_Methods_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PosNegZero(n);

        }

        static void PosNegZero(int n)
        {
            if (n > 0)
            {
                Console.WriteLine($"The number {n} is positive.");
            }
            else if (n == 0)
            {
                Console.WriteLine($"The number {n} is zero.");
            }
            else if (n < 0)
            {
                Console.WriteLine($"The number {n} is negative.");
            }
        }

    }
}
