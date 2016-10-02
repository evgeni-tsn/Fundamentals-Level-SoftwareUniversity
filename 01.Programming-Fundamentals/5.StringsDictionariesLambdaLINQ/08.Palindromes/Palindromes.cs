using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _08.Palindromes
{
    /* 
     * Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal,
     * exe and prints them on the console on a single line, separated by comma and space.
     * Use spaces, commas, dots, question marks and exclamation marks as word delimiters.
     * Print only unique palindromes, sorted lexicographically.
     * Print the resulting string on the console.
     * https://judge.softuni.bg/Contests/209/Strings-Dictionaries-Lambda-and-LINQ-Exercises
     */
    class Palindromes
    {
        static void Main()
        {
            var input = Console.ReadLine();
            Regex reg = new Regex("[A-z]+");
            MatchCollection matches = reg.Matches(input);

            SortedSet<string> set = new SortedSet<string>();
            foreach (Match match in matches)
            {
                if (IsPalindrome(match.ToString()))
                {
                    set.Add(match.ToString());
                }
            }

            Console.WriteLine(string.Join(", ", set));
        }

        private static bool IsPalindrome(string word)
        {
            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
