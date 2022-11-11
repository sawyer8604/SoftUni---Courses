using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            List<Students> students = new List<Students>();

            while ((input = Console.ReadLine()) != "end")
            {
                string[] studentArgument = input.Split(" ");

                string firstName = studentArgument[0];
                string lastName = studentArgument[1];
                int age = int.Parse(studentArgument[2]);
                string town = studentArgument[3];

                Students student = new Students(firstName, lastName, age, town);

                students.Add(student);

            }

            string cityName = Console.ReadLine();

            List<Students> studentsFromGivenTown = students.Where(student => student.Town == cityName).ToList();

            studentsFromGivenTown.ForEach(student => Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old."));

        }
    }

    public class Students
    {
        public Students(string firstName, string lastName, int age, string town)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Town = town;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Town { get; set; }


    }
}
