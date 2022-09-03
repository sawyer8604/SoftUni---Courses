using System;
class _07_Min_Number
{
    static void Main()
    {

        string nameOfStudent = Console.ReadLine();

        double avarageGrade = 0;
        int currentClass = 0;
        int allClass = 12;
        int nextClass = 0;

        while (nextClass < allClass)
        {
            nextClass++;
            double currentGrade = double.Parse(Console.ReadLine());

            if (currentGrade < 4)
            {
                currentClass++;

            }

            if (currentClass == 2)
            {

                nextClass--;

                Console.WriteLine($"{nameOfStudent} has been excluded at {nextClass} grade");
                break;

            }

            avarageGrade += currentGrade;


        }

        avarageGrade /= allClass;
        if (nextClass >= 12)
        {
            Console.WriteLine($"{nameOfStudent} graduated. Average grade: {avarageGrade:f2}");
        }



    }
}