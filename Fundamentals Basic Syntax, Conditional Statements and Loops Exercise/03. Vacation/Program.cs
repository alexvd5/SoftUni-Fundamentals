using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string stayingDay = Console.ReadLine();
            double priceForOnePerson = 0.0;
            double discount = 0.0;
            double totalPrice = 0.0;

            switch (stayingDay)
            {
                case "Friday":
                    switch (groupType)
                    {
                        case "Students":
                            priceForOnePerson = 8.45;
                            totalPrice = people * priceForOnePerson;
                            if (people >= 30)
                            {
                                discount = totalPrice * 0.15;
                                totalPrice -= discount;
                            }
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                            break;

                        case "Business":
                            priceForOnePerson = 10.90;
                            totalPrice = people * priceForOnePerson;
                            if (people >= 100)
                            {
                                discount = people * 10;
                                totalPrice /= (int)discount;
                            }
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                            break;

                        case "Regular":
                            priceForOnePerson = 15;
                            totalPrice = people * priceForOnePerson;
                            if (people >= 10 && people <= 20)
                            {
                                discount = totalPrice * 0.05;
                                totalPrice -= discount;
                            }
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                            break;
                    }
                    break;

                case "Saturday":
                    switch (groupType)
                    {
                        case "Students":
                            priceForOnePerson = 9.80;
                            totalPrice = people * priceForOnePerson;
                            if (people >= 30)
                            {
                                discount = totalPrice * 0.15;
                                totalPrice -= discount;
                            }
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                            break;

                        case "Business":
                            priceForOnePerson = 15.60;
                            totalPrice = people * priceForOnePerson;
                            if (people >= 100)
                            {
                                discount = people * 10;
                                totalPrice /= (int)discount;
                            }
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                            break;

                        case "Regular":
                            priceForOnePerson = 20;
                            totalPrice = people * priceForOnePerson;
                            if (people >= 10 && people <= 20)
                            {
                                discount = totalPrice * 0.05;
                                totalPrice -= discount;
                            }
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                            break;
                    }
                    break;

                case "Sunday":
                    switch (groupType)
                    {
                        case "Students":
                            priceForOnePerson = 10.46;
                            totalPrice = people * priceForOnePerson;
                            if (people >= 30)
                            {
                                discount = totalPrice * 0.15;
                                totalPrice -= discount;
                            }
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                            break;

                        case "Business":
                            priceForOnePerson = 16;
                            totalPrice = people * priceForOnePerson;
                            if (people >= 100)
                            {
                                discount = people * 10;
                                totalPrice /= (int)discount;
                            }
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                            break;

                        case "Regular":
                            priceForOnePerson = 22.50;
                            totalPrice = people * priceForOnePerson;
                            if (people >= 10 && people <= 20)
                            {
                                discount = totalPrice * 0.05;
                                totalPrice -= discount;
                            }
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                            break;
                    }
                    break;
            }
        }
    }
}
