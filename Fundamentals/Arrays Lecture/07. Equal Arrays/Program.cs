using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            bool isIdentical = true;

            for (int i = 0; i < firstArray.Length; i++)
            {

                for (int j = 0; j < secondArray.Length; j++)
                {
                    if (firstArray[i] != secondArray[j])
                    {
                        Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                        isIdentical = false;
                        return;
                    }
                    else
                    {
                        sum += firstArray[i];
                    }
                    i++;
                }
            }
            if (isIdentical)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}
