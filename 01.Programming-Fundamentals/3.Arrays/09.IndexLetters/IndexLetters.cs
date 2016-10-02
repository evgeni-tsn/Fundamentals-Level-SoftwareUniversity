using System;
using System.Collections.Generic;

namespace _09.IndexLetters
{
    /* 
    * Write a program that creates an array containing all letters from the alphabet (A-Z). 
    * Read a word from the console and print the index of each of its letters in the array.
    * You can check this code here:
    * https://judge.softuni.bg/Contests/Practice/Index/207#8
    */
    class IndexLetters
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Dictionary<string, int> alphabet = new Dictionary<string, int>()
            {
                {"a", 0 },
                {"b", 1 },
                {"c", 2 },
                {"d", 3 },
                {"e", 4 },
                {"f", 5 },
                {"g", 6 },
                {"h", 7 },
                {"i", 8 },
                {"j", 9 },
                {"k", 10 },
                {"l", 11 },
                {"m", 12 },
                {"n", 13 },
                {"o", 14 },
                {"p", 15 },
                {"q", 16 },
                {"r", 17 },
                {"s", 18 },
                {"t", 19 },
                {"u", 20 },
                {"v", 21 },
                {"w", 22 },
                {"x", 23 },
                {"y", 24 },
                {"z", 25 }
            };

            foreach (var letter in input)
            {
                if (alphabet.ContainsKey(letter.ToString()))
                {
                    Console.WriteLine(letter.ToString().ToLower() + " -> " + alphabet[letter.ToString().ToLower()]);
                }
            }
        }
    }
}
