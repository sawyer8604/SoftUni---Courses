using System;

namespace _11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            int secondNum = int.Parse(Console.ReadLine());
            double result = 0;

            switch (operation)
            {
                case "+":
                    result = getAddition(firstNum, operation, secondNum);
                    Console.WriteLine(result);
                    break;
                case "-":
                    result = getSubtraction(firstNum, operation, secondNum);
                    Console.WriteLine(result);
                    break;

                case "*":
                    result = getMultiplication(firstNum, operation, secondNum);
                    Console.WriteLine(result);
                    break;

                case "/":
                    result = getDivision(firstNum, operation, secondNum);
                    Console.WriteLine(result);
                    break;

            }
                        
            
        }

        static double getSubtraction(double firsNum, string operation, double secondNum)
        {
            double result = firsNum - secondNum;
            return result;
        }

        static double getAddition(double firsNum, string operation, double secondNum)
        {
            double result = firsNum + secondNum;
            return result;
        }

        static double getDivision(double firsNum, string operation, double secondNum)
        {
            double result = firsNum / secondNum;
            return result;
        }

        static double getMultiplication(double firsNum, string operation, double secondNum)
        {
            double result = firsNum * secondNum;
            return result;
        }
    }
}
