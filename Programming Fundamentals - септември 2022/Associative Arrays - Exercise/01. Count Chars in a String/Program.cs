using System;
using System.Collections.Generic;

namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] letters = Console.ReadLine().ToCharArray();

            Dictionary<char, int> words = new Dictionary<char, int>();

            Console.WriteLine();


            foreach (var letter in letters)
            {
                if (letter != ' ')
                {
                    if (!words.ContainsKey(letter))
                    {
                        words.Add(letter, 0);
                    }


                    words[letter]++;


                    //if (!words.ContainsKey(letter))         Second WAy
                    //{
                    //    words.Add(letter, 1);
                    //}
                    //else
                    //{
                    //    words[letter]++;
                    //}


                }
            }

            foreach (var word in words)
            {
                Console.WriteLine($"{word.Key} -> {word.Value}");

            }

        }
    }
}
