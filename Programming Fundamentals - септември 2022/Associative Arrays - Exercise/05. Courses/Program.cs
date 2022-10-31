using System;
using System.Collections.Generic;

namespace _05._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            string commands;

            while ((commands= Console.ReadLine()) != "end")
            {
                string[] cmdArguments = commands.Split(" : ", StringSplitOptions.RemoveEmptyEntries);

                string courseName = cmdArguments[0];
                string studentsName = cmdArguments[1];

                if(!courses.ContainsKey(courseName))
                {
                    courses[courseName] = new List<string>();
                }
                courses[courseName].Add(studentsName);

            }

            foreach (var cours in courses)
            {
                string courseName = cours.Key;
                List<string> students = cours.Value;

                Console.WriteLine($"{courseName}: {students.Count}");
                foreach (var student in students)
                {
                    Console.WriteLine($"-- {student}");
                }

            }

        }
    }
}
