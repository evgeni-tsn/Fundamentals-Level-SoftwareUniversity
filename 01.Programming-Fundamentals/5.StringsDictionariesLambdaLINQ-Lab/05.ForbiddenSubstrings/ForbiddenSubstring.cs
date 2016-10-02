using System;

namespace _05.ForbiddenSubstrings
{
    /*
     * Read a text and several forbidden words. Replace all forbidden words with stars
     * (e.g. beer -> ****). 
     * Use "substring" matching (match part of word), case-sensitive:
     * You can check your solutions here: 
     * https://judge.softuni.bg/Contests/174/Strings-Dictionaries-Lambda-and-LINQ-Lab
     */
    class ForbiddenSubstring
    {
        static void Main()
        {
            string inputText = Console.ReadLine();
            string[] bannedWords = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < bannedWords.Length; i++)
            {
                while (inputText.Contains(bannedWords[i]))
                {
                    inputText = inputText.Replace(bannedWords[i], new string('*', bannedWords[i].Length));
                }
            }
            Console.WriteLine(inputText);
        }
    }
}
