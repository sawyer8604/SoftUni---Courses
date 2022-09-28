using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> gausNum = new List<int>();

            for (int i = 0; i < numbers.Count / 2; i++)
            {

                int currentNum =  numbers[i] + numbers[numbers.Count - 1 - i];
                gausNum.Add(currentNum);
                

            }

            if (numbers.Count % 2 != 0)
            {
                gausNum.Add(numbers[numbers.Count / 2]);
            }
            Console.WriteLine(String.Join(" ", gausNum));
        }
    }
}
