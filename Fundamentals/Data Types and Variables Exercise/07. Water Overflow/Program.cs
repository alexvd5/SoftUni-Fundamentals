using System;

namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            const int waterTankCapacity = 255;
            int totalWaterPoured = 0;

            for (int i = 0; i < lines; i++)
            {
                int waterToPour = int.Parse(Console.ReadLine());
                totalWaterPoured += waterToPour;

                if (totalWaterPoured > waterTankCapacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    totalWaterPoured -= waterToPour;
                    continue;
                }

            }
            Console.WriteLine(totalWaterPoured);
        }
    }
}
