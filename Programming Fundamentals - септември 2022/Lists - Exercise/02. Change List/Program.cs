using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] tokens = command.Split();
                
                string firstComand = tokens[0];

                if (firstComand == "Delete")
                {
                    int element = int.Parse(tokens[1]);
                    numbers.RemoveAll(number => number == element);
                }

                if (firstComand == "Insert")
                {
                    int elment = int.Parse(tokens[1]);
                    int position = int.Parse(tokens[2]);

                    numbers.Insert(position, elment);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", numbers));

        }
    }
}
