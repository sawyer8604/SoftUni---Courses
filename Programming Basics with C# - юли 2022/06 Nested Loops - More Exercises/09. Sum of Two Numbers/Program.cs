using System;

namespace _09._Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int begin = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int fisrtNum = begin; fisrtNum <= end; fisrtNum++)
            {
                for (int secondNum = begin; secondNum <= end; secondNum++)
                {
                    counter++;
                    if (fisrtNum + secondNum == magicNumber)
                    {

                        Console.WriteLine($"Combination N:{counter} ({fisrtNum} + {secondNum} = {magicNumber})");
                        return;
                    }

                }
            }
            Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
        }
    }
}
