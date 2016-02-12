using System;
using System.Text.RegularExpressions;

class CountingWordInText
{
    //Write a program that counts how many times a given word occurs in given text. The first line in the input holds the word. The second line of the input holds the text. The output should be a single integer number – the number of word occurrences. Matching should be case-insensitive. Note that not all matching substrings are words and should be counted. A word is a sequence of letters separated by punctuation or start / end of text.
    static void Main()
    {
        string word = Console.ReadLine();
        string text = Console.ReadLine();
        string[] separated = Regex.Split(text, @"[^\w\n]");
        int count = 0;

        for (int i = 0; i < separated.Length; i++)
        {
            if (separated[i].Equals(word, StringComparison.CurrentCultureIgnoreCase))
            {
                count++;
            }
        }
        Console.WriteLine();
        Console.WriteLine(count);
        Console.WriteLine();
    }
}
