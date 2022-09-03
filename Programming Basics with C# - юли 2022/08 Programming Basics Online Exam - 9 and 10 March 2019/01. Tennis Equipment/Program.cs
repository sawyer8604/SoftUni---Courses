using System;

namespace _01._Tennis_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tennisRocketPrice = double.Parse(Console.ReadLine());
            int numberOfTennisRocket = int.Parse(Console.ReadLine());
            int numberOfSnikers = int.Parse(Console.ReadLine());

            double priceOfAllTenniRocket = tennisRocketPrice * numberOfTennisRocket;
            double priceOfSnikers = tennisRocketPrice / 6.0 * numberOfSnikers;
            double allPrice = priceOfAllTenniRocket + priceOfSnikers;
            allPrice = allPrice + allPrice * 0.2;

            double paindFromDjokovich = allPrice / 8;
            double paidFromSponsor = allPrice - paindFromDjokovich;

            Console.WriteLine($"Price to be paid by Djokovic {Math.Floor(paindFromDjokovich)}");
            Console.WriteLine($"Price to be paid by sponsors {Math.Ceiling(paidFromSponsor)}");
        }
    }
}
