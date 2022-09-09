using System;
using System.Drawing;
using System.Linq;

namespace _09._Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int sequensLength = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int[] DNA = new int[sequensLength];
            int dnaSum = 0;
            int dnaCount = -1;
            int dnaStartIndex = -1;
            int dnaSamples = 0;

            int sample = 0;
            

            while (input != "Clone them!")
            {
                sample++;
                int[] currDNA = input.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                int currCount = 0;
                int currStartIndex = 0;
                int currEndIndex = 0;
                int currDNASum = 0;
                bool isCurrentDNABetter = false;

                int count = 0;

                for (int i = 0; i < currDNA.Length; i++)
                {
                    if(currDNA[i] != 1)
                    {
                        count = 0;
                        continue;
                    }
                    count++;

                    if (count > currCount)
                    {
                        currCount = count;
                        currEndIndex = i;
                    }

                }

                currStartIndex = currEndIndex - currCount + 1;

                currDNASum = currDNA.Sum();

                if (currCount > dnaCount)
                {
                    isCurrentDNABetter = true;
                }
                else if (currCount == dnaCount)
                {
                    if (currStartIndex < dnaStartIndex)
                    {
                        isCurrentDNABetter = true;
                    }
                    else if (currStartIndex == dnaStartIndex)
                    {
                        if (currDNASum > dnaSum)
                        {
                            isCurrentDNABetter = true;
                        }
                    }
                }
                
                if (isCurrentDNABetter)
                {
                    DNA = currDNA;
                    dnaCount = currCount;
                    dnaStartIndex = currStartIndex;
                    dnaSum = currDNASum;
                    dnaSamples = sample;
                }

                input = Console.ReadLine();

            }
            Console.WriteLine($"Best DNA sample {dnaSamples} with sum: {dnaSum}.");
            Console.WriteLine(String.Join(" ", DNA));
        }
    }
}
