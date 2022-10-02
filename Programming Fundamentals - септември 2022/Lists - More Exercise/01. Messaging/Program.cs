using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Messaging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string word = Console.ReadLine();
            int wordLength = word.Length;
            
            
            for (int i = 0; i < numbers.Count; i++)
            {
                int currElement = numbers[i];
                
                int sum = 0;

                while (currElement > 0)
                {
                    sum += currElement % 10;
                    currElement /= 10;
                }
                int counter = 0;

                for (int j = 0; j < sum; j++)
                {
                    counter++;
                    if (counter == word.Length)
                    {
                        counter = 0;
                    }
                                            
                    
                }
                char currChar = word[counter];
                Console.Write(currChar);
                
                string newMessage = word.Remove(counter, 1);
                word = newMessage;


            }
                        
        }
    }
}
