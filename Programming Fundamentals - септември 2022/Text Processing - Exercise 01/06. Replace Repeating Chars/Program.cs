using System;
using System.Collections.Generic;

namespace _06._Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<string> singleLetter = new List<string>();

            singleLetter.Add(input[0].ToString());

            for (int i = 0; i < input.Length - 1; i++)
            {
                char currChar = input[i];

                if(currChar != input[i+1])
                {
                    
                    singleLetter.Add(input[i+1].ToString());
                }
                                
            }

            Console.WriteLine(String.Join("", singleLetter));
        }
    }
}
