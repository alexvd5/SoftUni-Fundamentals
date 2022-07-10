using System;

namespace _11._MultiplicTable2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());

            do
            {
                int outPut = input * multiplier;
                Console.WriteLine($"{input} X {multiplier} = {outPut}");
                multiplier++;

            } while (multiplier <= 10);
        }
    }
}
