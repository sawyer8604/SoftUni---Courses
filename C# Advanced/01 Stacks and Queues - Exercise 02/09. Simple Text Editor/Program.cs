using System;
using System.Collections.Generic;
using System.Text;

namespace _09._Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //•	1 someString - appends someString to the end of the text.
            //•	2 count - erases the last count elements from the text.
            //•	3 index - returns the element at position index from the text.
            //•	4 - undoes the last not undone command of type 1 or 2 and returns the text to the state before that operation.

            int numberOfOperation = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();
            sb.Append(" ");

            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < numberOfOperation; i++)
            {
                string[] commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                int firstCommand = int.Parse(commands[0]);

                switch (firstCommand)
                {
                    case 1:

                        string crrString = commands[1];

                        stack.Push(sb.ToString());

                        sb.Append(crrString);

                        break;

                    case 2:
                        int countToRemove = int.Parse(commands[1]);

                        stack.Push(sb.ToString());

                        if (countToRemove < sb.Length)
                        {
                            int startIndex = sb.Length - countToRemove;

                            sb.Remove(startIndex, countToRemove);
                        }
                        

                        break;

                    case 3:

                        int indexToPrint = int.Parse(commands[1]);

                        if(indexToPrint >= 0 && indexToPrint < sb.Length)
                        {
                            Console.WriteLine(sb[indexToPrint]);
                        }

                        break;

                    case 4:

                        sb.Clear();

                        sb.Append(stack.Pop());

                        break;

                }
            }

        }
    }
}
