using System;

namespace _03._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleNum = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());
            double withReminderCourses = (double)peopleNum / elevatorCapacity;

            Console.WriteLine(Math.Ceiling(withReminderCourses));

        }
    }
}
