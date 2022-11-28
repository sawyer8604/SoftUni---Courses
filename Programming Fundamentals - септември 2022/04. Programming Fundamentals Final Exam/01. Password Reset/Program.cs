using System;
using System.Linq;

namespace _01._Password_Reset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string command;

            while ((command = Console.ReadLine()) != "Done")
            {
                string[] cmdArguments = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string firstCommand = cmdArguments[0];

                switch (firstCommand)
                {
                    case "TakeOdd":

                        string crrInput = "";

                        for (int i = 1; i < input.Length; i++)
                        {
                            

                            if(i % 2 != 0)
                            {
                                crrInput += input[i];
                            }
                            
                            
                        }

                        input = crrInput;
                        Console.WriteLine(input);
                        break;


                    case "Cut":

                        int index = int.Parse(cmdArguments[1]);

                        int length = int.Parse(cmdArguments[2]);

                        input = input.Remove(index, length);

                        Console.WriteLine(input);

                        break;


                    case "Substitute":

                        string substring = cmdArguments[1];
                        string substitute = cmdArguments[2];

                        if(input.Contains(substring))
                        {
                            input = input.Replace(substring, substitute);
                            Console.WriteLine(input);
                        }
                        else
                        {
                            Console.WriteLine("Nothing to replace!");
                        }
                        break;
                }
            }
            Console.WriteLine($"Your password is: {input}");
        }
    }
}
