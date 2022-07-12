using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Gauss__Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int numberCount = numbers.Count;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                int currentNum = numbers[i];
                int lastNum = numbers[numberCount - 1];

                if (numberCount - i == 1)
                {
                    currentNum = numbers[i];                   
                    Console.Write($"{currentNum} ");
                    break;
                }              
                currentNum += lastNum;
                numberCount--;
                Console.Write($"{currentNum} ");               
            }
            
        }
    }
}
