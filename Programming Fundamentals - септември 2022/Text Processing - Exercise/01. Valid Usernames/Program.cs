using System;
using System.Linq;

namespace _01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(", ");

            bool isValid = true;


            foreach (string word in words)
            {
                if (word.Length >= 3 && word.Length <= 16)
                {
                    char[] letter = word.ToCharArray();


                    foreach (var ch in letter)
                    {
                        if (!(char.IsLetterOrDigit(ch) || ch == '-' || ch == '_'))
                        {
                            isValid = false;
                            break;
                        }
                        else
                        {
                            isValid = true;
                        }
                    }
                    if(isValid)
                    {
                        Console.WriteLine(String.Join(Environment.NewLine, word));
                    }
                }
                    
            }


        }
    }
}

