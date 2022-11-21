using System;

namespace _08._Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int position = 0;

            double sum = 0;

            foreach (string word in input)
            {

                char firstChar = word[0];

                char lastChar = word[^1]; // or [word.Length - 1]

                double numbers = double.Parse(word[1..^1]); // between 0 - and word.lenght -1

                if (char.IsUpper(firstChar))
                {
                    position = firstChar - 64;

                     numbers /= position;
                }
                else
                {
                    position = firstChar - 96;

                    numbers *= position;
                }

                if (char.IsUpper(lastChar))
                {
                    position = lastChar - 64;

                    numbers -= position;
                }
                else
                {
                    position = lastChar - 96;

                    numbers += position;
                }
                sum += numbers;

            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
