using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._SoftUni_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vip = new HashSet<string>();
            HashSet<string> regular = new HashSet<string>();

            const int NUMBEROFDIGITS = 8;

            string command;

            while ((command = Console.ReadLine()) != "PARTY")
            {
                if (command.Length == NUMBEROFDIGITS)
                {
                    if (char.IsDigit(command[0]))
                    {
                        vip.Add(command);
                    }
                    else
                    {
                        regular.Add(command);
                    }
                }

            }

            while ((command = Console.ReadLine()) != "END")
            {

                if (vip.Contains(command))
                {
                    vip.Remove(command);
                }

                if (regular.Contains(command))
                {
                    regular.Remove(command);
                }
            }

            int counter = vip.Count + regular.Count;

            Console.WriteLine(counter);

            foreach (var guest in vip)
            {
                Console.WriteLine(guest);
            }

            foreach (var guest in regular)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
