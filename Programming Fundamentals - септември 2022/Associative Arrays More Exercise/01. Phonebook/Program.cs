using System;
using System.Collections.Generic;

namespace _01._Phonebook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();


            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] commands = input.Split(" ");

                string firstCommand = commands[0];

                if(firstCommand == "A")
                {
                    string name = commands[1];
                    string phone = commands[2];

                    if(!phoneBook.ContainsKey(name))
                    {
                        phoneBook[name] = phone;
                    }
                    else
                    {
                        phoneBook[name] = phone;
                    }

                }
                else
                {
                    string name = commands[1];
                    if(!phoneBook.ContainsKey(name))
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                    else
                    {
                        string number = phoneBook[name];

                        Console.WriteLine($"{name} -> {number}");
                    }
                }
            }
        }
    }
}
