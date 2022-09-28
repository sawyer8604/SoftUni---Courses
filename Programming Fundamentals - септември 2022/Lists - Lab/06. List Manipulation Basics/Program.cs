using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<string> commands = new List<string>();
            string input = string.Empty;

            while (input != "end")
            {
                input = Console.ReadLine();

                string[] tokens = input.Split();

                string command = tokens[0];

                switch (command)
                {
                    case "Add":
                        int numberToAdd = int.Parse(tokens[1]);

                        numbers.Add(numberToAdd);

                        break;

                    case "Remove":
                        int numberToRemove = int.Parse(tokens[1]);
                        numbers.Remove(numberToRemove);

                        break;

                    case "RemoveAt":

                        int indexToRemove = int.Parse(tokens[1]);
                        numbers.RemoveAt(indexToRemove);
                        break;

                    case "Insert":

                        int numberToInsert = int.Parse(tokens[1]);
                        int indexToInsert = int.Parse(tokens[2]);

                        numbers.Insert(indexToInsert, numberToInsert);

                        break;



                }                

            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
