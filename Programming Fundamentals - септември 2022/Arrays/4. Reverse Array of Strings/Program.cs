using System;

namespace _4._Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] elemets = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Array.Reverse(elemets);

            Console.WriteLine(string.Join(" ", elemets));
        }
    }
}
