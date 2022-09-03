// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

namespace _05._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string location = string.Empty;
            string place = string.Empty;

            switch (season)

            {
                case "Summer":

                    if (budget <= 1000)
                    {
                        place = "Camp";
                        location = "Alaska";
                        budget *= 0.65;

                    }
                    else if (budget > 1000 && budget <= 3000)
                    {
                        place = "Hut";
                        location = "Alaska";
                        budget *= 0.8;

                    }
                    else if (budget > 3000)
                    {
                        place = "Hotel";
                        location = "Alaska";
                        budget *= 0.9;

                    }


                    break;

                case "Winter":

                    if (budget <= 1000)
                    {
                        place = "Camp";
                        location = "Morocco";
                        budget *= 0.45;

                    }
                    else if (budget > 1000 && budget <= 3000)
                    {
                        place = "Hut";
                        location = "Morocco";
                        budget *= 0.6;

                    }
                    else if (budget > 3000)
                    {
                        place = "Hotel";
                        location = "Morocco";
                        budget *= 0.9;

                    }


                    break;


            }
            Console.WriteLine($"{location} - {place} - {budget:f2}");



        }

    }
}