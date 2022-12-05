using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> number = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            if(number.Count < 1 )
            {
                Console.WriteLine("No");
                return;
            }

            double avarage = number.Average();


            List<int> orderedList = number.Where(x => x > avarage).OrderByDescending(y => y).ToList();

            if (orderedList.Count < 1)
            {
                Console.WriteLine("No");
                return;
            }

            for (int i = 0; i < orderedList.Count; i++)
            {
                if (i == 5)
                {
                    break;
                }
                Console.Write($"{orderedList[i]} ");
                
            }


        }
    }
}
