using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Palindromes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] delimiters = new char[] { ' ', ',', '.', '?', '!' };

            string[] words = Console.ReadLine().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            List<string> polindroms = new List<string>();

            bool isPolindrome = false;

            foreach (var word in words)
            {

                for (int i = 0; i < word.Length / 2; i++)
                {
                    if (word[i] == word[word.Length - 1 - i])
                    {
                        isPolindrome = true;
                    }
                    else
                    {
                        isPolindrome = false;
                        break;
                    }
                }

                
                if (isPolindrome)
                {
                    polindroms.Add(word);
                }

                if (word.Length == 1)
                {
                    polindroms.Add(word);
                }
            }

            polindroms = polindroms.Distinct().OrderBy(a => a).ToList();

            Console.WriteLine(String.Join(", ", polindroms));
        }
        
    }
}
