using System;

namespace _04._Transport_Price
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kilometres = int.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();

            if (kilometres >= 100)
            {
                double priceForTrain = kilometres * 0.06;
                Console.WriteLine($"{priceForTrain:f2}");
            }
            else if (kilometres < 20)
            {
                double priceWithTaxi = 0;

                if (dayOrNight == "day")
                {
                    priceWithTaxi = kilometres * 0.79 + 0.7;
                }
                else if (dayOrNight == "night")
                {
                    priceWithTaxi = kilometres * 0.9 + 0.7;

                }
                Console.WriteLine($"{priceWithTaxi:f2}");

            }
            else
            {
                double priceForBus = kilometres * 0.09;
                Console.WriteLine($"{priceForBus:f2}");
            }

        }
    }
}
