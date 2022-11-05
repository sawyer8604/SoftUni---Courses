using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<char> inputLetters = input.ToList();
            
            for (int i = 0; i < inputLetters.Count -1; i++)
            {
                if(inputLetters[i] == inputLetters[i + 1])
                {
                    inputLetters.RemoveAt(i);
                    i--;
                }
                

            }
            Console.WriteLine(String.Join("", inputLetters));


            
        }
    }
}
