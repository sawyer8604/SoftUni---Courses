using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Moving_Target
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] commandArguments = input.Split(' ');

                string firstCommand = commandArguments[0];

                switch (firstCommand)
                {
                    case "Shoot":
                        int indexForShoot = int.Parse(commandArguments[1]);
                        int power = int.Parse(commandArguments[2]);
                        if (indexForShoot >= 0 && indexForShoot < numbers.Count)
                        {
                            if (numbers[indexForShoot] > 0)
                            {
                                numbers[indexForShoot] -= power;
                                if (numbers[indexForShoot] <= 0)
                                {
                                    numbers.RemoveAt(indexForShoot);
                                }
                                    
                            }
                            
                        }
                        else
                        {
                            continue;
                        }

                        break;

                    case "Add":
                        int indexToAdd = int.Parse(commandArguments[1]);
                        AddIndex(numbers, commandArguments, indexToAdd);

                        break;

                    case "Strike":
                        int strikeIndex = int.Parse(commandArguments[1]);
                        int strikeRadius = int.Parse(commandArguments[2]);

                        int startIndex = strikeIndex - strikeRadius;
                        int endIndex = strikeIndex + strikeRadius;

                        if (startIndex < 0 || endIndex >= numbers.Count)
                        {
                            Console.WriteLine("Strike missed!");
                            break;
                        }


                        if (strikeIndex >= 0 && strikeIndex < numbers.Count)
                        {
                            for (int i = startIndex; i <= endIndex; i++)
                            {
                                numbers.RemoveAt(startIndex);
                            }
                        }

                        break;



                }

            }

            Console.WriteLine(String.Join("|", numbers));
        }

        static void AddIndex(List<int> numbers, string[] commandArguments, int indexToAdd)
        {
            int numbersToInsert = int.Parse(commandArguments[2]);
            if (indexToAdd >= 0 && indexToAdd < numbers.Count)
            {
                numbers.Insert(indexToAdd, numbersToInsert);
            }
            else
            {
                Console.WriteLine($"Invalid placement!");
            }
        }
    }
}
