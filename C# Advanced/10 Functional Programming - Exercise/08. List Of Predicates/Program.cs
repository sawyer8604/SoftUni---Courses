using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._List_Of_Predicates
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Func<List<int>, List<int>, List<int>> filter = (number , matches)=>
            {
                

                List<int> divisiblenumbers = new List<int>();

                foreach (var num in number)
                {
                    bool isDivisible = true;

                    foreach (var match in matches)
                    {
                        if (num % match != 0)
                        {
                            isDivisible = false;
                            break;
                        }
                    }

                    if (isDivisible)
                    {
                        divisiblenumbers.Add(num);
                    }
                }

                return divisiblenumbers;


            };

            int endIndex = int.Parse(Console.ReadLine());

            List<int> numbers = Enumerable.Range(1, endIndex).ToList();

            List<int> dividers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            numbers = filter(numbers, dividers);

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
