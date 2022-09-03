using System;

namespace _07._Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberOfvideocards = int.Parse(Console.ReadLine());
            int numberOfProcesors = int.Parse(Console.ReadLine());
            int numberOfRam = int.Parse(Console.ReadLine());

            double priceOfVideocards = numberOfvideocards * 250;
            double priceOfProcesors = (priceOfVideocards * 0.35) * numberOfProcesors;
            double priceOfRam = (priceOfVideocards * 0.1) * numberOfRam;

            double priceOfAll = priceOfVideocards + priceOfProcesors + priceOfRam;


            if (numberOfvideocards > numberOfProcesors)
            {

                priceOfAll = priceOfAll - priceOfAll * 0.15;
            }

            if (budget >= priceOfAll)
            {
                Console.WriteLine($"You have {budget - priceOfAll:f2} leva left!");
            }
            else
            {

                Console.WriteLine($"Not enough money! You need {priceOfAll - budget:f2} leva more!");
            }

        }
    }
}
