using System;
using System.Collections.Generic;

namespace _11.CommonStrings
{
    /* 
     * You are given two strings, A and B. Find if there is a substring that appears 
     * in both A and B.
     * Print the resulting string on the console.
     * https://judge.softuni.bg/Contests/209/Strings-Dictionaries-Lambda-and-LINQ-Exercises
     */
    class CommonStrings
    {
        static void Main()
        {
            HashSet<char> firstString = new HashSet<char>(
                Console.ReadLine().ToCharArray());
            HashSet<char> secondString = new HashSet<char>(
                Console.ReadLine().ToCharArray());

            firstString.IntersectWith(secondString);
            Console.WriteLine(firstString.Count > 1 ? "yes" : "no");
        }
    }
}
