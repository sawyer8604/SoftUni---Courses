using System;

namespace _07._Predicate_For_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Action<string[], Predicate<int>> IsNameSmallerThanGivenLength = (names, match) =>
            {

                foreach (var name in names)
                {
                    if(match(name.Length))
                    {
                        Console.WriteLine(name);
                    }
                }
            };

            int length = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine().Split(" ");

            IsNameSmallerThanGivenLength(names, crrLength => crrLength <= length);

        }
    }
}
