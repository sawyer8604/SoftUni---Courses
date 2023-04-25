namespace BookShop
{
    using Models.Enums;
    using Data;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using Z.EntityFramework.Plus;    

    public class StartUp
    {
        public static void Main()
        {
            using var db = new BookShopContext();
            //DbInitializer.ResetDatabase(db);

            // problem 02 
            // Console.WriteLine(GetBooksByAgeRestriction(db, "miNor"));

            // problem 03
            // Console.WriteLine(GetGoldenBooks(db)); 

            // problem 04
            //Console.WriteLine(GetBooksByPrice(db));

            // problem 05
            // Console.WriteLine(GetBooksNotReleasedIn(db, 2000));

            // problem 06
            // Console.WriteLine(GetBooksByCategory(db, "horror mystery drama"));

            //problem 07
            //Console.WriteLine(GetBooksReleasedBefore(db, "12-04-1992"));

            //problem 08
            // Console.WriteLine(GetAuthorNamesEndingIn(db, "e"));

            // problem 09
            // Console.WriteLine(GetBookTitlesContaining(db, "sK"));

            //problem 10

            //Console.WriteLine(GetBooksByAuthor(db, "R"));

            // problem 11.
            //int lengthCheck =int.Parse(Console.ReadLine());
            //Console.WriteLine(CountBooks(db, lengthCheck));

            // problem 12.
            //Console.WriteLine(CountCopiesByAuthor(db));

            // problem 13.
            //Console.WriteLine(GetTotalProfitByCategory(db));

            // problem 14.
            //Console.WriteLine(GetMostRecentBooks(db));

            // problem 15.
            //IncreasePrices(db);

            // problem 16.
            Console.WriteLine(RemoveBooks(db));




        }

        //problem 02 Age Restriction
        public static string GetBooksByAgeRestriction(BookShopContext context, string command)
        {

            AgeRestriction ageRestriction;

            bool hasParsed = Enum.TryParse<AgeRestriction>(command, true, out ageRestriction);
            if (!hasParsed)
            {
                return string.Empty;
            }

            string[] bookTitle = context
                .Books
                .Where(a => a.AgeRestriction == ageRestriction)
                .Select(a => a.Title)
                .OrderBy(t => t)
                .ToArray();

            return string.Join(Environment.NewLine, bookTitle);
        }

        // 03. Golden Books

        public static string GetGoldenBooks(BookShopContext context)
        {
            string[] bookTitles = context
                .Books
                .Where(b => b.EditionType == EditionType.Gold && b.Copies < 5000)
                .OrderBy(b => b.BookId)
                .Select(t => t.Title)
                .ToArray();

            return string.Join(Environment.NewLine, bookTitles);
        }


        //04. Books by Price

        public static string GetBooksByPrice(BookShopContext context)
        {
            StringBuilder output = new StringBuilder();

            var bookTitles = context
                .Books
                .Where(b => b.Price > 40)
                .OrderByDescending(b => b.Price)
                .AsNoTracking()
                .ToArray();

            foreach (var book in bookTitles)
            {
                output.AppendLine($"{book.Title} - ${book.Price:f2}");
            }

            return output.ToString().TrimEnd();
        }

        //05. Not Released In

        public static string GetBooksNotReleasedIn(BookShopContext context, int year)
        {
            StringBuilder output = new StringBuilder();

            var bookTitles =
                context
                .Books
                .Where(b => b.ReleaseDate.Value.Year != year)
                .OrderBy(b => b.BookId)
                .ToArray();

            foreach (var book in bookTitles)
            {
                output.AppendLine(book.Title);
            }

            return output.ToString().TrimEnd();
        }

        // 06. Book Titles by Category

        public static string GetBooksByCategory(BookShopContext context, string input)
        {
            StringBuilder output = new StringBuilder();

            var categoryId = context
                .Categories
                .Where(b => input.ToLower().Split(" ", StringSplitOptions.RemoveEmptyEntries).Contains(b.Name.ToLower()))
                .AsNoTracking()
                .Select(c => c.CategoryId)
                .ToArray();

            var bookTitles = context
                .BooksCategories
                .Where(b => categoryId.Contains(b.CategoryId))
                .Select(b => b.Book)
                .OrderBy(b => b.Title)
                .AsNoTracking()
                .ToArray();


            foreach (var book in bookTitles)
            {
                output.AppendLine(book.Title);
            }

            return output.ToString().TrimEnd();
        }

        //07. Released Before Date

        public static string GetBooksReleasedBefore(BookShopContext context, string date)
        {
            StringBuilder output = new StringBuilder();

            DateTime dateConverted = DateTime.ParseExact(date, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            var books = context.Books
                .Where(b => b.ReleaseDate.Value < dateConverted)
                .AsNoTracking()
                .OrderByDescending(b => b.ReleaseDate.Value)
                .Select(b => new
                {
                    Title = b.Title,
                    Edition = b.EditionType.ToString(),
                    Price = b.Price
                })
                .ToArray();

            foreach (var book in books)
            {
                output.AppendLine($"{book.Title} - {book.Edition} - ${book.Price:f2}");
            }

            return output.ToString().TrimEnd();
        }

        // 08. Author Search

        public static string GetAuthorNamesEndingIn(BookShopContext context, string input)
        {
            StringBuilder output = new StringBuilder();

            var authorsFullName = context
                .Authors
                .Where(b => b.FirstName.EndsWith(input))
                .OrderBy(b => b.FirstName)
                .ThenBy(b => b.LastName)
                .ToArray();

            foreach (var author in authorsFullName)
            {
                output.AppendLine($"{author.FirstName} {author.LastName}");
            }

            return output.ToString().TrimEnd();
        }

        //09. Book Search

        public static string GetBookTitlesContaining(BookShopContext context, string input)
        {
            StringBuilder output = new StringBuilder();

            var bookTitles = context
                .Books
                .Where(b => b.Title.ToLower().Contains(input.ToLower()))
                .AsNoTracking()
                .OrderBy(b => b.Title)
                .ToArray();

            foreach (var book in bookTitles)
            {
                output.AppendLine(book.Title);
            }

            return output.ToString().TrimEnd();
        }

        // 10. Book Search by Author

        public static string GetBooksByAuthor(BookShopContext context, string input)
        {
            StringBuilder stringBuilder = new StringBuilder();

            var books = context.Books
                .Where(b => b.Author.LastName.ToLower().StartsWith(input.ToLower()))
                .OrderBy(b => b.BookId)
                .Select(b => new
                {
                    Title = b.Title,
                    FullName = b.Author.FirstName + " " + b.Author.LastName
                })
                .AsNoTracking()
                .ToArray();

            foreach (var book in books)
            {
                stringBuilder.AppendLine($"{book.Title} ({book.FullName})");
            }

            return stringBuilder.ToString().TrimEnd();
        }

        // 11. Count Books
        public static int CountBooks(BookShopContext context, int lengthCheck)
        {
            var books = context.Books
                .Where(b => b.Title.Length > lengthCheck)
                .AsNoTracking()
                .ToArray();

            return books.Count();
        }

        // 12. Total Book Copies
        public static string CountCopiesByAuthor(BookShopContext context)
        {
            StringBuilder stringBuilder = new StringBuilder();

            var authorBooks = context.Authors
                .Select(a => new
                {
                    FullName = a.FirstName + " " + a.LastName,
                    Copies = a.Books.Sum(x => x.Copies)
                })
                .OrderByDescending(b => b.Copies)
                .AsNoTracking()
                .ToArray();

            foreach (var authorBook in authorBooks)
            {
                stringBuilder.AppendLine($"{authorBook.FullName} - {authorBook.Copies}");
            }

            return stringBuilder.ToString().TrimEnd();
        }

        // 13. Profit by Category
        public static string GetTotalProfitByCategory(BookShopContext context)
        {
            StringBuilder stringBuilder = new StringBuilder();

            var profitBooks = context.Categories
                .Select(c => new
                {
                    CategoryTitle = c.Name,
                    TotalProfit = c.CategoryBooks.Sum(b => b.Book.Price * b.Book.Copies)
                })
                .OrderByDescending(c => c.TotalProfit)
                .ThenBy(c => c.CategoryTitle)
                .AsNoTracking()
                .ToArray();

            foreach (var profitBook in profitBooks)
            {
                stringBuilder.AppendLine($"{profitBook.CategoryTitle} ${profitBook.TotalProfit:f2}");
            }

            return stringBuilder.ToString().TrimEnd();
        }

        // 14. Most Recent Books
        public static string GetMostRecentBooks(BookShopContext context)
        {
            StringBuilder stringBuilder = new StringBuilder();

            var recentBooks = context.Categories
                .OrderBy(c => c.Name)
                .Select(c => new
                {
                    Category = c.Name,
                    Books = c.CategoryBooks
                        .OrderByDescending(b => b.Book.ReleaseDate)
                        .Select(b => new
                        {
                            Title = b.Book.Title,
                            Year = b.Book.ReleaseDate.Value.Year
                        })
                        .Take(3)
                        .ToArray()
                })
                .AsNoTracking()
                .ToArray();

            foreach (var recentBook in recentBooks)
            {
                stringBuilder.AppendLine($"--{recentBook.Category}");

                foreach (var book in recentBook.Books)
                {
                    stringBuilder.AppendLine($"{book.Title} ({book.Year})");
                }
            }

            return stringBuilder.ToString().TrimEnd();
        }

        // problem 15
        // BULK Update
        //public static void IncreasePrices(BookShopContext context)
        //{
        //    context.
        //        Books
        //        .Where(b => b.ReleaseDate.Value.Year < 2010)
        //        .Update(b => new Book()
        //        {
        //            Price = b.Price + 5
        //        });
        //}

        // Second way
        public static void IncreasePrices(BookShopContext context)
        {
            var books = context.Books
                .Where(b => b.ReleaseDate.Value.Year < 2010)
                .ToArray();

            foreach (var book in books)
            {
                book.Price += 5;
            }

            context.SaveChanges();
        }

        // problem 16

        public static int RemoveBooks(BookShopContext context)
        {
           var books =  context
                .Books
                .Where(b => b.Copies < 4200)                
                .ToArray();

            context.RemoveRange(books);
            context.SaveChanges();

            return books.Length;
        }
    }
}
