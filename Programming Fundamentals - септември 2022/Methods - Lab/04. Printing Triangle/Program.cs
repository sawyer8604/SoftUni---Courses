using System;

namespace _04._Printing_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfRow = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfRow; i++)
            {
                pritTriangle(1, i);
            }
            for (int i = numberOfRow - 1; i >= 1; i--)
            {
                pritTriangle(1, i);
            }            
            
        }
        static void pritTriangle(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");

            }
            Console.WriteLine();                     

           
        }
    }
}
