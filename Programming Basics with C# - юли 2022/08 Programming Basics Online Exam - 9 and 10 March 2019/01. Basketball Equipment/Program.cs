using System;

namespace _01._Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double priceForBaseball = double.Parse(Console.ReadLine());

            double baseballShoes = priceForBaseball * 0.6;
            double basebalEquipmant = baseballShoes * 0.8;
            double baseBall = basebalEquipmant * 0.25;
            double baseballАccessory = baseBall * 0.2;

            double allPrice = priceForBaseball + baseballShoes + basebalEquipmant + baseBall + baseballАccessory;
            Console.WriteLine($"{allPrice:f2}");

        }
    }
}
