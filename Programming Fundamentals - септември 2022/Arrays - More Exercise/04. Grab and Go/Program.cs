using System;
using System.Linq;

namespace _04._Grab_and_Go
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int numberToFind = int.Parse(Console.ReadLine());

            int currentIndex = 0;
            long sum = 0;
            bool isFind = false;

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (numberToFind == numbers[i])
                {
                    isFind = true;
                    currentIndex = i;
                    break;
                }

            }
            for (int i = 0; i < currentIndex; i++)
            {
                int currentNum = numbers[i];
                sum += (long)currentNum;
            }

            if (isFind)
            {                
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("No occurrences were found!");
            }
            
        }
    }
}
