using System;

namespace _05._Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //  Ред 1.Бюджет за филма – реално число в интервала[1.00 … 1000000.00]

            //Ред 2.Брой на статистите – цяло число в интервала[1 … 500]

            //Ред 3.Цена за облекло на един статист – реално число в интервала[1.00 … 1000.00]

            double budget = double.Parse(Console.ReadLine());
            int statist = int.Parse(Console.ReadLine());
            double priceOfClothing = double.Parse(Console.ReadLine());

            double decor = budget * 0.1;

            if (statist > 150)
            {
                priceOfClothing = priceOfClothing - priceOfClothing * 0.1;

            }
            double moneyForDecorAndClothes = statist * priceOfClothing + decor;

            if (moneyForDecorAndClothes > budget)
            {
                double notEneughtMoney = moneyForDecorAndClothes - budget;

                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {notEneughtMoney:f2} leva more.");
            }

            else if (moneyForDecorAndClothes <= budget)
            {
                double moneyLeft = budget - moneyForDecorAndClothes;

                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:F2} leva left.");


            }
        }
    }
}
