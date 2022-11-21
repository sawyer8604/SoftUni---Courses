using System;
using System.Linq;

namespace _01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");
            bool isValid = false;

            foreach (var user in usernames)
            {
                foreach (var letter in user)
                {
                    if ((char.IsLetterOrDigit(letter) || letter == '-' || letter == '_') && user.Length > 3 && user.Length <= 16)
                    {
                        isValid = true;
                    }
                    else
                    {
                        isValid = false;
                        break;
                    }
                }
                if (isValid)
                {
                    Console.WriteLine(user);
                }

            }

        }
    }
}
