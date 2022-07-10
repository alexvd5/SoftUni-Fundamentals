using System;

namespace _09._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double priceOfSaber = double.Parse(Console.ReadLine());
            double priceOfRobe = double.Parse(Console.ReadLine());
            double priceOfBelts = double.Parse(Console.ReadLine());

            double totalSabers = Math.Ceiling(studentsCount * 1.10);
            // взимаме още 10 процента отгоре по условие.
            double totalBelts = studentsCount;
            double freeBeltsCount = 0;

            for (int i = 6; i <= totalBelts; i += 6)
            {
                freeBeltsCount++;
            }

            double beltsToBuy = totalBelts - freeBeltsCount;
            double robesToBuy = studentsCount;

            double totalBeltsPrice = beltsToBuy * priceOfBelts;
            double totalSabersPrice = totalSabers * priceOfSaber;
            double totalRobesPrice = robesToBuy * priceOfRobe;

            double totalPriceForEquipment = totalBeltsPrice + totalSabersPrice + totalRobesPrice;

            if (budget >= totalPriceForEquipment)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPriceForEquipment:f2}lv.");
            }
            else
            {
                double neededMoney = Math.Abs(budget - totalPriceForEquipment);
                Console.WriteLine($"John will need {neededMoney:f2}lv more.");
            }
        }
    }
}
