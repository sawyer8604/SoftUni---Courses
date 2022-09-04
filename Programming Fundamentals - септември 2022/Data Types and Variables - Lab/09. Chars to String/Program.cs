using System;

namespace _09._Chars_to_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstDigit = char.Parse(Console.ReadLine());
            char secondDigit = char.Parse(Console.ReadLine());
            char thirdDigit = char.Parse(Console.ReadLine());

            string combineInString = $"{firstDigit}{secondDigit}{thirdDigit}";

            Console.WriteLine(combineInString);

        }
    }
}
