using System;

namespace _08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfKegs = int.Parse(Console.ReadLine());

            double biggestKeg = double.MinValue;
            string biggestKegName = "";

            for (int i = 0; i < numberOfKegs; i++)
            {
                string kegName = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double kegVolume = Math.PI * Math.Pow(radius, 2) * height;

                if (kegVolume > biggestKeg)
                {
                    biggestKeg = kegVolume;
                    biggestKegName = kegName;
                }
            }
            Console.WriteLine(biggestKegName);

        }
    }
}
