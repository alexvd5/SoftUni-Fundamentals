using System;

namespace _09._Sum_ofOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int oddNum = 1 + (i * 2);
                Console.WriteLine(oddNum);
                sum += oddNum;
            }
            Console.WriteLine($"Sum: {sum}");

        }
    }
}
