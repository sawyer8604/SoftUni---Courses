
namespace _06._List_Manipulation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string input = string.Empty;

            bool isListChanged = false;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] commandArguments = input.Split(' ');

                string firstCommand = commandArguments[0];

                switch (firstCommand)
                {
                    case "Add":
                        int numberToAdd = int.Parse(commandArguments[1]);

                        numbers.Add(numberToAdd);
                        isListChanged = true;
                        break;

                    case "Remove":
                        int numberToRemove = int.Parse(commandArguments[1]);

                        numbers.Remove(numberToRemove);
                        isListChanged = true;
                        break;

                    case "RemoveAt":
                        int indexToRemoveAt = int.Parse(commandArguments[1]);

                        numbers.RemoveAt(indexToRemoveAt);
                        isListChanged = true;

                        break;

                    case "Insert":
                        int numbersToInsert = int.Parse(commandArguments[1]);
                        int indexToInsert = int.Parse(commandArguments[2]);

                        numbers.Insert(indexToInsert, numbersToInsert);
                        isListChanged = true;
                        break;

                    case "Contains":
                        int numbersToCheck = int.Parse(commandArguments[1]);

                        ChechkNumer(numbers, numbersToCheck);
                        
                        break;

                    case "PrintEven":

                        PrintEvenNumbers(numbers);                        

                        break;

                    case "PrintOdd":

                        PrintOddNumbers(numbers);
                       
                        break;

                    case "GetSum":
                        int sum = numbers.Sum();

                        Console.WriteLine(sum);                        

                        break;

                    case "Filter":
                        string condition = commandArguments[1];
                        int conditionNumber = int.Parse(commandArguments[2]);

                        printConditionNumbers(numbers, condition, conditionNumber);

                        break;
                }

            }
            if (isListChanged)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
            
        }
               

        static void ChechkNumer(List<int> numbers, int numbersToCheck)
        {
            if(numbers.Contains(numbersToCheck))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }

        }
        private static void PrintEvenNumbers(List<int> numbers)
        {
            foreach (int number in numbers)
            {
                if(number % 2 == 0)
                {
                    Console.Write($"{number} ");
                }
                
            }
            Console.WriteLine();
        }
        private static void PrintOddNumbers(List<int> numbers)
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

        private static void printConditionNumbers(List<int> numbers, string condition, int conditionNumber)
        {
            if(condition == "<")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] < conditionNumber)
                    {
                        Console.Write($"{numbers[i]} ");
                    }
                }
                Console.WriteLine();
            }
            if(condition == "<=")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] <= conditionNumber)
                    {
                        Console.Write($"{numbers[i]} ");
                    }
                }
                Console.WriteLine();
            }

            if (condition == ">")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] > conditionNumber)
                    {
                        Console.Write($"{numbers[i]} ");
                    }
                }
                Console.WriteLine();
            }

            if (condition == ">=")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] >= conditionNumber)
                    {
                        Console.Write($"{numbers[i]} ");
                    }
                }
                Console.WriteLine();
            }

        }

    }
}
