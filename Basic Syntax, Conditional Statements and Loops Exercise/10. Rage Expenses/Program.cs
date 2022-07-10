using System;

namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostgameCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headsetTrashesCount = 0;
            int mouseTrashesCount = 0;
            int keyboardTrashesCount = 0;
            int displayTrashesCount = 0;

            for (int i = 1; i <= lostgameCount; i++)
            {
                if (i % 2 == 0)
                {
                    headsetTrashesCount++;
                }

                if (i % 3 == 0)
                {
                    mouseTrashesCount++;
                }

                if (i % 2 == 0 && i % 3 == 0)
                {
                    keyboardTrashesCount++;
                    if (keyboardTrashesCount % 2 == 0)
                    {
                        displayTrashesCount++;
                    }
                }

            }

            double renewHeadsetPrice = headsetTrashesCount * headsetPrice;
            double renewMousePrice = mouseTrashesCount * mousePrice;
            double renewKeyboardPrice = keyboardTrashesCount * keyboardPrice;
            double renewDisplayPrice = displayTrashesCount * displayPrice;

            double totalRenewPrice = renewHeadsetPrice + renewMousePrice +
                renewKeyboardPrice + renewDisplayPrice;

            Console.WriteLine($"Rage expenses: {totalRenewPrice:f2} lv.");

        }
    }
}
