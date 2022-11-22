using System;

namespace _02._Ascii_Sumator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstSymbol = char.Parse(Console.ReadLine());
            char secondSymbol = char.Parse(Console.ReadLine());

            string symbols = Console.ReadLine();
            int sum = 0;

            foreach (char symbol in symbols)
            {
                if(symbol > firstSymbol && symbol < secondSymbol)
                {
                    sum += (int)symbol;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
