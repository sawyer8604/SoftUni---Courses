using System;
using System.Collections.Generic;

namespace _03._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfGuest = int.Parse(Console.ReadLine());

            List<string> listOfNames = new List<string>();

            for (int i = 0; i < numberOfGuest; i++)
            {
                string[] command = Console.ReadLine().Split();
                string name = command[0];

                if (listOfNames.Contains(name) && command[2] =="going!")
                {
                    Console.WriteLine($"{name} is already in the list!");
                }
                else if(listOfNames.Contains(name) && command[2] == "not")
                {
                    listOfNames.Remove(name);
                }
                else if (!listOfNames.Contains(name) && command[2] == "not")
                {
                    Console.WriteLine($"{name} is not in the list!");
                }
                else
                {
                    listOfNames.Add(name);
                }
            }

            foreach (var name in listOfNames)
            {
                Console.WriteLine(name);
            }

        }
    }
}
