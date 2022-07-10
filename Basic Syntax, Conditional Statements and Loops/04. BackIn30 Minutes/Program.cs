using System;

namespace _04._BackIn30_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());
            int halfHourLater = 30;
            minute += halfHourLater;

            if (minute >= 60)
            {
                hour++;
                minute = minute - 60;
            }

            if (hour >= 24)
            {
                hour = 0;
            }

            Console.WriteLine($"{hour}:{minute:d2}");

        }
    }
}
