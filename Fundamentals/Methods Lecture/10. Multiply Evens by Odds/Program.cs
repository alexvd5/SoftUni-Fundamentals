using System;

namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sumOfEven = GetSumOfEven(Math.Abs(number));
            int sumOfOdd = GetSumOfOdd(Math.Abs(number));
            int result = GetMultipleOfEvenAndOdds(sumOfEven, sumOfOdd);
            Console.WriteLine(result);
        }

        static int GetSumOfOdd(int number)
        {
            int sum = 0;
            int digits = number;

            while (digits > 0)
            {
                int currentDigit = digits % 10;
                if (currentDigit % 2 != 0)
                {
                    sum += currentDigit;
                }

                digits = (digits / 10);
            }

            return sum;
        }

        static int GetSumOfEven(int number)
        {

            int sum = 0;
            int digits = number;

            while (digits > 0)
            {
                int currentDigit = digits % 10;
                if (currentDigit % 2 == 0)
                {
                    sum += currentDigit;
                }

                digits = (digits / 10);
            }

            return sum;
        }

        static int GetMultipleOfEvenAndOdds(int sumOfEven, int sumOfOdd)
        {
            int result = sumOfEven * sumOfOdd;
            return result;
        }
    }
}
