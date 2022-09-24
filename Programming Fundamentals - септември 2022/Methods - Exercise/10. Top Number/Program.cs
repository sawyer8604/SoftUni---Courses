using System;

namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            divisibleByEight(number);
        }

        private static void divisibleByEight(int number)
        {

            for (int i = 1; i <= number; i++)
            {

                int num = i;
                int currentNum = 0;
                bool isDifferentFromZero = false;

                while (num > 0)
                {
                    currentNum += num % 10;
                    if (num % 2 != 0)
                    {
                        isDifferentFromZero = true;
                    }

                    num /= 10;
                }
                if (currentNum % 8 == 0 && isDifferentFromZero == true)
                {

                    Console.WriteLine(i);

                }


            }
        }
    }
}
