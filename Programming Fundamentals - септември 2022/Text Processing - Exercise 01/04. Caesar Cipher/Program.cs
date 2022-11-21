using System;

namespace _04._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string encriptedWords = string.Empty;
            
                foreach (char ch in input)
                {
                    int addnumber = ch + 3;
                    encriptedWords += (char)addnumber;
                }
            
            Console.WriteLine(encriptedWords);
        }
    }
}
