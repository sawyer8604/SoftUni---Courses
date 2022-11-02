using System;
using System.Linq;

namespace _05._Digits__Letters_and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            char[] digits = word.Where(w => char.IsDigit(w)).ToArray();

            char[] letters = word.Where(w => char.IsLetter(w)).ToArray();

            char[] others = word.Where(w => !char.IsLetterOrDigit(w)).ToArray();

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(others);
        }
    }
}
