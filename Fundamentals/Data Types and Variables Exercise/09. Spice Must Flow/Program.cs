using System;

namespace _09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfSpices = int.Parse(Console.ReadLine());
            int dayCount = 0;
            const int miningCrewConsumes = 26;
            const int minimumSpicesToGather = 100;
            const int dailyDecreesOfMineYield = 10;
            int totalSpiceExtracted = 0;

            while (countOfSpices >= minimumSpicesToGather)
            {
                totalSpiceExtracted += countOfSpices - miningCrewConsumes;
                countOfSpices -= dailyDecreesOfMineYield;
                dayCount++;
                if (countOfSpices < minimumSpicesToGather)
                {
                    totalSpiceExtracted -= miningCrewConsumes;
                }
            }

            Console.WriteLine(dayCount);
            Console.WriteLine(totalSpiceExtracted);
        }
    }
}
