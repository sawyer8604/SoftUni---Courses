using System;

namespace _04._Reverse_Array_of_Strings_Second_Way
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] elements = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < elements.Length / 2; i++)
            {
                string tempElement = elements[i];

                elements[i] = elements[elements.Length -1 - i]; // d = [0]  c = [1]

                elements[elements.Length - 1 - i] = tempElement; // a = [3]  b = [2]

            }
            Console.WriteLine(string.Join(" ", elements));
        }
    }
}
