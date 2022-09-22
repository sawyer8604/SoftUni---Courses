using System;

namespace _05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int numberOfProduct = int.Parse(Console.ReadLine());
            double result = 0;
            double price = 0;
            

            switch (product)
            {
                case "coffee":
                    price = 1.50;
                    printProductPrice(numberOfProduct, price);
                    break;

                case "water":
                    price = 1.00;
                    printProductPrice(numberOfProduct, price);
                    break;

                case "coke":
                    price = 1.40;
                    printProductPrice(numberOfProduct, price);
                    break;

                case "snacks":
                    price = 2.00;
                    printProductPrice(numberOfProduct, price);
                    break;


            }
        }

        private static void printProductPrice(int numberOfProduct, double price)
        {
             
           
            double result = numberOfProduct * price;

            Console.WriteLine($"{result:f2}");

        }
    }
}
