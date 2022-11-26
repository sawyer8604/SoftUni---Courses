using System;
using System.Collections;
using System.Collections.Generic;

namespace _03ThePianistWith_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, Piece> songs = new Dictionary<string, Piece>();
            int numberOflines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOflines; i++)
            {
                string[] input = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
                string piece = input[0];
                string composer = input[1];
                string key = input[2];

                if (!songs.ContainsKey(piece))
                {
                    songs[piece] = new Piece(composer, key);
                }

            }

            string command;

            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] cmdArguments = command.Split("|");

                string firstCommand = cmdArguments[0];

                if (firstCommand == "Add")
                {
                    string newPiece = cmdArguments[1];
                    string newComposer = cmdArguments[2];
                    string newKey = cmdArguments[3];

                    if(!songs.ContainsKey(newPiece))
                    {
                        songs[newPiece] = new Piece(newComposer, newKey);
                        Console.WriteLine($"{newPiece} by {newComposer} in {newKey} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{newPiece} is already in the collection!");
                    }

                }
                else if (firstCommand == "Remove")
                {
                    string pieceForRemove = cmdArguments[1];

                    if(songs.ContainsKey(pieceForRemove))
                    {
                        songs.Remove(pieceForRemove);
                        Console.WriteLine($"Successfully removed {pieceForRemove}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {pieceForRemove} does not exist in the collection.");
                    }
                }
                else if (firstCommand == "ChangeKey")
                {
                    string piece = cmdArguments[1];
                    string newKey = cmdArguments[2];

                    if(songs.ContainsKey(piece))
                    {
                        songs[piece].Key = newKey;
                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }

                }
            }

            foreach (var song in songs)
            {
                Console.WriteLine($"{song.Key} -> Composer: {song.Value.Composer}, Key: {song.Value.Key}");
            }
        }
    }

    public class Piece
    {
        public Piece(string composer, string key)
        {
            Composer = composer;
            Key = key;
        }

        public string Composer { get; set; }
        public string Key { get; set; }
    }
}
