using System;

namespace _01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            getSmallestNum(firstNum, secondNum, thirdNum);

        }

        private static void getSmallestNum(int a, int b, int c)
        {
            int result = Math.Min(a, Math.Min(b, c));
            Console.WriteLine(result);

        }
    }
}
