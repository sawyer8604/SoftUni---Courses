using System;

namespace _04._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] chars = input.ToCharArray();

            for (int i = 0; i < input.Length; i++)
            {
                int firsElement = chars[i];
                firsElement += 3;
                chars[i] = (char)firsElement;
            }

            Console.WriteLine(String.Join("", chars));
        }
    }
}
