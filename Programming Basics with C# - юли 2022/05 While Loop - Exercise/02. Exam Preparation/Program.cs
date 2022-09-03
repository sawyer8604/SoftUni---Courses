using System;
class HelloWorld
{
    static void Main()
    {

        int unsatisfyGrades = int.Parse(Console.ReadLine());
        int numberOfTask = 0;
        double avarageScore = 0;
        int badGrades = 0;
        string nameOfTask = Console.ReadLine();
        string lastProblem = string.Empty;
        double grades = 0;
        double allgrades = 0;

        while (nameOfTask != "Enough")
        {
            lastProblem = nameOfTask;

            grades = double.Parse(Console.ReadLine());
            allgrades += grades;



            if (grades <= 4)
            {

                badGrades++;

                if (badGrades == unsatisfyGrades)
                {

                    Console.WriteLine($"You need a break, {badGrades} poor grades.");
                    break;
                }

            }




            numberOfTask++;


            nameOfTask = Console.ReadLine();

        }

        avarageScore = allgrades / numberOfTask;
        if (nameOfTask == "Enough")
        {

            Console.WriteLine($"Average score: {avarageScore:f2}");
            Console.WriteLine($"Number of problems: {numberOfTask}");
            Console.WriteLine($"Last problem: {lastProblem}");
        }
    }
}