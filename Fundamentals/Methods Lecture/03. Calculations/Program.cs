using System;

namespace _03._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string action = Console.ReadLine();
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());


            ActionCalculate(action, firstNumber, secondNumber);

        }

        private static void ActionCalculate(string todo, int first, int second)
        {
            int sum = 0;
            switch (todo)
            {
                case "add":
                    sum = first + second;
                    break;
                case "multiply":
                    sum = first * second;
                    break;
                case "substract":
                    sum = first - second;
                    break;
                case "divide":
                    sum = first / second;
                    break;
            }
            Console.WriteLine(sum);
        }

    }
}
