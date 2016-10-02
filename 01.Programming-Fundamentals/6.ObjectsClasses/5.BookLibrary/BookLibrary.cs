using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _5.BookLibrary
{
    /*To model a book library, define classes to hold a book and a library. 
     * The library must have a name and a list of books. 
     * The books must contain the title, author, publisher, release date, ISBN-number and price. 
     * Read a list of books, add them to the library and print the total sum of prices by author,
     * ordered descending by price and then by author’s name lexicographically.
    Books in the input will be in format {title} {author} {publisher} {release date} {ISBN} {price}.
    https://judge.softuni.bg/Contests/210/Objects-and-Classes-Exercises
    */
    class BookLibrary
    {
        class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string Publisher { get; set; }
            public DateTime ReleaseDate { get; set; }
            public string ISBN { get; set; }
            public decimal Price { get; set; }
        }

        public static void Main()
        {
            List<Book> books = GetBooks();
            Dictionary<string, decimal> salesByAuthor = new Dictionary<string, decimal>();

            foreach (string author in books.Select(x => x.Author).Distinct())
                salesByAuthor.Add(author, books.Where(x => x.Author == author)
                                               .Select(x => x.Price)
                                               .Sum());
            foreach (var pair in salesByAuthor
                                .OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                Console.WriteLine("{0} -> {1:f2}", pair.Key, pair.Value);
        }

        private static List<Book> GetBooks()
        {
            List<Book> books = new List<Book>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine()
                                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                books.Add(new Book
                {
                    Title = data[0],
                    Author = data[1],
                    Publisher = data[2],
                    ReleaseDate = DateTime.ParseExact(data[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    ISBN = data[4],
                    Price = decimal.Parse(data[5])
                });
            }
            return books;
        }
    }
}
