using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArguments = command.Split();

                string FirstCommand = cmdArguments[0];

                switch (FirstCommand)
                {
                    case "Add":
                        int numberToAdd = int.Parse(cmdArguments[1]);

                        numbers.Add(numberToAdd);

                        break;

                        case "Insert":
                        int numbersToInsert = int.Parse(cmdArguments[1]);
                        int indexToInsert = int.Parse(cmdArguments[2]);

                        if(indexToInsert < 0 || indexToInsert > numbers.Count)
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }

                        numbers.Insert(indexToInsert, numbersToInsert);
                        break;

                    case "Remove":
                        int indexToRemove = int.Parse(cmdArguments[1]);

                        if (indexToRemove < 0 || indexToRemove > numbers.Count)
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }

                        numbers.RemoveAt(indexToRemove);

                        break;

                    case "Shift":
                        string leftOrRight = cmdArguments[1];
                        int countForMove = int.Parse(cmdArguments[2]);

                        if(leftOrRight == "left")
                        {
                            ShiftLeftNumber(numbers, countForMove);
                        }
                        else
                        {
                            ShifRighttNumber(numbers, countForMove);
                        }

                        break;

                }

            }
            Console.WriteLine(String.Join(" ", numbers));
        }

        

        static void ShiftLeftNumber(List<int> numbers, int countForMove)
        {
            for (int i = 0; i < countForMove; i++)
            {
                numbers.Add(numbers[0]);
                numbers.RemoveAt(0);
            }
        }

        static void ShifRighttNumber(List<int> numbers, int countForMove)
        {
            for (int i = 0; i < countForMove; i++)
            {
                numbers.Insert(0, numbers[numbers.Count-1]);
                numbers.RemoveAt(numbers.Count-1);
            }
        }
    }
}
