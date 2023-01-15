using System;
using System.Linq;

namespace _07._Predicate_For_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lengthOfWord = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine().Split(" ");

            string[] result = names.Where(x => x.Length <= lengthOfWord).ToArray();

            Console.WriteLine(string.Join(Environment.NewLine, result));
        }
    }
}
