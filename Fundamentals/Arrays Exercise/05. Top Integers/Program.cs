using System;
using System.Linq;

namespace _05._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int index = 0; index < numbers.Length; index++)
            {
                bool currIterattionNumIsBigger = true;

                for (int nextindex = index + 1; nextindex < numbers.Length; nextindex++)
                {
                    if (numbers[index] <= numbers[nextindex])
                    {
                        currIterattionNumIsBigger = false;
                        break;
                    }
                }

                if (currIterattionNumIsBigger)
                {
                    Console.Write($"{numbers[index]} ");
                }

            }

        }
    }
}
