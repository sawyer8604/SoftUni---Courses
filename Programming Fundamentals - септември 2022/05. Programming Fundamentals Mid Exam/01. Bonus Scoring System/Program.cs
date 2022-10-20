using System;

namespace _01._Bonus_Scoring_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            int numberOfLecture = int.Parse(Console.ReadLine());
            int additionalBonus = int.Parse(Console.ReadLine());

            double maxBonus = 0;
            int maxAttendance = 0;

            for (int i = 0; i < numberOfStudents; i++)
            {
                int attendanceOfStudent = int.Parse(Console.ReadLine());

                double currentBonus = (double)attendanceOfStudent / numberOfLecture * (5 + (double)additionalBonus);

                if(currentBonus > maxBonus)
                {
                    maxBonus = currentBonus;
                    maxAttendance = attendanceOfStudent;
                }

            }
            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {maxAttendance} lectures.");


        }
    }
}
