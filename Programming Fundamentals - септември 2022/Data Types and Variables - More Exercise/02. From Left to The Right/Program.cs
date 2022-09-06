using System;

namespace _02._From_Left_to_The_Right
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            
            

            for (int i = 0; i < number; i++)
            {
                bool isSpace = false;
                long firstNum = 0;
                long secondNum = 0;

                string input = Console.ReadLine();

                char[] charArray = input.ToCharArray();

                for (int j = 0; j < charArray.Length; j++)
                {
                    int space = charArray[j];
                    int minus = charArray[j];

                    if (isSpace == false)
                    {
                        if (space == 32)
                        {
                            isSpace = true;
                            continue;
                        }
                        if (minus == 45)
                        {
                            continue;
                        }
                        firstNum += Math.Abs(int.Parse(charArray[j].ToString()));
                        

                    }
                    else
                    {
                        if (minus == 45)
                        {
                            continue;
                        }
                        secondNum += Math.Abs(int.Parse(charArray[j].ToString()));
                    }
                }
                
                if (firstNum > secondNum)
                {
                    Console.WriteLine(firstNum);
                }
                else
                {
                    Console.WriteLine(secondNum);
                }

            }
            
        }
    }
}
