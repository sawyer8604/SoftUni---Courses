using System;
using System.Linq;
using System.Collections.Generic;

namespace LongestIncreasingSubsequence
{
    class Program
    {
        public static void Main()
        {
            int[] sequence = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            int[] lis;
            int[] len = new int[sequence.Length];
            int[] prev = new int[sequence.Length];
            int maxLength = 0;
            int lastIndex = -1;

            
            for (int index = 0; index < sequence.Length; index++)
            {
                
                len[index] = 1;
                prev[index] = -1;
                               
                
                for (int j = 0; j < index; j++)
                {
                    
                    if (sequence[j] < sequence[index] && len[j] >= len[index])
                    {
                        len[index] = 1 + len[j];
                        prev[index] = j; 
                    }
                }
                
                if (len[index] > maxLength)
                {
                    maxLength = len[index];
                    lastIndex = index;
                }
            }
            lis = new int[maxLength];
            for (int i = 0; i < maxLength; i++)
            {
                lis[i] = sequence[lastIndex];
                lastIndex = prev[lastIndex];
            }
            Array.Reverse(lis);
            Console.WriteLine(string.Join(" ", lis));
        }
    }
}