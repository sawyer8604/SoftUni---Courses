using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Even_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            Dictionary<int, int> evenTimseNumber = new Dictionary<int, int>();

            for (int i = 0; i < numberOfLines; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if(!evenTimseNumber.ContainsKey(number))
                {
                    evenTimseNumber[number] = 0;
                }

                evenTimseNumber[number]++;
            }

            int numberWithEvenCount = evenTimseNumber.Single(x => x.Value % 2 == 0).Key;

            Console.WriteLine(numberWithEvenCount);
        }
    }
}
