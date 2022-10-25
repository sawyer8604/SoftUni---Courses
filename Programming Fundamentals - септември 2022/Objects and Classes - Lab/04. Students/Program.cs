
namespace _04._Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string commands;

            while ((commands = Console.ReadLine()) != "end")
            {
                string[] cmdArguments = commands.Split();

                Student student = new Student
                {
                    FirstName = cmdArguments[0],
                    LastName = cmdArguments[1],
                    Age = int.Parse(cmdArguments[2]),
                    HomeTown = cmdArguments[3]
                };

                students.Add(student);

               
                
            }
            string cityName = Console.ReadLine();

            foreach (Student student in students)
            {
                if (student.HomeTown == cityName)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }

    class Student
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
}
