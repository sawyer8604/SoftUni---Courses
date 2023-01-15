using System;
using System.Linq;

namespace _03._Custom_Min_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Func<int[], int> getMinValue = (numbers) =>
            {
                int number = int.MaxValue;

                foreach (var crrNum in numbers)
                {
                    if(crrNum < number)
                    {
                        number = crrNum;    
                    }

                }

                return number;
            };

            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int minValue = getMinValue(numbers);

            Console.WriteLine(minValue);
        }
    }
}
