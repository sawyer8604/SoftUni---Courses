using System;

namespace _02._MuOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int health = 100;

            string input = Console.ReadLine();

            string[] commands = input.Split("|");

            int bitcoins = 0;
            
            bool notDeath = true;

            int currHealth = 0;
            int tempHealth = 0;

            for (int i = 0; i < commands.Length; i++)
            {
                string currElement = commands[i];

                string[] cmdArguments = currElement.Split(" ");

                string firstCommand = cmdArguments[0];
                int secondCommand = int.Parse(cmdArguments[1]);
                

                if (firstCommand == "potion")
                {
                    int healtNumber = int.Parse(cmdArguments[1]);
                    currHealth = health;
                    tempHealth = health;
                    currHealth += healtNumber;

                    if (currHealth <= 100)
                    {
                        health += healtNumber;
                        Console.WriteLine($"You healed for {healtNumber} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                    }

                    else if (currHealth > 100)
                    {
                        int diff = 100 - tempHealth;
                        health = 100;
                        Console.WriteLine($"You healed for {diff} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                    }
                }

                else if (firstCommand == "chest")
                {
                    int foundBitcoins = int.Parse(cmdArguments[1]);

                    bitcoins += foundBitcoins;
                    Console.WriteLine($"You found {foundBitcoins} bitcoins.");
                }
                else
                {
                    health -= secondCommand;

                    if (health <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {firstCommand}.");
                        Console.WriteLine($"Best room: {i + 1}");

                        notDeath = false;
                        break;

                    }
                    else
                    {
                        Console.WriteLine($"You slayed {firstCommand}.");

                    }

                }

            }
            if(notDeath)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");
            }
            
        }
    }
}
