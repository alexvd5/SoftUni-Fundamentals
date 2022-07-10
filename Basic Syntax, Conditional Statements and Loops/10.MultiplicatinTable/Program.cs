using System;

namespace _10.MultiplicatinTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int outPut = input * i;
                Console.WriteLine($"{input} X {i} = {outPut}");
            }
        }
    }
}
