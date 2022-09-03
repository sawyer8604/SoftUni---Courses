using System;

namespace _2Easter_Guests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfGuest = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double priceOfCozunac = 4;
            double priceOfEggs = 0.45;

            double numberOfCozunac = Math.Ceiling(numberOfGuest / 3.0);
            double numberOfEggs = numberOfGuest * 2;

            double allPrice = numberOfCozunac * priceOfCozunac + numberOfEggs * priceOfEggs;

            if (budget >= allPrice)
            {
                Console.WriteLine($"Lyubo bought {numberOfCozunac} Easter bread and {numberOfEggs} eggs.");
                Console.WriteLine($"He has {(budget - allPrice):f2} lv. left.");
            }
            else
            {

                Console.WriteLine($"Lyubo doesn't have enough money.\r\nHe needs {(allPrice - budget):F2} lv. more.");
            }


        }
    }
}
