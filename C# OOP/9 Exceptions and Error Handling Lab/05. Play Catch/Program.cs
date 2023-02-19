using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Play_Catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] elements = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Play play = new Play(elements);
            int counter = 0;

            while (counter != 3)
            {
                string[] commands = Console.ReadLine().Split(" ");
                string firstCommand = commands[0];

                try
                {
                    if(firstCommand == "Replace")
                    {
                        int index = int.Parse(commands[1]);
                        int element = int.Parse(commands[2]);

                        play.Replace(index, element);
                    }
                    else if(firstCommand == "Print")
                    {
                        int startIndex = int.Parse(commands[1]);
                        int EndIndex = int.Parse(commands[2]);

                        play.Print(startIndex, EndIndex);

                    }
                    else if(firstCommand == "Show")
                    {
                        int index = int.Parse(commands[1]);

                        play.Show(index);

                    }

                }
                catch (IndexOutOfRangeException)
                {
                    counter++;

                    Console.WriteLine("The index does not exist!");
                }
                catch(FormatException)
                {
                    counter++;
                    Console.WriteLine("The variable is not in the correct format!");
                }
            }

            Console.WriteLine(string.Join(", ",play.Elements));
        }
    }

    public class Play
    {
        public Play(int[] elements)
        {
            Elements = elements;
        }
        public int[] Elements { get; private set; }
        public void Replace(int index, int element)
        {
            Elements[index] = element;
        }
        public void Print (int startIndex , int endIndex)
        {
            List<int> result = new List<int>();

            for (int i = startIndex; i <= endIndex; i++)
            {
                result.Add(Elements[i]);
            }

            Console.WriteLine(string.Join(", ", result));
        }
        public void Show (int index)
        {
            Console.WriteLine(Elements[index]);
        }
    }
    

}
