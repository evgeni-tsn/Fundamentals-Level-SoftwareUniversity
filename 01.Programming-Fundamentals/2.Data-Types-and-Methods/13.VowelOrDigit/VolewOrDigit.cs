using System;
using System.Collections.Generic;

namespace _13.VowelOrDigit
{
    /* 
    * Create a program to check if given symbol is letter, vowel or any other symbol.
    * You can check this code here:
    * https://judge.softuni.bg/Contests/Practice/Index/206#12
    */
    class VolewOrDigit
    {
        static void Main()
        {
            List<char> vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u', 'y' };
            List<char> digits = new List<char>() { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            char input = char.Parse(Console.ReadLine());

            if (digits.Contains(input))
            {
                Console.WriteLine("digit");
            }
            else if (vowels.Contains(input))
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("It's another symbol");
            }
        }
    }
}
