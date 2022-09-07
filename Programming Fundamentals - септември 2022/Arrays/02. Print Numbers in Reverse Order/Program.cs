using System;

namespace _02._Print_Numbers_in_Reverse_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] number = new int[length];

            for (int i = 0; i < length; i++)
            {
                number[i] = int.Parse(Console.ReadLine());
                                
            }
            for (int i = length -1; i >= 0; i--)
            {
                Console.Write($"{number[i]} ");

            }
                        

        }
    }
}
