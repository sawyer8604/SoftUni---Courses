using System;

namespace _06._Triples_of_Latin_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            char firstCharacter = '`';
            char secondCharacter = '`';
            char thirdCharacter = '`';

            for (int i = 0; i < number; i++)
            {
                
                firstCharacter++;
                secondCharacter = '`';
                for (int j = 0; j < number; j++)
                {
                    
                    secondCharacter++;
                    thirdCharacter = '`';

                    for (int k = 0; k < number; k++)
                    {
                        
                        thirdCharacter++;
                        Console.WriteLine($"{firstCharacter}{secondCharacter}{thirdCharacter}");
                        

                    }
                }
            }
        }
    }
}
