using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Articles_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int numberOfLines = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();


            for (int i = 0; i < numberOfLines; i++)
            {
                string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string title = input[0];
                string contents = input[1];
                string author = input[2];

                Article article = new Article(title, contents, author);
                articles.Add(article);
            }

            string printCommands = Console.ReadLine();

            PrinTheArticles(articles, printCommands);

        }

        private static void PrinTheArticles(List<Article> articles, string printCommands)
        {
            if (printCommands == "title")
            {
                foreach (Article asrticle in articles.OrderBy(a => a.Title))
                {
                    Console.WriteLine(asrticle.ToString());
                }
            }
            else if (printCommands == "content")
            {
                foreach (Article asrticle in articles.OrderBy(a => a.Content))
                {
                    Console.WriteLine(asrticle.ToString());
                }
            }
            else if (printCommands == "author")
            {
                foreach (Article asrticle in articles.OrderBy(a => a.Author))
                {
                    Console.WriteLine(asrticle.ToString());
                }
            }
        }
    }

    public class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
}
