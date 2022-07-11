using System;

namespace Fund_Arrays_Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wagonsNum = int.Parse(Console.ReadLine());
            int[] wagons = new int[wagonsNum];
            int totalPassengers = 0;

            for (int i = 0; i < wagons.Length; i++)
            {
                wagons[i] = int.Parse(Console.ReadLine());
                totalPassengers += wagons[i];
            }

            foreach (var wagon in wagons)
            {
                Console.Write($"{wagon} ");
            }
            Console.WriteLine();
            Console.WriteLine(totalPassengers);

        }
    }
}
