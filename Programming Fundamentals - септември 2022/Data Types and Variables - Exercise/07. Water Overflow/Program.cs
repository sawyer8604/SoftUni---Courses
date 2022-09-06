using System;

namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int waterThank = 255;
            int numberOfLines = int.Parse(Console.ReadLine());
            int sumOfAllWaters = 0;

            for (int i = 0; i < numberOfLines; i++)
            {
                int quantitiesOfWater = int.Parse(Console.ReadLine());

                if (quantitiesOfWater <= waterThank)
                {
                    waterThank -= quantitiesOfWater;
                    sumOfAllWaters += quantitiesOfWater;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }

            Console.WriteLine(sumOfAllWaters);
        }
    }
}
