using System;

namespace _07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double coins = 0;


            while (command != "Start")
            {
                double input = double.Parse(command);

                if (input == 0.1 || input == 0.2 || input == 0.5 || input == 1 || input == 2)
                {
                    coins += input;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {input}");
                    
                }
                command = Console.ReadLine();

            }

            command = Console.ReadLine();
            double price = 0;

            while (command != "End")
            {
                switch (command)
                {

                    case "Nuts":

                        price = 2;

                        break;

                    case "Water":

                        price = 0.7;

                        break;

                    case "Crisps":

                        price = 1.5;

                        break;

                    case "Soda":

                        price = 0.8;

                        break;

                    case "Coke":

                        price = 1;

                        break;
                                                
                    default:

                        Console.WriteLine("Invalid product");
                        command = Console.ReadLine();
                        continue;
                }

               

                if (coins >= price)
                {
                    coins -= price;
                    Console.WriteLine($"Purchased {command.ToLower()}");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                    
                }
                

                command = Console.ReadLine();

            }

            Console.WriteLine($"Change: {coins:f2}");

        }
    }
}
