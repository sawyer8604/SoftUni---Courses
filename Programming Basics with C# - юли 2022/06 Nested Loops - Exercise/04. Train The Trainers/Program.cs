using System;

namespace _04._Train_The_Trainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfJury = int.Parse(Console.ReadLine());
            string nameOfPrezentation = Console.ReadLine();
            double allAvarageGrades = 0;
            int counterForAllAvarage = 0;
            while (nameOfPrezentation != "Finish")
            {
                double avarageGrades = 0;
                counterForAllAvarage++;
                int counterForAvarage = 0;
                for (int i = 0; i < numberOfJury; i++)
                {
                    counterForAvarage++;


                    double grades = double.Parse(Console.ReadLine());
                    avarageGrades += grades;
                }
                avarageGrades /= counterForAvarage;
                Console.WriteLine($"{nameOfPrezentation} - {avarageGrades:f2}.");


                allAvarageGrades += avarageGrades;


                nameOfPrezentation = Console.ReadLine();
            }

            allAvarageGrades /= counterForAllAvarage;
            Console.WriteLine($"Student's final assessment is {allAvarageGrades:f2}.");

        }
    }
}
