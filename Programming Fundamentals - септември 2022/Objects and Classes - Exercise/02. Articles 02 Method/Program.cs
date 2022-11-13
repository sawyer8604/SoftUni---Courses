using System;
using System.Collections.Generic;


namespace _02.Articles_02_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            int numberOfLines = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            string title = input[0];
            string contents = input[1];
            string author = input[2];

            Article article = new Article(title, contents, author);
            articles.Add(article);

            for (int i = 0; i < numberOfLines; i++)
            {
                string[] commands = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries);

                string firstCommand = commands[0];

                GetChanges(article, commands, firstCommand);

            }
            Console.WriteLine(article.ToString());

        }

        private static void GetChanges(Article article, string[] commands, string firstCommand)
        {
            switch (firstCommand)
            {
                case "Edit":
                    string newContent = commands[1];
                    article.Content = newContent;

                    break;

                case "ChangeAuthor":
                    string changeAuthor = commands[1];
                    article.Author = changeAuthor;

                    break;

                case "Rename":
                    string Rename = commands[1];
                    article.Title = Rename;

                    break;


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
