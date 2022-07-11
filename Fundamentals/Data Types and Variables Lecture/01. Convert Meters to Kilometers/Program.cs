using System;

namespace Fund_Data_Types_and_Variables_Lection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int metres = int.Parse(Console.ReadLine());
            double kilometres = (double)metres / 1000;
            Console.WriteLine($"{kilometres:f2}");
        }
    }
}
