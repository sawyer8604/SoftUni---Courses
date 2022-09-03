using System;

namespace _06._Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfActor = Console.ReadLine();
            double pointsFromAccademy = double.Parse(Console.ReadLine());
            int numberOfЕvaluative = int.Parse(Console.ReadLine());


            for (int number = 1; number <= numberOfЕvaluative; number++)
            {
                string nameOfEvaluative = Console.ReadLine();
                double pontFromEvaluative = double.Parse(Console.ReadLine());
                int nameLength = nameOfEvaluative.Length;
                pointsFromAccademy = (nameLength * pontFromEvaluative / 2) + pointsFromAccademy;


                if (pointsFromAccademy > 1250.5)
                {

                    Console.WriteLine($"Congratulations, {nameOfActor} got a nominee for leading role with {pointsFromAccademy:f1}!");
                    break;
                }
            }
            if (pointsFromAccademy < 1250.5)
            {

                Console.WriteLine($"Sorry, {nameOfActor} you need {(1250.5 - pointsFromAccademy):f1} more!");
            }



        }
    }
}
