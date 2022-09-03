using System;

namespace _04._Vegetable_Market
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceOfVegetables = double.Parse(Console.ReadLine());
            double priceOfFruits = double.Parse(Console.ReadLine());
            int kilosOfVegetables = int.Parse(Console.ReadLine());
            int kilosOfFruits = int.Parse(Console.ReadLine());

            double priceAllVegetable = priceOfVegetables * kilosOfVegetables;
            double priceAllFruits = priceOfFruits * kilosOfFruits;
            double priceAll = (priceAllVegetable + priceAllFruits) / 1.94;

            Console.WriteLine("{0:F2}", priceAll);
        }
    }
}
