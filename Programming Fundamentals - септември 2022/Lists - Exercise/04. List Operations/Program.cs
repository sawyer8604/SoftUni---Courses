using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> givenNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] tokens = command.Split();

                string firstCommand = tokens[0];


                switch (firstCommand)
                {
                    case "Add":
                        int addNumber = int.Parse(tokens[1]);
                        givenNumbers.Add(addNumber);

                        break;

                    case "Insert":


                        int number = int.Parse(tokens[1]);
                        int index = int.Parse(tokens[2]);

                        if (index < 0 || index > (givenNumbers.Count))
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        givenNumbers.Insert(index, number);
                        break;

                    case "Remove":
                        int indexToRemove = int.Parse(tokens[1]);

                        if (indexToRemove < 0 || indexToRemove > (givenNumbers.Count))
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        givenNumbers.RemoveAt(indexToRemove);

                        break;

                    case "Shift":

                        string shiftLeftOrRight = tokens[1];

                        if (shiftLeftOrRight == "left")
                        {
                            int countLeft = int.Parse(tokens[2]);

                            for (int i = 0; i < countLeft; i++)
                            {
                                givenNumbers.Add(givenNumbers[0]);
                                givenNumbers.RemoveAt(0);
                            }
                        }
                        else if (shiftLeftOrRight == "right")
                        {
                            int countRight = int.Parse(tokens[2]);

                            for (int i = 0; i < countRight; i++)
                            {
                                givenNumbers.Insert(0, givenNumbers[givenNumbers.Count - 1]);
                                givenNumbers.RemoveAt(givenNumbers.Count - 1);
                            }
                        }

                        break;


                }

                command = Console.ReadLine();

            }

            Console.WriteLine(String.Join(" ", givenNumbers));


        }
    }
}
