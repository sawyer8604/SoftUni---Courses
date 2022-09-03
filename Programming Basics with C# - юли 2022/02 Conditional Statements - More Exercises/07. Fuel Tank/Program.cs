using System;

namespace _07._Fuel_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tipeOfFuel = Console.ReadLine();
            double litresFuelin = double.Parse(Console.ReadLine());

            if (tipeOfFuel == "Diesel" || tipeOfFuel == "Gasoline" || tipeOfFuel == "Gas")
            {
                if (litresFuelin >= 25)
                {
                    Console.WriteLine($"You have enough {tipeOfFuel.ToLower()}.");
                }
                else
                {
                    Console.WriteLine($"Fill your tank with {tipeOfFuel.ToLower()}!");
                }
            }

            else
            {
                Console.WriteLine("Invalid fuel!");
            }
        }
    }
}
