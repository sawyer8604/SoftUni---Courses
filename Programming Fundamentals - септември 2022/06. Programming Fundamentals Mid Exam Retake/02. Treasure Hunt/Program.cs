using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Treasure_Hunt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split("|").ToList();

            string commands;

            while ((commands = Console.ReadLine()) != "Yohoho!")
            {
                string[] cmdArguments = commands.Split();

                string firstCommand = cmdArguments[0];

                switch (firstCommand)
                {
                    case "Loot":
                        string itemForInsert = cmdArguments[1];                                               

                        for (int i = 1; i < cmdArguments.Length; i++)
                        {
                            string item = cmdArguments[i];

                            if (!input.Contains(item))
                            {
                                input.Insert(0, item);
                            }

                        }

                        break;

                    case "Drop":

                        int index = int.Parse(cmdArguments[1]);

                        if(index < 0 || index > input.Count)
                        {
                            continue;
                        }
                        else
                        {
                            input.Add(input[index]);
                            input.RemoveAt(index);
                        }

                        break;

                    case "Steal":
                        int stealCount = int.Parse(cmdArguments[1]);

                        int startIndex = input.Count - stealCount;

                        if(stealCount >= input.Count)
                        {
                            stealCount = input.Count;
                            startIndex = 0;
                        }

                        List<string> list = new List<string>();

                        for (int i = 0; i < stealCount; i++)
                        {
                            list.Add(input[startIndex]);
                            input.RemoveAt(startIndex);
                        }

                        Console.WriteLine(String.Join(", ", list));

                        break;


                }

            }

            string legthOfAllCharacter = string.Empty;

            for (int i = 0; i < input.Count; i++)
            {
                legthOfAllCharacter += input[i];

            }

            double avarage = 1.0 * legthOfAllCharacter.Length / input.Count;

            if(input.Count <= 0)
            {
                Console.WriteLine("Failed treasure hunt.");
            }
            else
            {
                Console.WriteLine($"Average treasure gain: {avarage:f2} pirate credits.");
            }

        }
    }
}
