using System;

namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int result = FirstTwoSum(firstNum, secondNum);

            Console.WriteLine(Substract(result, thirdNum));

        }

        static int Substract(int result, int thirdNum)
        {
            int finalResult = result - thirdNum;
            return finalResult;
        }

        static int FirstTwoSum(int firstNum, int secondNum)
        {
            int result = firstNum + secondNum;
            return result;
        }
    }
}
