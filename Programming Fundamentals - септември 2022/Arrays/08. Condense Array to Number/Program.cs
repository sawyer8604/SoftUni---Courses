using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int sum = 0;      
            

            for (int i = numbers.Length; i > 1; i--)
            {


                int[] condensed = new int[numbers.Length - 1];

                for (int j = 0; j < condensed.Length; j++)
                {
                    
                    condensed[j] = numbers[j] + numbers[j + 1];
                    
                    
                }
                numbers = condensed;

            }

            Console.WriteLine(numbers[0]);

        }
    }
}
