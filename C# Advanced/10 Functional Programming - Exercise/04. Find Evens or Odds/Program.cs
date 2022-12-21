using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<int, int, string> getEvenOrOdd = (startNum, endNum, command) =>
                {
                    List<int> numbers = new List<int>();

                    Predicate<int> isEven = n => n % 2 == 0;

                    if (command == "odd")
                    {
                        for (int i = startNum; i <= endNum; i++)
                        {
                            if (!isEven(i))
                            {
                                numbers.Add(i);
                            }
                        }
                    }
                    else
                    {
                        for (int i = startNum; i <= endNum; i++)
                        {
                            if (isEven(i))
                            {
                                numbers.Add(i);
                            }
                        }
                    }

                    Console.WriteLine(string.Join(" ", numbers));

                };


            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int starNum = input[0];
            int edndNum = input[1];

            string command = Console.ReadLine();

            getEvenOrOdd(starNum, edndNum, command);
        }
    }
}
