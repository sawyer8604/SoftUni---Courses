using System;

namespace _04._Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfGroups = int.Parse(Console.ReadLine());

            double percentMusala = 0;
            double percentMontblan = 0;
            double percentKilimandjaro = 0;
            double percentK2 = 0;
            double percentEverest = 0;

            double peopleMusala = 0;
            double peopleMontblan = 0;
            double peopleKilimandjaro = 0;
            double peopleK2 = 0;
            double peopleEverest = 0;

            double allPeople = 0;



            for (int group = 0; group < numberOfGroups; group++)
            {
                int numberOfPeople = int.Parse(Console.ReadLine());
                allPeople += numberOfPeople;

                if (numberOfPeople <= 5)
                {
                    peopleMusala += numberOfPeople;


                }
                else if (numberOfPeople > 5 && numberOfPeople <= 12)
                {
                    peopleMontblan += numberOfPeople;

                }
                else if (numberOfPeople > 12 && numberOfPeople <= 25)
                {
                    peopleKilimandjaro += numberOfPeople;

                }
                else if (numberOfPeople > 25 && numberOfPeople <= 40)
                {
                    peopleK2 += numberOfPeople;

                }
                else if (numberOfPeople >= 41)
                {
                    peopleEverest += numberOfPeople;

                }


            }

            percentMusala = peopleMusala / allPeople * 100;
            percentMontblan = peopleMontblan / allPeople * 100;
            percentKilimandjaro = peopleKilimandjaro / allPeople * 100;
            percentK2 = peopleK2 / allPeople * 100;
            percentEverest = peopleEverest / allPeople * 100;

            Console.WriteLine($"{percentMusala:F2}%");
            Console.WriteLine($"{percentMontblan:f2}%");
            Console.WriteLine($"{percentKilimandjaro:f2}%");
            Console.WriteLine($"{percentK2:f2}%");
            Console.WriteLine($"{percentEverest:f2}%");


        }
    }
}
