using System;
using System.Diagnostics.Tracing;

namespace _01_SoftUni_Reception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstEmployee = int.Parse(Console.ReadLine());
            int secondEmployee = int.Parse(Console.ReadLine());
            int thirdEmployee = int.Parse(Console.ReadLine());

            int allEmployeeEfficiency = firstEmployee + secondEmployee + thirdEmployee;

            int numberOfStudents = int.Parse(Console.ReadLine());
            int counter = 0;

            while (numberOfStudents > 0)
            {
                counter++;
                if(counter % 4 == 0)
                {
                    counter++;
                }
                numberOfStudents -= allEmployeeEfficiency;

            }

            Console.WriteLine($"Time needed: {counter}h.");
        }
    }
}
