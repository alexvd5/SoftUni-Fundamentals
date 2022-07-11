using System;

namespace _11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            int secondNum = int.Parse(Console.ReadLine());
            Console.WriteLine(Calculate(firstNum, operation, secondNum));
        }

        static double Calculate(int firstNum, string operation, int secondNum)
        {
            double result = 0;

            switch (operation)
            {
                case "/":
                    result = (double)firstNum / secondNum;
                    break;
                case "*":
                    result = firstNum * secondNum;
                    break;
                case "+":
                    result = firstNum + secondNum;
                    break;
                case "-":
                    result = firstNum - secondNum;
                    break;
            }
            return result;
        }
    }
}
