using System;
using System.Text;

namespace _05._Digits__Letters_and_Other_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            char[] chars = word.ToCharArray();

            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder others = new StringBuilder();

            foreach (char ch in chars)
            {
                if(char.IsDigit(ch))
                {
                    digits.Append(ch);

                }
                else if(char.IsLetter(ch))
                {
                    letters.Append(ch);
                }
                else
                {
                    others.Append(ch);
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(others);
        }
    }
}
