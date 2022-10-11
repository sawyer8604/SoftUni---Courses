using System;
using System.Linq;

namespace _02._Manipulate_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "END")
            {
                string[] commands = command.Split();

                string firstCommand = commands[0];

                switch (firstCommand)
                {
                    case "Reverse":

                        Array.Reverse(input);

                        break;

                    case "Distinct":

                        string[] distinctArr = input.Distinct().ToArray();
                        input = distinctArr;
                        break;
                    case "Replace":

                        int index = int.Parse(commands[1]);
                        string element = commands[2];

                        if (index >= 0 && index < input.Length)
                        {
                            input[index] = element;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input!");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid input!");
                        break;

                }
            }
            Console.WriteLine(String.Join(", ", input));
        }
    }
}