using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Stack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            
            MyStack<string> stack = new MyStack<string>();

            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                string[] cmdArguments = command.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                string firstCommand = cmdArguments[0];

                if(firstCommand == "Push")
                {
                    string[] elementsForPush = command
                        .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                        .Skip(1)
                        .ToArray();
                    
                    stack.Push(elementsForPush);
                }
                else if(firstCommand == "Pop")
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine(ex.Message);
                    }
                    
                }
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

        }
    }
}
