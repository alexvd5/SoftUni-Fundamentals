using System;

namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());

            for (int i = 0; i < end; i++)
            {
                if (SumOfDigits(i) && OddDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool SumOfDigits(int number)
        {
            int sumOfDigits = 0;

            //int lastDigit = number % 10;
            //number /= 10;
            //sumOfDigits += lastDigit;

            string numbers = number.ToString();
            for (int i = 0; i < numbers.Length; i++)
            {
                int digit = numbers[i];
                sumOfDigits += digit;
            }

            if (sumOfDigits % 8 != 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        static bool OddDigit(int number)
        {
            int oddDigitCount = 0;
            string numbers = number.ToString();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    oddDigitCount++;
                }
            }

            if (oddDigitCount < 1)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
