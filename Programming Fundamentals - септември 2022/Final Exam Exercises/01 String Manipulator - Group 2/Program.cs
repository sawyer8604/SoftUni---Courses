using System;

namespace String_Manipulator___Group_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string commands;

            while ((commands = Console.ReadLine()) != "Done")
            {
                string[] cmdArguments = commands.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string firstCommand = cmdArguments[0];

                switch (firstCommand)
                {
                    
                    case "Change":

                        char chars = char.Parse(cmdArguments[1]);
                        char replacemet = char.Parse(cmdArguments[2]);
                        if (input.Contains(chars))
                        {
                            input = input.Replace(chars, replacemet);
                        }
                        Console.WriteLine(input);


                        break;

                    case "Includes":

                        string startString = cmdArguments[1];
                        bool isIncludes = input.Contains(startString);

                        Console.WriteLine(isIncludes);

                        break;

                    case "End":

                        string endString = cmdArguments[1];

                        int endIndex = input.LastIndexOf(endString);

                        string subString = input.Substring(endIndex);

                        Console.WriteLine(endString == subString);

                        break;

                    case "Uppercase":
                        
                        input = input.ToUpper();

                        Console.WriteLine(input);

                        break;

                    case "FindIndex":
                        char firstChar = char.Parse(cmdArguments[1]);
                        
                        int indexOfChar = input.IndexOf(firstChar);

                        Console.WriteLine(indexOfChar);
                        
                        break;

                    case "Cut":
                        int startIndex = int.Parse(cmdArguments[1]);
                        int length = int.Parse((string)cmdArguments[2]);

                        string subStartString = input.Substring(startIndex, length);
                        input = input.Remove(0);
                        input = subStartString;

                        Console.WriteLine(input);

                        break;


                }
            }
        }
    }
}
