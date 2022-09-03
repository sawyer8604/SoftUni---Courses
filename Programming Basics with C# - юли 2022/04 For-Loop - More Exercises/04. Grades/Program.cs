using System;

namespace _04._Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nuberOfStudents = int.Parse(Console.ReadLine());
            double precentOfStudent1 = 0;
            double precentOfStudent2 = 0;
            double percentOfStudent3 = 0;
            double percentOfStudent4 = 0;

            double allPrecentOfStudent1 = 0;
            double allPrecentOfStudent2 = 0;
            double allPrecentOfStudent3 = 0;
            double allPrecentOfStudent4 = 0;

            double examGradeForAvarage = 0;

            double avarageGrade = 0;


            for (int students = 0; students < nuberOfStudents; students++)
            {
                double examGrade = double.Parse(Console.ReadLine());

                examGradeForAvarage += examGrade;

                if (examGrade >= 2 && examGrade < 3)
                {
                    precentOfStudent1++;
                }
                else if (examGrade >= 3 && examGrade < 4)
                {
                    precentOfStudent2++;

                }
                else if (examGrade >= 4 && examGrade < 5)
                {
                    percentOfStudent3++;

                }
                else if (examGrade >= 5)
                {
                    percentOfStudent4++;

                }


            }

            allPrecentOfStudent1 = precentOfStudent1 / nuberOfStudents * 100;
            allPrecentOfStudent2 = precentOfStudent2 / nuberOfStudents * 100;
            allPrecentOfStudent3 = percentOfStudent3 / nuberOfStudents * 100;
            allPrecentOfStudent4 = percentOfStudent4 / nuberOfStudents * 100;

            avarageGrade = examGradeForAvarage / nuberOfStudents;

            Console.WriteLine($"Top students: {allPrecentOfStudent4:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {allPrecentOfStudent3:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {allPrecentOfStudent2:f2}%");
            Console.WriteLine($"Fail: {allPrecentOfStudent1:f2}%");
            Console.WriteLine($"Average: {avarageGrade:f2}");
        }
    }
}
