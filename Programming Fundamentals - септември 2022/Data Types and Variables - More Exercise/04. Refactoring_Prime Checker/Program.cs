using System;

namespace _4._Refactoring_Prime_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 2; i <= number; i++)

            {

                bool isTrue = true;
                string boolisTrue = "true";

                for (int j = 2; j < i; j++)

                {

                    if (i % j == 0)

                    {

                        isTrue = false;
                        boolisTrue = "false";


                        break;

                    }

                }

                Console.WriteLine($"{i} -> {boolisTrue}");

            }

        }
    }
}
