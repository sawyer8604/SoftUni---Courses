using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Memory_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string commands;
            int counter = 0;



            while ((commands = Console.ReadLine()) != "end")
            {
                counter++;

                string[] commandsArguments = commands.Split();


                int firstCommand = int.Parse(commandsArguments[0]);
                int secondCommand = int.Parse(commandsArguments[1]);


                if (firstCommand == secondCommand || firstCommand < 0 || firstCommand > input.Count - 1 || firstCommand > input.Count || secondCommand < 0 || secondCommand > input.Count - 1)
                {
                    int index = input.Count / 2;
                    string counterAsString = $"-{counter.ToString()}a";
                    input.Insert(index, counterAsString);
                    input.Insert(index, counterAsString);
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    continue;
                }

                if (input[firstCommand] == input[secondCommand])
                {
                    string currElement = input[firstCommand];

                    if (secondCommand == 0)
                    {
                        input.RemoveAt(firstCommand);
                        input.RemoveAt(secondCommand);

                    }
                    else
                    {
                        input.RemoveAt(firstCommand);
                        input.RemoveAt(secondCommand - 1);

                    }



                    Console.WriteLine($"Congrats! You have found matching elements - {currElement}!");
                }
                else
                {
                    Console.WriteLine("Try again!");
                    continue;
                }

                if (input.Count <= 0)
                {
                    Console.WriteLine($"You have won in {counter} turns!");
                    break;
                }



            }
            if (input.Count != 0)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(String.Join(" ", input));

            }


        }
    }
}
