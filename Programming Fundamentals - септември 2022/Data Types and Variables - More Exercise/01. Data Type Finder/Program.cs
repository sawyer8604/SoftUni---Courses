using Microsoft.VisualBasic;
using System;

namespace _01._Data_Type_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int integerType = 0;
            float floatingType = 0;
            char character;
            bool Boolean;
            string strings = "";

            while (input != "END")
            {
                if (int.TryParse(input, out integerType))
                {
                    Console.WriteLine($"{input} is integer type");

                }
                else if (float.TryParse(input, out floatingType))
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (char.TryParse(input, out character))
                {
                    Console.WriteLine($"{input} is character type");
                }
                else if (bool.TryParse(input, out Boolean))
                {
                    Console.WriteLine($"{input} is boolean type");

                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }

                input = Console.ReadLine();

            }



        }
    }
}
