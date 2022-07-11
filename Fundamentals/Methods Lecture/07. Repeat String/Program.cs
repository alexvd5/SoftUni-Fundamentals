using System;

namespace _07._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            for (int j = 0; j < count; j++)
            {
                Console.Write(RepeatString(text, count));
            }
        }

        static string RepeatString(string symbols, int number)
        {
            string result = string.Empty;

            for (int i = 0; i < number; i++)
            {
                result = symbols;
            }
            return result;

        }
    }
}
