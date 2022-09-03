// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

namespace _04._Car_To_Go
{
    internal class HelloWorld
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string carType = string.Empty;
            string classCar = string.Empty;

            switch (season)
            {
                case "Summer":

                    if (budget <= 100)
                    {
                        classCar = "Economy class";
                        carType = "Cabrio";
                        budget *= 0.35;


                    }
                    else if (budget > 100 && budget <= 500)
                    {
                        classCar = "Compact class";
                        carType = "Cabrio";
                        budget *= 0.45;

                    }
                    else if (budget > 500)
                    {
                        classCar = "Luxury class";
                        carType = "Jeep";
                        budget *= 0.9;

                    }




                    break;

                case "Winter":

                    if (budget <= 100)
                    {
                        classCar = "Economy class";
                        carType = "Jeep";
                        budget *= 0.65;


                    }
                    else if (budget > 100 && budget <= 500)
                    {
                        classCar = "Compact class";
                        carType = "Jeep";
                        budget *= 0.8;

                    }
                    else if (budget > 500)
                    {
                        classCar = "Luxury class";
                        carType = "Jeep";
                        budget *= 0.9;

                    }


                    break;


            }
            Console.WriteLine($"{classCar}");
            Console.WriteLine($"{carType} - {budget:f2}");



        }

    }
}