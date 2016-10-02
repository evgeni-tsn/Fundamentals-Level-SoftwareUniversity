using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _07.ToUppercase
{
    /* 
     * A text is given. Write a program that modifies the casing of letters to 
     * uppercase at all places in the text surrounded by <upcase> and </upcase> tags. 
     * Tags cannot be nested.
     * Print the resulting string on the console.
     * https://judge.softuni.bg/Contests/209/Strings-Dictionaries-Lambda-and-LINQ-Exercises
     */
    class ToUpper
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"<upcase>(.+?)<\/upcase>";

            MatchCollection matches = Regex.Matches(input, pattern);
            foreach (Match match in matches)
            {
                input = input.Replace(
                    match.Groups[0].ToString(),
                    match.Groups[1].ToString().ToUpper());
            }
            Console.WriteLine(input);
        }
    }
}
