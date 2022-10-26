using System;

namespace _01._Advertisement_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberfOfMessage = int.Parse(Console.ReadLine());


            string[] phrase = {"Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product." };

            string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };

            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random random = new Random();

            

            for (int i = 0; i < numberfOfMessage; i++)
            {
                int phraseIndex = random.Next(phrase.Length);
                int eventsIndex = random.Next(events.Length);
                int authorsIndex = random.Next(authors.Length);
                int citiesIndex = random.Next(cities.Length);

                Console.WriteLine($"{phrase[phraseIndex]} {events[eventsIndex]} {authors[authorsIndex]} – {cities[citiesIndex]}.");
            }
            

        }
    }
}
