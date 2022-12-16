using System;
using System.Collections.Generic;

namespace _08._SoftUni_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            HashSet<string> vip = new HashSet<string>();

            HashSet<string> regular = new HashSet<string>();

            string input;

            bool isPArty = false;

            while ((input = Console.ReadLine()) != "END")
            {
                if (isPArty == false)
                {

                    if (input.Length == 8)
                    {
                        char firstLetter = input[0];

                        if (char.IsDigit(firstLetter))
                        {
                            vip.Add(input);

                        }
                        else
                        {
                            regular.Add(input);

                        }
                    }
                }

                if (input == "PARTY")
                {
                    isPArty = true;
                    continue;
                }

                if (isPArty)
                {
                    if (vip.Contains(input))
                    {
                        vip.Remove(input);
                    }
                    else if (regular.Contains(input))
                    {
                        regular.Remove(input);
                    }
                }
            }

            int count = vip.Count + regular.Count;

            Console.WriteLine(count);

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
