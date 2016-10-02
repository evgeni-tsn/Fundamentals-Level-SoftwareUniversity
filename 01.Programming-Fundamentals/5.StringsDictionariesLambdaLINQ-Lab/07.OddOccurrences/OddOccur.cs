using System;
using System.Collections.Generic;

namespace _07.OddOccurrences
{
    /*
     *Write a program that extracts from a given sequence of words all elements that present in it odd number of times (case-insensitive)
        •	Words are given in a single line, space separated
        •	Print the result elements in lowercase, in their order of appearance
     * You can check your solutions here: 
     * https://judge.softuni.bg/Contests/174/Strings-Dictionaries-Lambda-and-LINQ-Lab
     */
    class OddOccur
    {
        static void Main()
        {
            var words = Console.ReadLine().ToLower().Split(' ');
            var allWords = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!allWords.ContainsKey(word))
                {
                    allWords.Add(word, 1);
                }
                else
                {
                    allWords[word]++;
                }
            }
            var result = new List<string>();

            foreach (var pair in allWords)
            {
                if (pair.Value % 2 == 1)
                {
                    result.Add(pair.Key);
                }
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
