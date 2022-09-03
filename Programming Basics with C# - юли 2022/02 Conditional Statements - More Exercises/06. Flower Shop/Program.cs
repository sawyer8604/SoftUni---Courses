using System;

namespace _06._Flower_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Входът се чете от конзолата и се състои от 5 реда:
            // Брой магнолии – цяло число в интервала[0 … 50]
            //Брой зюмбюли – цяло число в интервала[0 … 50]
            //Брой рози – цяло число в интервала[0 … 50]
            //Брой кактуси – цяло число в интервала[0 … 50]
            //Цена на подаръка – реално число в интервала[0.00 … 500.00]

            int numberOfMagnolies = int.Parse(Console.ReadLine());
            int numberOfSumbuls = int.Parse(Console.ReadLine());
            int numberOfRoses = int.Parse(Console.ReadLine());
            int numberOfCactuses = int.Parse(Console.ReadLine());
            double priceOfGift = double.Parse(Console.ReadLine());

            double allFloversPrice = (numberOfMagnolies * 3.25 + numberOfSumbuls * 4 + numberOfRoses * 3.5 + numberOfCactuses * 8);
            double allFloversWithTax = allFloversPrice - allFloversPrice * 0.05;

            double different = Math.Abs(priceOfGift - allFloversWithTax);

            bool isAllFloversWithTax = allFloversWithTax >= priceOfGift;

            if (isAllFloversWithTax)
            {
                Console.WriteLine($"She is left with {Math.Floor(different)} leva.");
            }
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(different)} leva.");
            }



        }
    }
}
