using System;

namespace _01._World_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string command;

            while ((command = Console.ReadLine()) != "Travel")
            {
                string[] commandArguments = command.Split(":", StringSplitOptions.RemoveEmptyEntries);

                string firstCommand = commandArguments[0];

                switch (firstCommand)
                {
                    case "Add Stop":

                        int indexToAdd = int.Parse(commandArguments[1]);
                        string wordToAdd = commandArguments[2];
                        if (indexToAdd < input.Length && indexToAdd >= 0)
                        {
                            input = input.Insert(indexToAdd, wordToAdd);
                            
                        }
                        Console.WriteLine(input);


                        break;

                    case "Remove Stop":

                        int startIndex = int.Parse(commandArguments[1]);
                        int endIndex = int.Parse(commandArguments[2]);

                        string substring = String.Empty;
                        if(startIndex >= 0 && endIndex < input.Length)
                        {
                            for (int i = startIndex; i <= endIndex; i++)
                            {
                                substring += input[i];
                            }

                            input = input.Remove(startIndex, substring.Length);

                            
                        }
                        Console.WriteLine(input);


                        break;

                    case "Switch":
                        string oldString = commandArguments[1];
                        string newString = commandArguments[2];

                        if(input.Contains(oldString))
                        {
                            input = input.Replace(oldString, newString);

                            
                        }
                        Console.WriteLine(input);
                        break;

                }
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {input}");
        }
    }
}
