using System;

namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string commands = Console.ReadLine();

            string[] cmdArguments = commands.Split(' ');
            int sum = 0;


            char[] arguments = cmdArguments[0].ToCharArray();

            char[] arguments2 = cmdArguments[1].ToCharArray();

            int minLenght = Math.Min(arguments.Length, arguments2.Length);

            sum = characterSum(sum, arguments, arguments2, minLenght);

            Console.WriteLine(sum);
        }

        private static int characterSum(int sum, char[] arguments, char[] arguments2, int minLenght)
        {
            for (int i = 0; i < minLenght; i++)
            {
                if (i < minLenght)
                {
                    sum += (int)arguments[i] * (int)arguments2[i];

                }

            }

            if (arguments.Length > minLenght)
            {
                for (int i = minLenght; i < arguments.Length; i++)
                {
                    sum += arguments[i];
                }

            }
            else if (arguments2.Length > minLenght)
            {
                for (int i = minLenght; i < arguments2.Length; i++)
                {
                    sum += arguments2[i];
                }
            }

            return sum;
        }
    }
}
