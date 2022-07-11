using System;
using System.Numerics;

namespace _11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfBalls = int.Parse(Console.ReadLine());
            BigInteger snowballValue = 0;
            BigInteger highestBallValue = int.MinValue;
            BigInteger highestSnowballSnow = 0;
            BigInteger highestSnowballTime = 0;
            BigInteger highestSnowballQuality = 0;


            for (int i = 0; i < numberOfBalls; i++)
            {
                BigInteger snowballSnow = BigInteger.Parse(Console.ReadLine());
                BigInteger snowballTime = BigInteger.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                BigInteger snowballValueSum = snowballSnow / snowballTime;
                snowballValue = BigInteger.Pow(snowballValueSum, snowballQuality);

                if (snowballValue >= highestBallValue)
                {
                    highestBallValue = snowballValue;
                    highestSnowballSnow = snowballSnow;
                    highestSnowballTime = snowballTime;
                    highestSnowballQuality = snowballQuality;
                }

            }
            Console.WriteLine($"{highestSnowballSnow} : {highestSnowballTime} = {highestBallValue} ({highestSnowballQuality})");

        }
    }
}
