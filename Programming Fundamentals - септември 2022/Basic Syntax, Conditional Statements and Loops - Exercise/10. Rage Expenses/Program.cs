using System;

namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfLostGame = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headsetCounter = 0;
            int mouseCounter = 0;
            int keyboardCounter = 0;
            int displayCounter = 0;
            int keyboardCounterForDisplay = 0;

            double allPrice = 0;
                                

            for (int i = 1; i <= countOfLostGame; i++)
            {
                if (i % 2 == 0 )
                {
                    headsetCounter++;
                }
                if (i % 3 == 0)
                {
                    mouseCounter++;
                }
                if (i % 2 == 0 && i % 3 == 0)
                {
                    keyboardCounter++;
                    keyboardCounterForDisplay++;
                }
                if (keyboardCounterForDisplay == 2)
                {

                    displayCounter++;
                    keyboardCounterForDisplay = 0;


                }

            }

            allPrice = headsetCounter * headsetPrice + mouseCounter * mousePrice + keyboardCounter * keyboardPrice + displayCounter * displayPrice;
            Console.WriteLine($"Rage expenses: {allPrice:f2} lv.");
        }
    }
}
