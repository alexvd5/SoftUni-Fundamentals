using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] command = Console.ReadLine().Split();
            bool listIsChanged = false;

            while (command[0] != "end")
            {
                if (command[0] == "Add")
                {
                    numbers.Add(int.Parse(command[1]));
                    listIsChanged = true;
                }
                else if (command[0] == "Remove")
                {
                    numbers.Remove(int.Parse(command[1]));
                    listIsChanged = true;
                }
                else if (command[0] == "RemoveAt")
                {
                    numbers.RemoveAt(int.Parse(command[1]));
                    listIsChanged = true;
                }
                else if (command[0] == "Insert")
                {
                    numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                    listIsChanged = true;
                }
                else if (command[0] == "Contains")
                {
                    if (numbers.Contains(int.Parse(command[1])))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (command[0] == "PrintEven")
                {
                    List<int> evenNumbers = new List<int>();
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 0)
                        {
                            evenNumbers.Add(numbers[i]);
                        }
                    }
                    Console.WriteLine(string.Join(" ", evenNumbers));
                }
                else if (command[0] == "PrintOdd")
                {
                    List<int> oddNumbers = new List<int>();
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 != 0)
                        {
                            oddNumbers.Add(numbers[i]);
                        }
                    }
                    Console.WriteLine(string.Join(" ", oddNumbers));
                }
                else if (command[0] == "GetSum")
                {
                    int sum = numbers.Sum();
                    Console.WriteLine(sum);
                }
                else if (command[0] == "Filter")
                {
                    switch (command[1])
                    {
                        case "<":
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] < int.Parse(command[2]))
                                {
                                    Console.Write($"{numbers[i]} ");
                                }
                            }
                            Console.WriteLine();
                            break;
                        case ">":
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] > int.Parse(command[2]))
                                {
                                    Console.Write($"{numbers[i]} ");
                                }
                            }
                            Console.WriteLine();
                            break;
                        case ">=":
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] >= int.Parse(command[2]))
                                {
                                    Console.Write($"{numbers[i]} ");
                                }
                            }
                            Console.WriteLine();
                            break;
                        case "<=":
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] > int.Parse(command[2]))
                                {
                                    Console.Write($"{numbers[i]} ");
                                }
                            }
                            Console.WriteLine();
                            break;
                        default:
                            break;
                    }
                }

                command = Console.ReadLine().Split();
            }

            if (listIsChanged)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
