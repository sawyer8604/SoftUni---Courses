using System;

namespace _10._Odd_Even_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < number; i++)
            {
                int curentNumer = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += curentNumer;

                }
                else
                {
                    oddSum += curentNumer;

                }
            }
            if (evenSum == oddSum)
            {
                Console.WriteLine($"Yes\r\nSum = {evenSum}");
            }
            else
            {
                Console.WriteLine($"No\r\nDiff = {Math.Abs(oddSum - evenSum)}");
            }




        }
    }
}
