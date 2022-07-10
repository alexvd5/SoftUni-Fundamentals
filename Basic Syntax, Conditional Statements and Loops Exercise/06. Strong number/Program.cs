﻿using System;

namespace _06._Strong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int numberCopy = number;
            int sum = 0;

            // 145 => 1, 4, 5

            while (number > 0)
            {
                int factorialNumber = 1;
                int currNumber = number % 10; // взимаме цифрата 5;
                number /= 10; // премахваме цифрата 5 и остава само 14;

                for (int i = 2; i <= currNumber; i++)
                {
                    factorialNumber *= i;
                }
                sum += factorialNumber;
            }

            Console.WriteLine(sum == numberCopy ? "yes" : "no");

        }
    }
}
