using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._List_Of_Predicates
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Func<List<int>, int[], List<int>> result = (allNumbers, numberForDivisible) =>
            {
                int counter = 0;

                List<int> resultNumbers = new List<int>();

                bool isDivisible = false;

                foreach (var number in allNumbers)
                {
                    foreach (var division in numberForDivisible)
                    {
                        if(number % division == 0)
                        {
                            isDivisible = true;
                        }
                        else
                        {
                            isDivisible= false;
                            break;
                        }
                    }
                    if(isDivisible)
                    {
                        resultNumbers.Add(number);
                    }
                }

                return resultNumbers;
            };

            int number = int.Parse(Console.ReadLine());

            List<int> allNumbers = Enumerable.Range(1, number).ToList();

            int[] numberForDivision = Console.ReadLine()
                .Split(" ")                
                .Select(int.Parse)
                .ToArray();

           List<int> finalResult =  result(allNumbers, numberForDivision);

            Console.WriteLine(string.Join(" ", finalResult));
        }
    }
}
