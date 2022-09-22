using System;

namespace _09._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            switch (input)
            {
                case "int":
                    int firstNum = int.Parse(Console.ReadLine());
                    int secondNum = int.Parse(Console.ReadLine());

                    Console.WriteLine(greater(firstNum, secondNum));

                    break;
                case "char":
                    char firstChar = char.Parse(Console.ReadLine());
                    char secondChar = char.Parse(Console.ReadLine());
                    Console.WriteLine(greater(firstChar, secondChar));
                    break;

                case "string":

                    string firstWord = Console.ReadLine();
                    string secondWord = Console.ReadLine();
                    Console.WriteLine(greater(firstWord, secondWord));

                    break;
            }

            

        }

        private static int greater(int firstNum, int secondNum)
        {
            if (firstNum > secondNum)
            {
                return firstNum;
            }
            return secondNum;
        }
        private static char greater(char firstChar, char secondChar)
        {
            if(firstChar > secondChar)
            {
                return firstChar;
            }
            return secondChar;
        }

        private static string greater(string firstWord, string secondWord)
        {
            int result = firstWord.CompareTo(secondWord);

            if(result > 0)
            {
                return firstWord;
            }
            return secondWord;
        }
    }
}
