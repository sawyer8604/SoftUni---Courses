using System;

namespace _01._Match_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int numberOfPeople = int.Parse(Console.ReadLine());

            double leftMoney = 0;
            double diference = 0;
            double tichkets = 0;
            double allTichketPrice = 0;



            switch (category)
            {
                case "VIP":
                    tichkets = 499.99;

                    break;
                case "Normal":
                    tichkets = 249.99;

                    break;

            }



            if (numberOfPeople >= 1 && numberOfPeople <= 4)
            {
                budget *= 0.25;

            }
            else if (numberOfPeople >= 5 && numberOfPeople <= 9)
            {
                budget *= 0.4;
            }
            else if (numberOfPeople >= 10 && numberOfPeople <= 24)
            {
                budget *= 0.5;
            }
            else if (numberOfPeople >= 25 && numberOfPeople <= 49)
            {
                budget *= 0.6;
            }
            else if (numberOfPeople > 50)
            {
                budget *= 0.75;
            }



            allTichketPrice = numberOfPeople * tichkets;
            diference = Math.Abs(budget - allTichketPrice);

            if (budget >= allTichketPrice)
            {
                Console.WriteLine($"Yes! You have {diference:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {diference:f2} leva.");
            }
        }
    }
}
