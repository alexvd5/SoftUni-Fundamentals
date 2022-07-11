using System;

namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            VolewsCointains(text);
        }

        static void VolewsCointains(string text)
        {
            //a, e, i, o, u - vowels
            int vowelsSum = 0;
            char[] secondText = text.ToLower().ToCharArray();

            for (int i = 0; i < text.Length; i++)
            {
                if (secondText[i] == 'a')
                {
                    vowelsSum++;
                }
                else if (secondText[i] == 'e')
                {
                    vowelsSum++;
                }
                else if (secondText[i] == 'i')
                {
                    vowelsSum++;
                }
                else if (secondText[i] == 'o')
                {
                    vowelsSum++;
                }
                else if (secondText[i] == 'u')
                {
                    vowelsSum++;
                }
            }
            Console.WriteLine(vowelsSum);

        }
    }
}
