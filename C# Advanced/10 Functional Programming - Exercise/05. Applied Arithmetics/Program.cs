using System;
using System.Linq;

namespace _05._Applied_Arithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Func<int[], int[]> add = number =>
            {

                for (int i = 0; i < number.Length; i++)
                {
                    number[i] += 1;
                }

                return number;
            };

            Func<int[], int[]> multiple = number =>
            {

                for (int i = 0; i < number.Length; i++)
                {
                    number[i] *= 2;
                }

                return number;
            };

            Func<int[], int[]> subtract = number =>
            {

                for (int i = 0; i < number.Length; i++)
                {
                    number[i] -= 1;
                }

                return number;
            };

            Action<int[]> printNum = number =>
            {
                Console.WriteLine(string.Join(" ", number));
            };

            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string command;


            while ((command = Console.ReadLine()) != "end")
            {
                PrintResult(command, numbers, add, multiple, subtract, printNum);

            }
        }

        static void PrintResult(string command, int[] numbers, Func<int[], int[]> add, Func<int[], int[]> multiple, Func<int[], int[]> subtract, Action<int[]> printNum)
        {
            switch (command)
            {
                case "add":

                    numbers = add(numbers);

                    break;

                case "multiply":

                    numbers = multiple(numbers);

                    break;

                case "subtract":

                    numbers = subtract(numbers);

                    break;

                case "print":

                    printNum(numbers);

                    break;
            }
        }
    }
}
