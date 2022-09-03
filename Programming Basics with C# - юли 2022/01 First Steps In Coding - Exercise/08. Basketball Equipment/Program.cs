using System;

namespace _08._Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int feeForYear = int.Parse(Console.ReadLine()); // такса за година

            double baseballSneakers = feeForYear - (feeForYear * 0.4);
            double baseballEkip = baseballSneakers - (baseballSneakers * 0.2);
            double baseballBall = baseballEkip / 4;
            double baseballAksesoars = baseballBall / 5;

            double priceOfEkuipmant = feeForYear + baseballSneakers + baseballEkip + baseballBall + baseballAksesoars;

            Console.WriteLine(priceOfEkuipmant);
        }
    }
}
