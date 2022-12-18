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

            for (int i = 0; i < word.Length; i++)
            {
                char crrSymbol = word[i];

                if (!symbols.ContainsKey(crrSymbol))
                {
                    symbols[crrSymbol] = 0;
                }

                symbols[crrSymbol]++;
            }

            foreach (KeyValuePair<char, int> symbol in symbols)
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }

        }
    }
}
