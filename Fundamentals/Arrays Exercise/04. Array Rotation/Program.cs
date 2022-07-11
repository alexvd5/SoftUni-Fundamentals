using System;
using System.Linq;

namespace _04._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());

            for (int rotation = 0; rotation < rotations; rotation++)
            {
                int tempEl = array[0];
                for (int index = 0; index < array.Length - 1; index++)
                {
                    array[index] = array[index + 1];
                }

                array[array.Length - 1] = tempEl;
            }
            Console.WriteLine(String.Join(" ", array));

        }
    }
}
