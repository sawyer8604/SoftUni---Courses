using System;

namespace _01_Easter_Bakery
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double priceOfFlour = double.Parse(Console.ReadLine());
            double flourKilos = double.Parse(Console.ReadLine());
            double sugarKilos = double.Parse(Console.ReadLine());
            int numberOfPeelEggs = int.Parse(Console.ReadLine());
            int packetOfYeasts = int.Parse(Console.ReadLine());


            double priceOfShugar = priceOfFlour * 0.75;
            double priceOfPeelEggs = priceOfFlour * 1.1;
            double priceOfYeasts = priceOfShugar * 0.2;

            double allPrice = priceOfFlour * flourKilos + priceOfShugar * sugarKilos + priceOfPeelEggs * numberOfPeelEggs + priceOfYeasts * packetOfYeasts;

            Console.WriteLine($"{allPrice:f2}");

        }
    }
}
