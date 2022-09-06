using System;

namespace _05._Decrypting_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int numberOfLines = int.Parse(Console.ReadLine());
            string allWord = "";
            

            for (int i = 0; i < numberOfLines; i++)
            {
                char digit = char.Parse(Console.ReadLine());
                string word = digit.ToString();

                for (int j = 0; j < word.Length; j++)
                {
                    int wordKey = word[j];
                    wordKey += key;                    
                    char ch = (char)wordKey;
                        
                    allWord += ch;
                }

               
            }
            Console.WriteLine(allWord);
        }
    }
}
