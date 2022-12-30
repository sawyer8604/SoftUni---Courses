using System;
using System.Linq;

namespace _04.GenericSwapMethodInteger
{
    public class StratUp
    {
        static void Main(string[] args)
        {
            int numberOfLine = int.Parse(Console.ReadLine());

            Box<int> box = new Box<int>();

            for (int i = 0; i < numberOfLine; i++)
            {
                int input = int.Parse(Console.ReadLine());

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
