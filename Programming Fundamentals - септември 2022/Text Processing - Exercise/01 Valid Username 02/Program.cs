using System;
using System.Collections.Generic;
using System.Linq;

namespace Valid_Username
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> users = Console.ReadLine().Split(", ").ToList();

            List<string> valid = users.Where(user => user.All(c => c == '-' || c == '_' || Char.IsLetterOrDigit(c)) && user.Length >= 3 && user.Length <= 16).ToList();

            Console.WriteLine(string.Join("\n", valid));
        }
    }
}