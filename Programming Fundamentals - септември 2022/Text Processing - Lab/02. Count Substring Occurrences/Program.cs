using System;


namespace _02._Count_Substring_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();

            string searchedWord = Console.ReadLine().ToLower();

            int counter = 0;
            int startIndex = 0;

            while (true)
            {
                int index = text.IndexOf(searchedWord, startIndex);

                if (index >= 0)
                {
                    counter++;
                    startIndex = index +1;
                }
                else
                {
                    break;
                }
            }
            
                

            Console.WriteLine(counter);
        }
    }
}
