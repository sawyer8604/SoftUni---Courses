using System;

namespace _06._Tournament_of_Christmas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numberOfDaysForPlay = int.Parse(Console.ReadLine());

            int allWin = 0;
            int allLose = 0;

            double allSum = 0;

            for (int i = 1; i <= numberOfDaysForPlay; i++)
            {
                double sum = 0;
                int counterWin = 0;
                int counterLose = 0;

                string command = Console.ReadLine();
                while (command != "Finish")
                {
                    string winOrLose = Console.ReadLine();

                    if (winOrLose == "win")
                    {
                        counterWin++;
                        sum += 20;
                        allWin++;
                    }
                    else
                    {
                        counterLose++;
                        allLose++;
                    }





                    command = Console.ReadLine();
                }
                if (counterWin > counterLose)
                {
                    sum *= 1.1;
                }
                allSum += sum;

                allWin += counterWin;
                allLose += counterLose;



            }


            if (allWin > allLose)
            {
                allSum *= 1.2;
                Console.WriteLine($"You won the tournament! Total raised money: {allSum:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {allSum:f2}");
            }



        }
    }
}
