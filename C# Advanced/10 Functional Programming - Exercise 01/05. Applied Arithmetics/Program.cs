using System;
using System.Linq;

namespace _05._Applied_Arithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            string command;

            while ((command = Console.ReadLine()) != "end")
            {

                switch (command)
                {
                    case "add":
                        numbers = numbers.Select(x => x += 1).ToArray();

                        break;

                    case "multiply":
                        numbers = numbers.Select(x => x *= 2).ToArray();
                        break;

                    case "subtract":
                        numbers = numbers.Select(x => x -= 1).ToArray();
                        break;

                    case "print":
                        Console.WriteLine(string.Join(" ", numbers));
                        break;

                }
            }
        }
    }
}
