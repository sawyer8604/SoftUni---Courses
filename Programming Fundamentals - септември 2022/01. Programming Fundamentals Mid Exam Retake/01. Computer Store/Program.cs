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
            
            while ((input = Console.ReadLine()) != "regular")
            {  
                if(input == "special")
                {
                    isSpecial = true;
                    break;
                }

                double price = double.Parse(input);

                if(price < 0)
                {

                    Console.WriteLine("Invalid price!");
                    continue;
                }

                allPrice += price;



            }

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
    }
}
