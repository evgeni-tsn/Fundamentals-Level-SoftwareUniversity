using System;

namespace _10.PalindromeIndex
{
    /* 
     * Given a string of lowercase letters, determine the index of the character 
     * whose removal will make the string a palindrome. 
     * If the string is already a palindrome, then print −1. 
     * There will always be a valid solution.
     * Print the resulting string on the console.
     * https://judge.softuni.bg/Contests/209/Strings-Dictionaries-Lambda-and-LINQ-Exercises
     */
    class PalindromeIndex
    {
        static void Main()
        {
            string input = Console.ReadLine();

            if (IsPalindrome(input))
            {
                Console.WriteLine(-1);
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (IsPalindrome(input.Remove(i, 1)))
                    {
                        Console.WriteLine(i);
                        break;
                    }
                }
            }
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
