using System;

namespace _04Easter_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfEggs = int.Parse(Console.ReadLine());
            int slodEggs = 0;
            int eggsLeft = numberOfEggs;

            while (eggsLeft >= 0)
            {
                string command = Console.ReadLine();
                if (command == "Close")
                {
                    Console.WriteLine("Store is closed!");
                    Console.WriteLine($"{slodEggs} eggs sold.");
                    break;
                }
                int eggsBuyOrFill = int.Parse(Console.ReadLine());


                if (command == "Buy")
                {
                    eggsLeft -= eggsBuyOrFill;
                }
                if (command == "Buy" && numberOfEggs >= eggsBuyOrFill)
                {
                    numberOfEggs -= eggsBuyOrFill;
                    slodEggs += eggsBuyOrFill;
                }
                else if (command == "Fill")
                {
                    numberOfEggs += eggsBuyOrFill;
                    eggsLeft += eggsBuyOrFill;
                }



            }
            if (eggsLeft <= 0)
            {
                Console.WriteLine("Not enough eggs in store!");
                Console.WriteLine($"You can buy only {numberOfEggs}.");

            }



        }
    }
}
