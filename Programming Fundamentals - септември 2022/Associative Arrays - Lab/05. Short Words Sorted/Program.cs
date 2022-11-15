using System;
using System.Linq;

namespace _05._Short_Words_Sorted
{
    internal class Program
    {
        static void Main(string[] args)
        {
                //            •	Use a LINQ expression:
                //o Filter by word length: Where(…)
                //o Order by word: OrderBy(…)
                //o Use distinct to avoid repeated words: Distinct().


            char[] seperators = new char[] { '.', ',', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' };

            string[] words = Console.ReadLine().ToLower().Split(seperators, StringSplitOptions.RemoveEmptyEntries).ToArray();

            words = words.Where(w => w.Length < 5).Distinct().OrderBy(w => w).ToArray();

            Console.WriteLine(String.Join(", ", words));
        }
    }
}
