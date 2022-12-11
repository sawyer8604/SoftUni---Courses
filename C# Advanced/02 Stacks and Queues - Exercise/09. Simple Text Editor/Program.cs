using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nuberOflines = int.Parse(Console.ReadLine());

            Stack<string> stack = new Stack<string>();
            
            string manipulateString = string.Empty;

            for (int i = 0; i < nuberOflines; i++)
            {
                string[] commands = Console.ReadLine().Split(" ");

                string commandName = commands[0];

                switch (commandName)
                {
                    case "1":
                        string stringToAppend = commands[1];

                        stack.Push(manipulateString);
                        manipulateString =  manipulateString.Insert(manipulateString.Length, stringToAppend);

                        break;

                    case "2":
                        int countToDelete = int.Parse(commands[1]);

                        
                        if (stack.Any())
                        {
                            stack.Push(manipulateString);
                            int indexToDelete = manipulateString.Length - countToDelete;
                            manipulateString = manipulateString.Remove(indexToDelete , countToDelete);
                            
                        }

                        break;

                    case "3":
                        int index = int.Parse(commands[1]);

                        char crrString = manipulateString[index - 1];
                        Console.WriteLine(crrString);

                        break;

                    case "4":
                        manipulateString = stack.Pop();
                        

                        break;



                }
            }
        }
    }
}
