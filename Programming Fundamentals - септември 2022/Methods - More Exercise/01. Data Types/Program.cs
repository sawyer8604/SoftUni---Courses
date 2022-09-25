using System;

namespace _01._Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            switch (input)
            {
                case "int":
                    int firstNum = int.Parse(Console.ReadLine());
                    Console.WriteLine(getResult(firstNum));
                    break;

                case "real":
                    double secondNum = double.Parse(Console.ReadLine());
                    double result = getResult(secondNum);
                    Console.WriteLine($"{result:f2}");
                    break;

                case "string":
                    string word = Console.ReadLine();
                    Console.WriteLine(getResult(word));
                    break;


            }
            
        }

        private static int getResult(int number)
        {
            int result = number * 2;
            return result;
        }
        private static double getResult(double number)
        {
            double result = number * 1.5;
            return result;
        }
        private static string getResult(string word)
        {
            string result = $"${word}$";
            return result;
        }
    }
}
