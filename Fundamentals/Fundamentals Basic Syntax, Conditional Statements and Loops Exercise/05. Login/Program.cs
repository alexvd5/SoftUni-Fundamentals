using System;

namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = "";
            string inputPassword = Console.ReadLine();
            int incorrectPassCount = 0;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }

            while (inputPassword != password)
            {

                incorrectPassCount++;

                if (incorrectPassCount >= 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }

                Console.WriteLine("Incorrect password. Try again.");

                inputPassword = Console.ReadLine();
            }

            if (inputPassword == password)
                Console.WriteLine($"User {username} logged in.");

        }
    }
}
