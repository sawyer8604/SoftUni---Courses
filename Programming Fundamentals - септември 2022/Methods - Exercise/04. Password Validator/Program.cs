using System;

namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            if(!isContainSixToTen(input))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if(!consistLetterAndDigit(input))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if(!haveLeastTwoDigit(input))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if(isContainSixToTen(input) && consistLetterAndDigit(input) && haveLeastTwoDigit(input))
            {
                Console.WriteLine("Password is valid");
            }
        }

        

        private static bool isContainSixToTen(string input)
        {
            if (input.Length >= 6 && input.Length <= 10)
            {
                return true;
            }
            return false;

        }
        private static bool consistLetterAndDigit(string input)
        {
            foreach (char symbol in input)
            {
                if(!char.IsLetterOrDigit(symbol))
                {
                    return false;
                }

            }
            return true;
        }
        private static bool haveLeastTwoDigit(string input)
        {
            int count = 0;
            foreach (char symbol in input)
            {
                if(char.IsDigit(symbol))
                {
                    count++;

                }
            }
            if(count >= 2)
            {
                return true;
            }
            return false;
        }
    }
}
