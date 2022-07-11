using System;

namespace _12._Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nums = int.Parse(Console.ReadLine());
            int total = 0;
            int current = 0;
            bool isSpecial = false;
            for (int i = 1; i <= nums; i++)
            {
                current = i;

                while (i > 0)
                {
                    total += i % 10;
                    i = i / 10;
                }

                isSpecial = (total == 5) || (total == 7) || (total == 11);
                Console.WriteLine("{0} -> {1}", current, isSpecial);
                total = 0;
                i = current;
            }
        }
    }
}
