using System;

namespace _03._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            switch (command)
            {
                case "add":
                    addNumber(firstNumber, secondNumber);
                    break;

                case "multiply":
                    multiplyNumber(firstNumber, secondNumber);
                    break;

                case "subtract":
                    subtractNumber(firstNumber, secondNumber);
                    break;
                case "divide":
                    divideNumber(firstNumber, secondNumber);
                    break;
            }
            
            
            

        }

        static void divideNumber(int firstNumber, int secondNumber)
        {
            int result =firstNumber / secondNumber;
            Console.WriteLine(result);
        }

        static void subtractNumber(int firstNumber, int secondNumber)
        {
            int result = Math.Abs(firstNumber - secondNumber);
            Console.WriteLine(result);
        }

        static void addNumber(int firstNumber, int secondNumber)
        {
            int result = firstNumber + secondNumber;
            Console.WriteLine(result);
        }
        static void multiplyNumber(int firstNumber, int secondNumber)
        {
            int result = firstNumber * secondNumber;
            Console.WriteLine(result);
        }
    }
}
