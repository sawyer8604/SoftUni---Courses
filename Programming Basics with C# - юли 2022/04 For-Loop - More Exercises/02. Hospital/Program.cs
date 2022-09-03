using System;

namespace _02._Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int periodOfTime = int.Parse(Console.ReadLine());

            double numberOfDoctors = 7;

            double examinedPatients = 0;
            double notExaminedPatients = 0;

            for (int period = 1; period <= periodOfTime; period++)
            {
                int numberOfPatients = int.Parse(Console.ReadLine());

                if (period % 3 == 0 && examinedPatients < notExaminedPatients)
                {
                    numberOfDoctors++;

                }

                if (numberOfPatients <= numberOfDoctors)
                {
                    examinedPatients += numberOfPatients;
                }
                else
                {
                    examinedPatients += numberOfDoctors;
                    notExaminedPatients += numberOfPatients - numberOfDoctors;

                }



            }

            Console.WriteLine($"Treated patients: {examinedPatients}.");
            Console.WriteLine($"Untreated patients: {notExaminedPatients}.");
        }
    }
}
