using System;
using System.Collections.Generic;

namespace _05._HTML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string titleOfArticle = Console.ReadLine();
            string contentOfArticle = Console.ReadLine();

            List<string> comments = new List<string>();

            string input;

            while ((input = Console.ReadLine()) != "end of comments")
            {
                comments.Add(input);
            }
            Console.WriteLine("<h1>");
            Console.WriteLine($"    {titleOfArticle}");
            Console.WriteLine("</h1>");
            Console.WriteLine("<article>");
            Console.WriteLine($"    {contentOfArticle}");
            Console.WriteLine("</article>");

            foreach (var comment in comments)
            {
                Console.WriteLine("<div>");
                Console.WriteLine($"    {comment}");
                Console.WriteLine("</div>");
            }

        }
    }
}
