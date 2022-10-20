using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string command;

            while ((command = Console.ReadLine()) != "Craft!")
            {
                string[] cmdArguments = command.Split(" - ");

                string firstCommand = cmdArguments[0];

                switch (firstCommand)
                {
                    case "Collect":
                        string itemToCollect = cmdArguments[1];
                        if(input.Contains(itemToCollect))
                        {
                            continue;
                        }
                        else
                        {
                            input.Add(itemToCollect);
                        }

                        break;

                    case "Drop":
                        string itemToDrop = cmdArguments[1];
                        if (input.Contains(itemToDrop))
                        {
                            input.Remove(itemToDrop);
                        }
                        else
                        {
                            continue;
                            
                        }

                        break;

                    case "Combine Items":

                        string itemToCombine = cmdArguments[1];

                        string[] oldNewitem = itemToCombine.Split(":");

                        string oldItem = oldNewitem[0];
                        string newItem = oldNewitem[1]; 

                        if(input.Contains(oldItem))
                        {
                            int oldItemIndex = input.IndexOf(oldItem);
                            input.Insert(oldItemIndex + 1, newItem);
                        }
                        else
                        {
                            continue;
                        }

                        break;

                    case "Renew":
                        string intemToRenew = cmdArguments[1];

                        if(input.Contains(intemToRenew))
                        {
                            input.Add(intemToRenew);
                            input.Remove(intemToRenew);
                        }

                        break;

                }
                               

            }

            Console.WriteLine(string.Join(", ", input));
        }
    }
}
