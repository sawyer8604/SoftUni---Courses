using System;
using System.Linq;

namespace _02._Array_Modifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandArg = command.Split();

                string firstCommand = commandArg[0];

                switch (firstCommand)
                {
                    case "swap":
                        int firstIndex = int.Parse(commandArg[1]);
                        int secondIndex = int.Parse(commandArg[2]);

                        SwapNumbers(number, firstIndex, secondIndex);

                        break;

                    case "multiply":
                        int firstIndexToMultiply = int.Parse(commandArg[1]);
                        int secondIndexToMultipl = int.Parse(commandArg[2]);

                        number[firstIndexToMultiply] = number[firstIndexToMultiply] * number[secondIndexToMultipl];

                        break;

                    case "decrease":
                        for (int i = 0; i < number.Length; i++)
                        {
                            number[i] -= 1;
                        }

                        break;
                }

            }

            Console.WriteLine(string.Join(", ", number));

        }

        static void SwapNumbers(int[] number, int firstIndex, int secondIndex)
        {
            int currentNum = number[firstIndex];
            number[firstIndex] = number[secondIndex];
            number[secondIndex] = currentNum;
        }
    }
}
