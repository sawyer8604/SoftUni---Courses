using System;
class _01_Old_Books
{
    static void Main()
    {

        string favoriteBook = Console.ReadLine();

        string book = string.Empty;

        int checkedBook = 0;

        while (book != favoriteBook)
        {

            book = Console.ReadLine();


            if (book == "No More Books")
            {

                Console.WriteLine($"The book you search is not here!\r\nYou checked {checkedBook} books.");
                break;
            }

            if (book == favoriteBook)
            {

                Console.WriteLine($"You checked {checkedBook} books and found it.");
            }
            checkedBook++;

        }

    }
}