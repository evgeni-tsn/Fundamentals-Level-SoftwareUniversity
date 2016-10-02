using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _6.BookLibraryModification
{
    /*Use the classes from the previous problem and make a program that read a list of books
     * and print all titles released after given date ordered by date and then 
     * by title lexicographically. 
     * The date is given if format “day-month-year” at the last line in the input.
    Books in the input will be in format {title} {author} {publisher} {release date} {ISBN} {price}.
    https://judge.softuni.bg/Contests/210/Objects-and-Classes-Exercises
    */
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
    }
    class BookLibraryMod
    {
        public static void Main()
        {
            List<Book> books = GetBooks();
            DateTime targetReleaseDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            DateTime[] resultReleaseDates = books
                                            .Where(x => x.ReleaseDate > targetReleaseDate)
                                            .Select(x => x.ReleaseDate).Distinct()
                                            .OrderBy(x => x)
                                            .ToArray();
            foreach (DateTime releaseDate in resultReleaseDates)
            {
                string[] releaseDateTitles = books
                                            .Where(x => x.ReleaseDate == releaseDate)
                                            .Select(x => x.Title).Distinct()
                                            .OrderBy(x => x)
                                            .ToArray();
                foreach (string title in releaseDateTitles)
                    Console.WriteLine("{0} -> {1:dd.MM.yyyy}", title, releaseDate);
            }
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
