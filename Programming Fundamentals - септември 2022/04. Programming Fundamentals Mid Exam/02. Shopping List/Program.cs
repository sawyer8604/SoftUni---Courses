using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shopping_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> products = Console.ReadLine().Split("!", StringSplitOptions.RemoveEmptyEntries).ToList();

            string commands;

            while ((commands = Console.ReadLine()) != "Go Shopping!")
            {
                string[] cmdArguments = commands.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string firstCommand = cmdArguments[0];

                switch (firstCommand)
                {
                    case "Urgent":
                        string itemToAdd = cmdArguments[1];

                        if(!products.Contains(itemToAdd))
                        { 
                            products.Insert(0, itemToAdd);                        
                        }
                        else
                        {
                            continue;
                        }

                        break;

                    case "Unnecessary":
                        string itemToRemove = cmdArguments[1];

                        if(products.Contains(itemToRemove))
                        {
                            products.Remove(itemToRemove);
                        }
                        else
                        {
                            continue;
                        }

                        break;

                    case "Correct":
                        string oldName = cmdArguments[1];
                        string newName = cmdArguments[2];

                        int index = products.IndexOf(oldName);

                        if(products.Contains(oldName))
                        {
                            products[index] = newName;

                        }
                        else
                        {
                            continue;
                        }


                        break;

                    case "Rearrange":
                        string itemForRemoveAndAdd = cmdArguments[1];

                        if(products.Contains(itemForRemoveAndAdd))
                        {
                            products.Add(itemForRemoveAndAdd);
                            products.Remove(itemForRemoveAndAdd);

                        }
                        else
                        {
                            continue;
                        }
                        break;

                }


            }

            Console.WriteLine(String.Join(", ", products));
        }
    }
}
