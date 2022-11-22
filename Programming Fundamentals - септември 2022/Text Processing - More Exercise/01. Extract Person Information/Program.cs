using System;

namespace _01._Extract_Person_Information
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());


            for (int i = 0; i < numberOfLines; i++)
            {
                string input = Console.ReadLine();

                int nameFirstIndex = input.IndexOf('@');
                int nameLastIndex = input.IndexOf('|');


                string name = string.Empty;

                for (int j = nameFirstIndex +1; j < nameLastIndex; j++)
                {
                    name += input[j];
                }

                int ageFirstIndex = input.IndexOf('#');
                int ageLastIndex = input.IndexOf('*');

                string age = string.Empty;

                for (int k = ageFirstIndex + 1; k < ageLastIndex; k++)
                {
                    age += input[k];
                }

                Console.WriteLine($"{name} is {age} years old.");

            }
        }
    }
}
