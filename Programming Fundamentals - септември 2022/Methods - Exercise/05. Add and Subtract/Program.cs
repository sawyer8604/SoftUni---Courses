using System;

namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int result = addNumbers(firstNum, secondNum);
            int finalResult = substractNumbers(result, thirdNum);
            Console.WriteLine(finalResult);
        }

        private static int substractNumbers(int result, int thirdNUm)
        {
            int finalResult = result - thirdNUm;
            return finalResult;

        }

        private static int addNumbers(int firstNum, int secondNum)
        {
            int result = firstNum + secondNum;
            return result;
           

        }
    }
}
