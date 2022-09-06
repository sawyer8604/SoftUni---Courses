using System;

namespace _03._Floating_Equality
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            
            double difference = Math.Abs(firstNum - secondNum);
            if (difference < 0.000001)
            {
                Console.WriteLine("True");

            }
            else
            {
                Console.WriteLine("False");
            }
            
        
        }
    }
}
