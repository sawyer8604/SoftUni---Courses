using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> topNumber = new List<int>();
                        
            double avarageNum = numbers.Average();

            bool isTopNumber = false;

            for (int i = 0; i < numbers.Count; i++)
            {
                if(numbers[i] > avarageNum)
                {
                    topNumber.Add(numbers[i]);
                    isTopNumber = true;
                }

            }
            
            topNumber.Sort();

            int counter = 0;

            if(topNumber.Count < 5)
            {
                counter = topNumber.Count;
            }
            else
            {
                counter = 5;
            }

            for (int i = 0; i < counter; i++)
            {
                Console.Write($"{topNumber[topNumber.Count - 1 -i]} ");
            }
            
            if(isTopNumber == false)
            {
                Console.WriteLine("No");
            }
           
        }
    }
}
