using System;

namespace _04._Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] symbols = Console.ReadLine().Split();
            //Array.Reverse(symbols);
            //Console.Write(string.Join(" ",symbols));

            for (int i = symbols.Length - 1; i >= 0; i--)
            {
                string currentEl = symbols[i];
                Console.Write($"{currentEl} ");
            }
        }
    }
}
