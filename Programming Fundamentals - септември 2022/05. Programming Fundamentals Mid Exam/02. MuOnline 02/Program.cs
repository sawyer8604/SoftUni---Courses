using System;

namespace _02._MuOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] rooms = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);

            int health = 100;
            int bitcoins = 0;

            for (int i = 0; i < rooms.Length; i++)
            {
                string[] crrRoom = rooms[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string monster = crrRoom[0];
                int monsterPower = int.Parse(crrRoom[1]);
                

                if(monster == "potion")
                {
                    int healthPoint = int.Parse(crrRoom[1]);

                    if(health < 100)
                    {
                        int crrHealth = health;

                        health += healthPoint;
                        if(health <= 100)
                        {
                            Console.WriteLine($"You healed for {healthPoint} hp.");
                            Console.WriteLine($"Current health: {health} hp.");
                            
                        }
                        else
                        {
                            health = 100;

                            Console.WriteLine($"You healed for {health - crrHealth} hp.");
                            Console.WriteLine($"Current health: {health} hp.");
                            

                        }
                    }
                    continue;
                }
                else if(monster == "chest")
                {
                    int amount = int.Parse(crrRoom[1]);
                    bitcoins += amount;

                    Console.WriteLine($"You found {amount} bitcoins.");
                    continue;
                }

                health -= monsterPower;

                if(health > 0)
                {
                    Console.WriteLine($"You slayed {monster}.");
                }
                else
                {
                    Console.WriteLine($"You died! Killed by {monster}.");
                    Console.WriteLine($"Best room: {i+1}");
                    return;
                }
            }

            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoins}");
            Console.WriteLine($"Health: {health}");
        }
    }
}
