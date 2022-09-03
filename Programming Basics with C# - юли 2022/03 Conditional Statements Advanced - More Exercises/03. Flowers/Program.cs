using System;

namespace _03._Flowers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfHrisantems = int.Parse(Console.ReadLine());
            int numberOfRoses = int.Parse(Console.ReadLine());
            int numberOfTulip = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string holidayOrNot = Console.ReadLine();

            double sum = 0;
            double priceOfHrisantems = 0;
            double priceOfRoses = 0;
            double priceOfTulip = 0;

            switch (season)
            {
                case "Spring":
                case "Summer":
                    priceOfHrisantems = 2;
                    priceOfRoses = 4.1;
                    priceOfTulip = 2.50;

                    break;

                case "Autumn":
                case "Winter":
                    priceOfHrisantems = 3.75;
                    priceOfRoses = 4.50;
                    priceOfTulip = 4.15;

                    break;

            }


            sum = (numberOfHrisantems * priceOfHrisantems) + (numberOfRoses * priceOfRoses) + (numberOfTulip * priceOfTulip);

            if (holidayOrNot == "Y")
            {
                sum *= 1.15;

            }

            if (numberOfTulip > 7 && season == "Spring")
            {
                sum *= 0.95;


            }
            if (numberOfRoses > 10 && season == "Winter")
            {
                sum *= 0.9;

            }
            double numberOfAll = numberOfRoses + numberOfHrisantems + numberOfTulip;

            if (numberOfAll > 20)
            {
                sum *= 0.8;
            }

            Console.WriteLine($"{sum + 2:f2}");


        }
    }
}
