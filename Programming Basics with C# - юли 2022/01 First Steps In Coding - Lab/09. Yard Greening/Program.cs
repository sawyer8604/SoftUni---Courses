using System;

namespace _09._Yard_Greening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double size = double.Parse(Console.ReadLine());
            double priceWithouthDiscount = size * 7.61;
            double discount = priceWithouthDiscount * 0.18;
            Console.WriteLine($"The final price is: {priceWithouthDiscount - discount} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
