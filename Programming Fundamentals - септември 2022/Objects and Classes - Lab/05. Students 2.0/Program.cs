using System;
using System.Collections.Generic;

namespace _05._Students_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArguments = command.Split(' ');


                if (IsStudentExist(cmdArguments[0], cmdArguments[1], students))
                {
                    Student student = students.Find(student => student.FirstName == cmdArguments[0] && student.LastName == cmdArguments[1]);
                    student.Age = int.Parse(cmdArguments[2]);
                    student.HomeTown = cmdArguments[3];
                }
                else
                {

                    Student student = new Student(cmdArguments[0], cmdArguments[1], int.Parse(cmdArguments[2]), cmdArguments[3]);
                    students.Add(student);
                }
            }

            string filter = Console.ReadLine();

            foreach (Student student in students)
            {
                if (student.HomeTown == filter)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }


        static bool IsStudentExist(string firstName, string lastName, List<Student> students)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }

            return false;


        }
    }

    class Student
    {
        public Student(string firstName, string lastName, int age, string homeTown)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.HomeTown = homeTown;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }


    }
}
