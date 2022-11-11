using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Students_2._0___02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            List<Students> students = new List<Students>();


            while ((input = Console.ReadLine()) != "end")
            {

                string[] studentsArgumnets = input.Split(" ");

                string firstName = studentsArgumnets[0];
                string lastName = studentsArgumnets[1];
                int age = int.Parse(studentsArgumnets[2]);
                string town = studentsArgumnets[3];

                Students student = new Students(firstName, lastName, age, town);

                bool isStudentExist = false;

                isStudentExist = AddOrChangeStudentInformation(students, age, town, student, isStudentExist);

            }
            string studentFromGivenCity = Console.ReadLine();

            List<Students> sortedStudent = students.Where(s => s.Town == studentFromGivenCity).ToList();

            sortedStudent.ForEach(student => Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old."));
        }

        static bool AddOrChangeStudentInformation(List<Students> students, int age, string town, Students student, bool isStudentExist)
        {
            foreach (Students stud in students)
            {
                if (stud.FirstName == student.FirstName && stud.LastName == student.LastName)
                {
                    stud.Age = age;
                    stud.Town = town;

                    isStudentExist = true;
                }

            }

            if (!isStudentExist)
            {
                students.Add(student);
            }

            return isStudentExist;
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
