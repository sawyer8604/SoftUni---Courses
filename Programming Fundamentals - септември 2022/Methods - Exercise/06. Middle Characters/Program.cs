using System;

namespace _06._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            string result = getMiddleCharacter(input);
            Console.WriteLine(result);

        }

        private static string getMiddleCharacter(string input)
        {
            string result = string.Empty;
            if(input.Length % 2 == 0)
            {
                for (int i = 1; i < 2; i++)
                {
                    result += input[input.Length / 2 - 1];
                    result += input[input.Length / 2];                    

                }
                return result;
            }
            else
            {
                result += input[input.Length / 2];
                return result;
            }

        }
    }
}
