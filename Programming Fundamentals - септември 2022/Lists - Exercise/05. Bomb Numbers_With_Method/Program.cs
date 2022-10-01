using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> commands = Console.ReadLine().Split().Select(int.Parse).ToList();

            sumOfLeftNumbers(numbers, commands);

        }

        static void sumOfLeftNumbers(List<int> numbers, List<int> commands)
        {
            int bombNumber = commands[0];
            int power = commands[1];
            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                int index = 0;
                if (numbers[i] == bombNumber)
                {
                    index = i;
                    int start = i - power;
                    int end = i + power;

                    if (start < 0)
                    {

                        start = 0;

                    }
                    if (end > numbers.Count - 1)
                    {
                        end = numbers.Count - 1;
                    }
                    for (int j = start; j <= end; j++)
                    {

                        numbers[j] = 0;

                    }

                }


            }
            sum = numbers.Sum();
            Console.WriteLine(sum);
        }
    }
}
