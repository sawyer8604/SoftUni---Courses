using System;

namespace _03._Gaming_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string command = string.Empty;
            double price = 0;
            double allPrice = 0;

            while (command != "Game Time")
            {
                command = Console.ReadLine();

                if (command == "Game Time")
                {
                    break;
                }

                switch (command)
                {
                    case "OutFall 4":
                        price = 39.99;
                        break;
                    case "CS: OG":
                        price = 15.99;
                        break;
                    case "Zplinter Zell":
                        price = 19.99;
                        break;
                    case "Honored 2":
                        price = 59.99;
                        break;
                    case "RoverWatch":
                        price = 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        price = 39.99;
                        break;
                    default:
                        Console.WriteLine("Not Found");

                        
                        continue;
                        
                }
                

                if (budget < price)
                {
                    Console.WriteLine("Too Expensive");
                    continue;

                }
                else
                {
                    Console.WriteLine($"Bought {command}");
                }
                allPrice += price;
                budget -= price;

                if (budget == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
                

            }
            Console.WriteLine($"Total spent: ${allPrice:f2}. Remaining: ${budget:f2}");
        }
    }
}
