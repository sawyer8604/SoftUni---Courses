using System;
using System.Collections.Generic;
using System.Linq;


namespace P06_FoldAndSum
{
    class P06_FoldAndSum
    {
        static void Main(string[] args)
        { 
            //  {
            // Use a LINQ expression:
            //•	Row 1, left part: take the first k numbers and reverse.
            //•	Row 1, right part: reverse and take the first k numbers.
            //•	Concatenate the left and the right part of row 1.
            //•	Row 2: skip the first k numbers and take the next 2 * k numbers.
            //•	Sum the arrays row1 and row2: var sum = row1.Select((x, index) => x + row2[index]).


            var numList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            var quaterLenth = numList.Count / 4;
            var foldedNums = numList
                .Skip(quaterLenth * 3)
                .Reverse()
                .ToList();
            foldedNums = new List<int>(
                numList
                .Take(quaterLenth)
                .Reverse()
                .ToList()
                .Concat(foldedNums)
                );
            numList = numList
                .Skip(quaterLenth)
                .Take(quaterLenth * 2)
                .ToList();
            var result = new List<int>();
            for (int i = 0; i < quaterLenth * 2; i++)
            {
                result.Add(numList[i] + foldedNums[i]);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}