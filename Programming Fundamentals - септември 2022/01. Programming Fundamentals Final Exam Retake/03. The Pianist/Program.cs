using System;
using System.Collections.Generic;

namespace _03._The_Pianist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> songs = new Dictionary<string, List<string>>();



            for (int i = 0; i < numbers; i++)
            {
                string[] input = Console.ReadLine().Split("|");

                string piece = input[0];
                string composer = input[1];
                string key = input[2];

                if (!songs.ContainsKey(piece))
                {
                    songs[piece] = new List<string>() { "", "" };
                }

                songs[piece][0] = composer;
                songs[piece][1] = key;
            }

            string command;

            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] cmdArguments = command.Split("|");

                string firstCommand = cmdArguments[0];

                switch (firstCommand)
                {
                    case "Add":

                        string pieceForAdd = cmdArguments[1];
                        string composerForAdd = cmdArguments[2];
                        string keyForAdd = cmdArguments[3];

                        if (!songs.ContainsKey(pieceForAdd))
                        {
                            songs[pieceForAdd] = new List<string>() { "", "" };
                            songs[pieceForAdd][0] = composerForAdd;
                            songs[pieceForAdd][1] = keyForAdd;

                            Console.WriteLine($"{pieceForAdd} by {composerForAdd} in {keyForAdd} added to the collection!");
                        }
                        else
                        {
                            Console.WriteLine($"{pieceForAdd} is already in the collection!");
                        }


                        break;

                    case "Remove":

                        string pieceForRemove = cmdArguments[1];

                        if (songs.ContainsKey(pieceForRemove))
                        {
                            songs.Remove(pieceForRemove);

                            Console.WriteLine($"Successfully removed {pieceForRemove}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {pieceForRemove} does not exist in the collection.");
                        }
                        break;

                    case "ChangeKey":

                        string pieceForChange = cmdArguments[1];
                        string newKey = cmdArguments[2];

                        if (songs.ContainsKey(pieceForChange))
                        {
                            songs[pieceForChange][1] = newKey;
                            Console.WriteLine($"Changed the key of {pieceForChange} to {newKey}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {pieceForChange} does not exist in the collection.");
                        }
                        break;


                }
            }

            foreach (var piece in songs)
            {

                Console.WriteLine($"{piece.Key} -> Composer: {piece.Value[0]}, Key: {piece.Value[1]}");

            }
        }


    }
}
