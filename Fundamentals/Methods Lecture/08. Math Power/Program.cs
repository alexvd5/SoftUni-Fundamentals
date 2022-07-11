using System;

namespace _08._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            Console.WriteLine(Raise(first, second));
        }

        static double Raise(double firstNum, double secondNum)
        {
            return Math.Pow(firstNum, secondNum);
        }
    }
}
