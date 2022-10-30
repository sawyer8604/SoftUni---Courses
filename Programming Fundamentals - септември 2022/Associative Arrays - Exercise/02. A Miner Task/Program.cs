using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resourses = new Dictionary<string, int>();

            string commands;


            while ((commands = Console.ReadLine()) != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!resourses.ContainsKey(commands))
                {
                    resourses.Add(commands, 0);
                }

                resourses[commands] += quantity;


            }

            foreach (var item in resourses)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");

            }

        }
    }
}
