using System;
using System.Linq;

namespace _03._Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} => {(int)Math.Round(arr[i], MidpointRounding.AwayFromZero)}");
                Console.WriteLine();
            }
        }
    }
}
