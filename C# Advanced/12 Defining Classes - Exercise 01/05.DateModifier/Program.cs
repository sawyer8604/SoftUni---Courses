using System;

namespace _05.DateModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateModifier dateModifier = new DateModifier();

            string firstDate = Console.ReadLine();

            string secondDate = Console.ReadLine();

            Console.WriteLine(dateModifier.GetDifferenceBetweenTwoDates(firstDate, secondDate)); 

        }
    }
}
