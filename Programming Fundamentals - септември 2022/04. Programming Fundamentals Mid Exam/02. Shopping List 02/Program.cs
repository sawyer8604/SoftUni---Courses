using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shopping_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> groceries = Console.ReadLine().Split("!", StringSplitOptions.RemoveEmptyEntries).ToList();

            string commands;

            while ((commands = Console.ReadLine()) != "Go Shopping!")
            {
                string[] cmdArguments = commands.Split();

                string firstCommand = cmdArguments[0];

                switch (firstCommand)
                {
                    case "Urgent":

                        string itemToAdd = cmdArguments[1];

                        if(!groceries.Contains(itemToAdd))
                        {
                            groceries.Insert(0, itemToAdd);
                        }

                        break;

                    case "Unnecessary":

                        string itemToRemove = cmdArguments[1];

                        if(groceries.Contains(itemToRemove))
                        {
                            groceries.Remove(itemToRemove);
                        }

                        break;

                    case "Correct":

                        string oldItem = cmdArguments[1];
                        string newItem = cmdArguments[2];

                        if(groceries.Contains(oldItem))
                        {
                            int indexOfOldItem = groceries.IndexOf(oldItem);
                            groceries[indexOfOldItem] = newItem;
                        }

                        break;

                    case "Rearrange":

                        string rerangeItem = cmdArguments[1];
                        RerangeItem(groceries, rerangeItem);

                        break;

                }
            }

            Console.WriteLine(string.Join(", ", groceries));
        }

        static void RerangeItem(List<string> groceries, string rerangeItem)
        {
            if (groceries.Contains(rerangeItem))
            {
                groceries.Remove(rerangeItem);
                groceries.Add(rerangeItem);

            }
        }
    }
}
