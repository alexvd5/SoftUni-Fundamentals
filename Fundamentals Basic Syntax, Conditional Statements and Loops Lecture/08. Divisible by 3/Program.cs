﻿using System;

namespace _08._Divisible_by_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 3; i <= 99; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}