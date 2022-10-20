
namespace _03._Man_O_War
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> piratShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();

            List<int> warShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            string command;

            int maxHealt = int.Parse(Console.ReadLine());

            bool isNotSunken = true;

            foreach (int number in piratShip)
            {
                if (number <= 0)
                {
                    Console.WriteLine("You lost! The pirate ship has sunken.");
                    isNotSunken = false;
                    return;
                }
            }

            foreach (int number in warShip)
            {
                if (number <= 0)
                {
                    Console.WriteLine("You won! The enemy ship has sunken.");
                    isNotSunken = false;
                    return;
                }
            }


            while ((command = Console.ReadLine()) != "Retire")
            {
                string[] cmdArguments = command.Split(' ');
                string firstCommand = cmdArguments[0];

                switch (firstCommand)
                {
                    case "Fire":
                        int indexForDamage = int.Parse(cmdArguments[1]);
                        int damage = int.Parse(cmdArguments[2]);

                        if (damage <= 0)
                        {
                            continue;
                        }

                        if (indexForDamage >= 0 && indexForDamage < warShip.Count)
                        {
                            warShip[indexForDamage] -= damage;

                            if (warShip[indexForDamage] <= 0)
                            {
                                Console.WriteLine("You won! The enemy ship has sunken.");

                                return;
                            }
                        }
                        else
                        {
                            continue;
                        }

                        break;

                    case "Defend":
                        int startIndex = int.Parse(cmdArguments[1]);
                        int endIndex = int.Parse(cmdArguments[2]);
                        int damageToPirat = int.Parse(cmdArguments[3]);


                        if (damageToPirat <= 0)
                        {
                            continue;
                        }

                        if (startIndex >= 0 && startIndex < piratShip.Count && endIndex >= 0 && endIndex < piratShip.Count)
                        {
                            for (int i = startIndex; i <= endIndex; i++)
                            {
                                piratShip[i] -= damageToPirat;

                                if (piratShip[i] <= 0)
                                {
                                    Console.WriteLine("You lost! The pirate ship has sunken.");
                                    isNotSunken = false;
                                    return;
                                }
                            }

                        }
                        else
                        {
                            continue;
                        }

                        break;

                    case "Repair":
                        int indexToRepair = int.Parse(cmdArguments[1]);
                        int health = int.Parse(cmdArguments[2]);

                        if (indexToRepair >= 0 && indexToRepair < piratShip.Count)
                        {
                            if (piratShip[indexToRepair] + health < maxHealt)
                            {
                                piratShip[indexToRepair] += health;
                            }
                            else
                            {
                                piratShip[indexToRepair] = maxHealt;
                            }

                        }
                        else
                        {
                            continue;
                        }

                        break;

                    case "Status":
                        double percent = 0.2 * maxHealt;
                        int counterForRepair = 0;

                        for (int i = 0; i < piratShip.Count; i++)
                        {
                            if (piratShip[i] < percent)
                            {
                                counterForRepair++;
                            }
                        }

                        Console.WriteLine($"{counterForRepair} sections need repair.");

                        break;


                }


            }

            Console.WriteLine($"Pirate ship status: {piratShip.Sum()}");
            Console.WriteLine($"Warship status: {warShip.Sum()}");


        }
    }
}
