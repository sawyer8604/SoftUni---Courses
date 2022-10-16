using System;

namespace _01._Computer_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            double allPrice = 0;
            bool isSpecial = false;

            input = AllPrce(ref allPrice, ref isSpecial);

            PrinResult(allPrice, isSpecial);

        }

        static void PrinResult(double allPrice, bool isSpecial)
        {
            double taxes = allPrice * 0.2;
            double allpriceWithTaxes = allPrice + taxes;


            if (allPrice <= 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                Console.WriteLine($"Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {allPrice:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");

                if (isSpecial)
                {
                    double specialPrice = allpriceWithTaxes * 0.9;
                    Console.WriteLine($"Total price: {specialPrice:f2}$");
                }
                else
                {
                    Console.WriteLine($"Total price: {allpriceWithTaxes:f2}$");
                }

            }
        }

        static string AllPrce(ref double allPrice, ref bool isSpecial)
        {
            string input;
            while ((input = Console.ReadLine()) != "regular")
            {
                if (input == "special")
                {
                    isSpecial = true;
                    break;
                }

                double price = double.Parse(input);

                if (price < 0)
                {

                    Console.WriteLine("Invalid price!");
                    continue;
                }

                allPrice += price;



            }

            return input;
        }
    }
}
