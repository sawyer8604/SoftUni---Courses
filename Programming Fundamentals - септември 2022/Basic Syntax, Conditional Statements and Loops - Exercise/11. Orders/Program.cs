using System;

namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            double price = 0;
            double allPrice = 0;

            for (int i = 1; i <= number; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int countOfCapsules = int.Parse(Console.ReadLine());

                price = (days * countOfCapsules) * pricePerCapsule;
                allPrice += price;

                Console.WriteLine($"The price for the coffee is: ${price:f2}");

            }

            Console.WriteLine($"Total: ${allPrice:f2}");
        }
    }
}
