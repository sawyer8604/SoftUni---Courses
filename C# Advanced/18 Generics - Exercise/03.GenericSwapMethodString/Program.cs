using System;
using System.Linq;

namespace _03.GenericSwapMethodString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfLine = int.Parse(Console.ReadLine());

            Box<string> box = new Box<string>();

            for (int i = 0; i < numberOfLine; i++)
            {
                string input = Console.ReadLine();

                box.Items.Add(input);
            }

            int[] indexesForSwap = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int firstIndex = indexesForSwap[0];
            int secondIndex = indexesForSwap[1];

            box.Swap(firstIndex, secondIndex);

            Console.WriteLine(box.ToString());
        }
    }
}
