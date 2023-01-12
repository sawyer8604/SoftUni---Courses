using System;
using System.Collections.Generic;

namespace _05._Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            SortedDictionary<char, int> symbols = new SortedDictionary<char, int>();

            foreach (var symbol in word)
            {
                if(!symbols.ContainsKey(symbol))
                {
                    symbols[symbol] = 0;
                }
                symbols[symbol]++;
            }

            foreach (var (symbol, times) in symbols)
            {
                Console.WriteLine($"{symbol}: {times} time/s");
            }
        }
    }
}
