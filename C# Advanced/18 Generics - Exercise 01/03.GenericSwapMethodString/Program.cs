using System;
using System.Linq;

namespace _03.GenericSwapMethodString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            Box<string> box = new Box<string>();

            for (int i = 0; i < numberOfLines; i++)
            {
                string input = Console.ReadLine();

                box.Items.Add(input);
            }

            int[] indexForSwap = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int firstIndex = indexForSwap[0];
            int secondIndex = indexForSwap[1];

            box.Swap(firstIndex, secondIndex);

            Console.WriteLine(box.ToString());
        }
    }
}
