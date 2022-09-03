using System;

namespace _05._Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string word = string.Empty;

            for (int i = 1; i <= number; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                string command = currentNumber == 2 ? "a" : currentNumber == 22 ? "b" : currentNumber == 222 ? "c" :
                currentNumber == 3 ? "d" : currentNumber == 33 ? "e" : currentNumber == 333 ? "f" :
                currentNumber == 4 ? "g" : currentNumber == 44 ? "h" : currentNumber == 444 ? "i" :
                currentNumber == 5 ? "j" : currentNumber == 55 ? "k" : currentNumber == 555 ? "l" :
                currentNumber == 6 ? "m" : currentNumber == 66 ? "n" : currentNumber == 666 ? "o" :
                currentNumber == 7 ? "p" : currentNumber == 77 ? "q" : currentNumber == 777 ? "r" : currentNumber == 7777 ? "s" :
                currentNumber == 8 ? "t" : currentNumber == 88 ? "u" : currentNumber == 888 ? "v" :
                currentNumber == 9 ? "w" : currentNumber == 99 ? "x" : currentNumber == 999 ? "y" : currentNumber == 9999 ? "z" :
                currentNumber == 0 ? " " : "";

                word += command;


            }
            Console.Write(word);


        }
    }
}
