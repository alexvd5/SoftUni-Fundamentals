using System;

namespace Fund_Data_Types_and_Variables_EX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int fourthNum = int.Parse(Console.ReadLine());

            int sum = ((firstNum + secondNum) / thirdNum) * fourthNum;

            Console.WriteLine(sum);
        }
    }
}
