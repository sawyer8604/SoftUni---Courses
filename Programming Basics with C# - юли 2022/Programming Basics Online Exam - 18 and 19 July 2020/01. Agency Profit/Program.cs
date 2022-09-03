using System;

namespace _01._Agency_Profit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfAvioCompany = Console.ReadLine();
            int numberOfticketsForOld = int.Parse(Console.ReadLine());
            int numberOfticketsForChild = int.Parse(Console.ReadLine());
            double priceOfTichketsForOld = double.Parse(Console.ReadLine());
            double priceForService = double.Parse(Console.ReadLine());

            double priceForChild = priceOfTichketsForOld * 0.3;

            double allPriceForOld = numberOfticketsForOld * priceOfTichketsForOld;

            double allPriceForChild = numberOfticketsForChild * priceForChild;

            priceForService = (numberOfticketsForOld + numberOfticketsForChild) * priceForService;

            double allTicketPrice = (allPriceForOld + allPriceForChild + priceForService) * 0.2;

            Console.WriteLine($"The profit of your agency from {nameOfAvioCompany} tickets is {allTicketPrice:f2} lv.");

        }
    }
}
