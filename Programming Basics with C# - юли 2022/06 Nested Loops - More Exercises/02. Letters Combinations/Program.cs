using System;

namespace _02._Letters_Combinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char z = char.Parse(Console.ReadLine());
            char n = char.Parse(Console.ReadLine());
            int counter = 0;

            for (char i = a; i <= z; i++)
            {
                for (char j = a; j <= z; j++)
                {
                    for (char k = a; k <= z; k++)
                    {
                        if (i == n || j == n || k == n)
                        {
                            continue;
                        }
                        else
                        {
                            counter++;
                            Console.Write($"{i}{j}{k} ");
                        }
                    }
                }

            }
            Console.Write(counter);
        }
    }
}
