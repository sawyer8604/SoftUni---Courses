using System;
using System.Collections.Generic;

namespace Third_problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            while (true)
            {
                input = Console.ReadLine();

                string[] words = input.Split(" | ",StringSplitOptions.RemoveEmptyEntries);

                foreach (var word in words)
                {
                    string[] newWord = word.Split(": ", StringSplitOptions.RemoveEmptyEntries);

                    string firstWord = newWord[0];
                    string descriptions = newWord[1];

                    if(!dict.ContainsKey(firstWord))
                    {
                        dict[firstWord] = new List<string>();
                    }

                    dict[firstWord].Add(descriptions);
                }

                string commands = Console.ReadLine();
                string[] cmdArguments = commands.Split(" | ", StringSplitOptions.RemoveEmptyEntries);

                string lastCommand = Console.ReadLine();

                if(lastCommand == "Test")
                {
                    foreach (var cmd in cmdArguments)
                    {
                        if(dict.ContainsKey(cmd))
                        {
                            Console.WriteLine($"{cmd}:");

                            foreach (var item in dict)
                            {
                                if(cmd == item.Key)
                                {
                                    foreach (var it in item.Value)
                                    {
                                        Console.WriteLine($" -{it}");
                                    }


                                    
                                }
                                
                            }
                        }
                    }
                    break;
                }
                else if(lastCommand == "Hand Over")
                {
                    foreach (var item in dict)
                    {
                        Console.Write($"{item.Key} ");
                    }
                    break;
                }

                

            }
        }
    }
}
