using System;

namespace _04._Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceOfEkscursion = double.Parse(Console.ReadLine());
            int countPuzzle = int.Parse(Console.ReadLine());
            int countBarbies = int.Parse(Console.ReadLine());
            int countBears = int.Parse(Console.ReadLine());
            int countMinions = int.Parse(Console.ReadLine());
            int countTrucks = int.Parse(Console.ReadLine());

            int countAllToys = countPuzzle + countBarbies + countBears + countMinions + countTrucks;

            double allMoney = countPuzzle * 2.60 + countBarbies * 3 + countBears * 4.10 +
                countMinions * 8.20 + countTrucks * 2;



            if (countAllToys >= 50)
            {
                allMoney = allMoney - allMoney * 0.25;
            }
            allMoney = allMoney - allMoney * 0.1;



            if (allMoney >= priceOfEkscursion)
            {
                double moneyLeft = allMoney - priceOfEkscursion;
                Console.WriteLine($"Yes! {moneyLeft:f2} lv left.");
            }
            else
            {
                double moneyNotEnought = priceOfEkscursion - allMoney;
                Console.WriteLine($"Not enough money! {moneyNotEnought:f2} lv needed.");
            }
        }
    }
}
