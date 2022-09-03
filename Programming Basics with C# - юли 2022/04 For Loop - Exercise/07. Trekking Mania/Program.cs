using System;

namespace _07._Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfGroup = int.Parse(Console.ReadLine());
            int numberOfFirstGroup = 0;
            int numberOfSecondGroup = 0;
            int numberOfThirdGroup = 0;
            int numberOfFourthFroup = 0;
            int numberOfFiftGroup = 0;

            double percentOfFirstGroup = 0;
            double percentOfSecondGroup = 0;
            double percentOfThirdGroup = 0;
            double percentOfFourthGroup = 0;
            double percentOfFifthGroup = 0;
            double numberOfAllPeople = 0;


            for (int number = 0; number < numberOfGroup; number++)
            {
                int numberOfPeopleInGroup = int.Parse(Console.ReadLine());

                numberOfAllPeople += numberOfPeopleInGroup;

                if (numberOfPeopleInGroup <= 5)
                {
                    numberOfFirstGroup += numberOfPeopleInGroup;

                }
                else if (numberOfPeopleInGroup > 5 && numberOfPeopleInGroup <= 12)
                {
                    numberOfSecondGroup += numberOfPeopleInGroup;

                }
                else if (numberOfPeopleInGroup > 12 && numberOfPeopleInGroup <= 25)
                {
                    numberOfThirdGroup += numberOfPeopleInGroup;

                }
                else if (numberOfPeopleInGroup > 25 && numberOfPeopleInGroup <= 40)
                {
                    numberOfFourthFroup += numberOfPeopleInGroup;

                }
                else if (numberOfPeopleInGroup >= 41)
                {
                    numberOfFiftGroup += numberOfPeopleInGroup;

                }


            }


            percentOfFirstGroup = numberOfFirstGroup / numberOfAllPeople * 100;
            percentOfSecondGroup = numberOfSecondGroup / numberOfAllPeople * 100;
            percentOfThirdGroup = numberOfThirdGroup / numberOfAllPeople * 100;
            percentOfFourthGroup = numberOfFourthFroup / numberOfAllPeople * 100;
            percentOfFifthGroup = numberOfFiftGroup / numberOfAllPeople * 100;


            Console.WriteLine($"{percentOfFirstGroup:f2}%");
            Console.WriteLine($"{percentOfSecondGroup:f2}%");
            Console.WriteLine($"{percentOfThirdGroup:f2}%");
            Console.WriteLine($"{percentOfFourthGroup:f2}%");
            Console.WriteLine($"{percentOfFifthGroup:f2}%");

        }
    }
}
