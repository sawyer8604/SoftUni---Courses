using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());

            List<Students> students = new List<Students>();

            for (int i = 0; i < countOfStudents; i++)
            {
                string[] studentsArguments = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string firstName = studentsArguments[0];
                string lastName = studentsArguments[1];
                decimal grade = decimal.Parse(studentsArguments[2]);

                Students student = new Students(firstName, lastName, grade);

                students.Add(student);
            }

            foreach (Students student in students.OrderByDescending(s=>s.Grade))
            {
                Console.WriteLine(student.ToString());

            }
        }
    }

    public class Students
    {
        public Students(string firstName, string lastName, decimal grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Grade { get; set; }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}: {this.Grade}";
        }

    }
}
