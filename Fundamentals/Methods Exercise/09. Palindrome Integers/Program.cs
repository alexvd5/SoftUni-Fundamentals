using System;

namespace _09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            while (command != "END")
            {
                bool isIntegerPalindrome = IsNumberPalindrom(command);
                Console.WriteLine(isIntegerPalindrome.ToString().ToLower());
                command = Console.ReadLine();
            }
        }

        static bool IsNumberPalindrom(string command)
        {
            int number = int.Parse(command);
            if (number >= 0 && number <= 9)
            {
                return true;
            }

            if (command[0] == command[command.Length - 1]) return true;

            return false;
        }
    }
}
