using System;

namespace _03._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstSymbol = char.Parse(Console.ReadLine());
            char secondSymbol = char.Parse(Console.ReadLine());

            symbolsBetweenTwo(firstSymbol, secondSymbol);
        }

        private static void symbolsBetweenTwo(char start, char end)
        {
            if (end < start)
            {
                for (int i = end +1; i < start; i++)
                {
                    Console.Write($"{(char)i} ");
                }
            }
            else
            {
                for (int i = start +1; i < end; i++)
                {
                    Console.Write($"{(char)i} ");
                }
            }
        }
    }
}
