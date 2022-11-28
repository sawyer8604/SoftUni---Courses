using System;

namespace _01._Secret_Chat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string commands;

            while ((commands = Console.ReadLine()) != "Reveal")
            {
                string[] cmdArguments = commands.Split(":|:", StringSplitOptions.RemoveEmptyEntries);

                string firstCommand = cmdArguments[0];


                switch (firstCommand)
                {
                    case "InsertSpace":

                        int index = int.Parse(cmdArguments[1]);

                        input = input.Insert(index, " ");
                        Console.WriteLine(input);
                        break;

                    case "Reverse":

                        string substring = cmdArguments[1];

                        if (input.Contains(substring))
                        {
                            int indexOfSubstring = input.IndexOf(substring);
                            input = input.Remove(indexOfSubstring, substring.Length);
                            char[] reversedString = substring.ToCharArray();
                            Array.Reverse(reversedString);
                            substring = new string(reversedString);
                           
                            input = input.Insert(input.Length, substring);
                        }
                        else
                        {
                            Console.WriteLine("error");
                            break;
                        }
                        Console.WriteLine(input);
                        break;

                    case "ChangeAll":

                        string oldSubString = cmdArguments[1];
                        string newSubString = cmdArguments[2];

                        input = input.Replace(oldSubString, newSubString);
                        Console.WriteLine(input);
                        break;

                }
            }
            Console.WriteLine($"You have a new text message: {input}");
        }
    }
}
