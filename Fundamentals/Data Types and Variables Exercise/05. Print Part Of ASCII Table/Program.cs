using System;

namespace _05._Print_Part_Of_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int character = start; character <= end; character++)
            {
                Console.Write($"{(char)character} ");
            }
        }
    }
}
