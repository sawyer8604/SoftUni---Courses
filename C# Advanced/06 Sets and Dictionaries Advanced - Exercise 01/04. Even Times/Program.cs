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

            Dictionary<int, int> numbers = new Dictionary<int, int>();

            for (int i = 0; i < numberOfLines; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if(!numbers.ContainsKey(number))
                {
                    numbers[number] = 0;
                }
                numbers[number]++;
            }

            int uniqueNumber = numbers.Where(x => x.Value % 2 == 0).FirstOrDefault().Key;
            Console.WriteLine(uniqueNumber);
        }
    }
}
