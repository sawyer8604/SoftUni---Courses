using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<string> commands = new List<string>();

            string input = string.Empty;

            bool isChangesAreMade = false;

            while (input != "end")
            {
                input = Console.ReadLine();

                string[] command = input.Split();

                string firstCommand = command[0];



                switch (firstCommand)
                {

                    case "Add":
                        int numberToAdd = int.Parse(command[1]);

                        numbers.Add(numberToAdd);
                        isChangesAreMade = true;
                        break;

                    case "Remove":
                        int numberToRemove = int.Parse(command[1]);
                        numbers.Remove(numberToRemove);
                        isChangesAreMade = true;
                        break;

                    case "RemoveAt":

                        int indexToRemove = int.Parse(command[1]);
                        numbers.RemoveAt(indexToRemove);
                        isChangesAreMade = true;
                        break;

                    case "Insert":

                        int numberToInsert = int.Parse(command[1]);
                        int indexToInsert = int.Parse(command[2]);

                        numbers.Insert(indexToInsert, numberToInsert);
                        isChangesAreMade = true;

                        break;

                    case "Contains":

                        int containsNumber = int.Parse(command[1]);

                        if (numbers.Contains(containsNumber))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }

                        break;

                    case "PrintEven":
                        printEven(numbers);

                        break;

                    case "PrintOdd":
                        printOdd(numbers);

                        break;

                    case "GetSum":

                        int sum = getSum(numbers);
                        Console.WriteLine(sum);

                        break;

                    case "Filter":
                        printFilter(command[1], int.Parse(command[2]), numbers);

                        break;

                }
            }
            if (isChangesAreMade == true)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }

        }

        private static void printEven(List<int> numbers)
        {
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    Console.Write($"{number} ");
                }

            }
            Console.WriteLine();
        }

        private static void printOdd(List<int> numbers)
        {
            foreach (int number in numbers)
            {
                if (number % 2 != 0)
                {
                    Console.Write($"{number} ");
                }

            }
            Console.WriteLine();
        }

        private static int getSum(List<int> numbers)
        {
            int sum = 0;
            sum = numbers.Sum();
            return sum;

        }
        private static void printFilter(string command, int numberToFilter, List<int> numbers)
        {

            switch (command)
            {
                case "<":
                    ;

                    foreach (int number in numbers)
                    {
                        if (number < numberToFilter)
                        {
                            Console.Write($"{number} ");
                        }
                    }
                    Console.WriteLine();
                    break;

                case "<=":

                    foreach (int number in numbers)
                    {
                        if (number <= numberToFilter)
                        {
                            Console.Write($"{number} ");
                        }
                    }
                    Console.WriteLine();
                    break;

                case ">":
                    foreach (int number in numbers)
                    {
                        if (number > numberToFilter)
                        {
                            Console.Write($"{number} ");
                        }
                    }
                    Console.WriteLine();
                    break;

                case ">=":

                    foreach (int number in numbers)
                    {
                        if (number >= numberToFilter)
                        {
                            Console.Write($"{number} ");
                        }
                    }
                    Console.WriteLine();
                    break;

            }

        }
    }
}
