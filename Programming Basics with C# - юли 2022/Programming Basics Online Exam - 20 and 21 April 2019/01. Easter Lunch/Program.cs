using System;

namespace _01._Easter_Lunch_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCozunac = int.Parse(Console.ReadLine());
            int numberOfEggs = int.Parse(Console.ReadLine());
            int kilosOfCookies = int.Parse(Console.ReadLine());

            double priceOfCozunac = numberOfCozunac * 3.20;
            double priceOfEggs = numberOfEggs * 4.35;
            double priceOfCookies = kilosOfCookies * 5.40;
            double priceForPaint = numberOfEggs * 12 * 0.15;

            double allPrice = priceOfCozunac + priceOfEggs + priceOfCookies + priceForPaint;
            Console.WriteLine($"{allPrice:f2}");
        }
    }
}
