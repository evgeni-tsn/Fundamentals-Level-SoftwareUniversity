using System;
using System.Linq;

namespace _06.ReverseWordsSentence
{
    /* 
     * Write a program that reverses the words in a given sentence without changing punctuation and spaces.
     * Print the resulting string on the console.
     * https://judge.softuni.bg/Contests/209/Strings-Dictionaries-Lambda-and-LINQ-Exercises
     */
    class ReverseWordsSentence
    {
        static void Main()
        {
            string sentence = Console.ReadLine();
            char[] wordSeparators = " .,:;=()&[]\"'\\/!?".ToCharArray();
            string[] words = sentence
                .Split(wordSeparators, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(words);

            char[] punctuationSeparators = string.Join("", words)
                .ToCharArray()
                .Distinct().ToArray();
            string[] punctuation = sentence
                .Split(punctuationSeparators, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
                Console.Write(string.Join("", words[i], punctuation[i]));
        }
    }
}
