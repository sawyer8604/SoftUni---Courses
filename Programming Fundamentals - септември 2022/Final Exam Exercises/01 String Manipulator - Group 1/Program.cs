using System;

namespace _01_String_Manipulator___Group_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string commands;

            while ((commands = Console.ReadLine()) != "End")
            {
                string[] cmdArguments = commands.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string firstCommand = cmdArguments[0];

                switch (firstCommand)
                {
                    case "Translate":

                        char chars = char.Parse(cmdArguments[1]);
                        char replacemet = char.Parse(cmdArguments[2]);
                        if (input.Contains(chars))
                        {
                            input = input.Replace(chars, replacemet);
                        }
                        Console.WriteLine(input);


                        break;

                    case "Includes":

                        string includes = cmdArguments[1];

                        Console.WriteLine(input.Contains(includes));


                        break;

                    case "Start":

                        string startString = cmdArguments[1];
                        int index = input.IndexOf(startString);

                        Console.WriteLine(index == 0);

                        break;

                    case "Lowercase":
                        input = input.ToLower();

                        Console.WriteLine(input);

                        break;

                    case "FindIndex":
                        char findChar = char.Parse(cmdArguments[1]);

                        int lastIndex = input.LastIndexOf(findChar);

                        Console.WriteLine(lastIndex);

                        break;

                    case "Remove":
                        int startIndex = int.Parse(cmdArguments[1]);
                        int count = int.Parse(cmdArguments[2]);

                        input = input.Remove(startIndex, count);

                        Console.WriteLine(input);
                        break;


                }
            }


        }
    }
}
