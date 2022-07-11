using System;

namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());

            Console.WriteLine($"{FactorialDivisionSum(firstNum, secondNum):f2}");

        }

        static double FactorialDivisionSum(double firstNum, double secondNum)
        {
            double firstFactoriel = 1;
            double secondFactoriel = 1;

            for (int i = 1; i <= firstNum; i++)
            {
                firstFactoriel *= i;
            }

            for (int i = 1; i <= secondNum; i++)
            {
                secondFactoriel *= i;
            }

            return firstFactoriel / secondFactoriel;

        }
    }
}
