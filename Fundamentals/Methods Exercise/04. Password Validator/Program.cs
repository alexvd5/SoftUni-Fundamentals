using System;

namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            if (PassLenght(password) &&
                PassLettersAndDigit(password)
                && PassDigitsNum(password))
            {
                Console.WriteLine("Password is valid");
            }

            if (!PassLenght(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!PassLettersAndDigit(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!PassDigitsNum(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }


        }

        static bool PassDigitsNum(string password)
        {
            int digitCount = 0;
            foreach (char symbol in password)
            {
                if (char.IsDigit(symbol))
                {
                    digitCount++;
                }
            }

            if (digitCount >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool PassLettersAndDigit(string password)
        {
            foreach (char symbol in password)
            {
                if (!char.IsLetterOrDigit(symbol))
                {
                    return false;
                }
            }
            return true;
        }

        static bool PassLenght(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
