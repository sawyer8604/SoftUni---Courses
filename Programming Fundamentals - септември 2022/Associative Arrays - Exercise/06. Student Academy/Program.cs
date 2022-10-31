using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            for (int i = 0; i < countOfStudents; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if(!students.ContainsKey(name))
                {
                    students[name] = new List<double>();
                }

                students[name].Add(grade);

            }

            foreach (var student in students)
            {
                string studentName = student.Key;
                List<double> studentGrade = student.Value;

                if(studentGrade.Average() >= 4.5)
                {
                    Console.WriteLine($"{studentName} -> {(studentGrade.Average()):f2}");
                }                 
                

            }

        }
    }
}
