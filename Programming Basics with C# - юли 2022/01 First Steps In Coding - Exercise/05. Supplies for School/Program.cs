using System;

namespace _05._Supplies_for_School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int packOfPens = int.Parse(Console.ReadLine());
            int packOfMarkers = int.Parse(Console.ReadLine());
            int litresCleaner = int.Parse(Console.ReadLine());
            int percentReduction = int.Parse(Console.ReadLine());

            double priceOfPens = packOfPens * 5.80;
            double priceOfMarkers = packOfMarkers * 7.20;
            double priceOfCleaner = litresCleaner * 1.20;
            double priceOfAll = priceOfPens + priceOfMarkers + priceOfCleaner;
            double priceOfAllWithReduction = priceOfAll - (priceOfAll * percentReduction / 100);


            Console.WriteLine(priceOfAllWithReduction);

        }
    }
}
