using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] studentInformation = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = studentInformation[0];
                decimal grade = decimal.Parse(studentInformation[1]);

                if(!students.ContainsKey(name))
                {
                    students[name] = new List<decimal>();
                }

                students[name].Add(grade);
            }

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Key} -> {string.Join(" ", student.Value):f2} (avg: {student.Value.Average():f2})");

            }

        }
    }
}
