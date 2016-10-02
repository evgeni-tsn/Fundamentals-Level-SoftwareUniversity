using System;
using System.Linq;

namespace _09.ShortWordsSorted
{
    /*
     * Read a text, extract its words, find all short words (less than 5 characters) and print them alphabetically, in lower case
        •	Use the following separators: . , : ; ( ) [ ] " ' ! ? (space)
        •	Use case-insensitive matching; remove duplicated words
     * You can check your solutions here: 
     * https://judge.softuni.bg/Contests/174/Strings-Dictionaries-Lambda-and-LINQ-Lab
     */
    class ShortWordsSorted
    {
        static void Main()
        {
            var result = Console.ReadLine().
            Split(".,:;()[]\"'!? ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .Where(word => word.Length < 5)
            .OrderBy(word => word)
            .Select(word => word.ToLower())
            .Distinct()
            .ToList();

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
