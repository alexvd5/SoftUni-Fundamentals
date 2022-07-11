using System;

namespace _02._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int originalNumber = int.Parse(Console.ReadLine());
            int number = originalNumber;
            int sum = 0;

            for (int i = 0; i <= originalNumber; i++)
            {
                int lastDigit = number % 10;
                sum += lastDigit;
                number /= 10;

            }
            Console.WriteLine(sum);
        }
    }
}
