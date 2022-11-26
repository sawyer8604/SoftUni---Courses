using System;
using System.Reflection.Metadata.Ecma335;

namespace _01._The_Imitation_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string command;

            while ((command = Console.ReadLine()) != "Decode")
            {
                string[] cmdArguments = command.Split("|");

                string firstCommand = cmdArguments[0];

                switch (firstCommand)
                {
                    case "Move":
                        int numberOfLetters = int.Parse(cmdArguments[1]);
                        string substring = message.Substring(0, numberOfLetters);
                        message = message.Remove(0, numberOfLetters);
                        message = message.Insert(message.Length, substring);

                        break;

                    case "Insert":

                        int index = int.Parse(cmdArguments[1]);
                        string value = cmdArguments[2];

                        //if(index >= 0 && index < message.Length)
                        //{

                        //}
                        message = message.Insert(index, value);

                        break;

                    case "ChangeAll":
                        
                        string substrings = cmdArguments[1];
                        string replacement = cmdArguments[2];

                        //if (message.Contains(substrings))
                        //{


                        //}
                            message = message.Replace(substrings, replacement);

                        break;


                }

                
            }
            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}
