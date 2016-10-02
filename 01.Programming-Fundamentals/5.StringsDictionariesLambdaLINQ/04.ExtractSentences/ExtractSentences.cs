using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.ExtractSentences
{
    /* 
     * Write a program that extracts from a text all sentences that contain a particular word. 
     * We accept that the sentences are separated from each other by the character "." 
     * and the words are separated from one another by a character which is not a letter.
     * Print the resulting string on the console.
     * https://judge.softuni.bg/Contests/209/Strings-Dictionaries-Lambda-and-LINQ-Exercises
     */
    class ExtractSentences
    {
        static void Main()
        {
            string word = Console.ReadLine();
            string[] sentences = Console.ReadLine().Split('.').ToArray();

            foreach (var sentence in sentences)
            {
                string[] wordsInSentence = sentence.Split(new[] { ' ', ',' },StringSplitOptions.RemoveEmptyEntries);
                foreach (var words in wordsInSentence)
                {
                    if (words == word)
                    {
                        Console.WriteLine(sentence.Trim());
                    }
                }
            }
        }
    }
}
