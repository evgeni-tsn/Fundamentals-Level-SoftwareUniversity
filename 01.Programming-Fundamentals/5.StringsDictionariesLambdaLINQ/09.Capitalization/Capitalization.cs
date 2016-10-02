using System;
using System.Text;

namespace _09.Capitalization
{
    /* 
     * Write a program which takes input string and capitalizes the first character
     * of each word in a String, and does not affect the others.
     * Print the resulting string on the console.
     * https://judge.softuni.bg/Contests/209/Strings-Dictionaries-Lambda-and-LINQ-Exercises
     */
    class Capitalization
    {
        static void Main()
        {
            string input = Console.ReadLine();
            bool toCapitalize = true;
            StringBuilder stringBuilder = new StringBuilder();
            foreach (char ch in input)
            {
                if (char.IsLetter(ch) && toCapitalize)
                {
                    stringBuilder.Append(ch.ToString().ToUpper());
                    toCapitalize = false;
                }
                else
                {
                    stringBuilder.Append(ch);
                }

                if (!char.IsLetter(ch))
                {
                    toCapitalize = true;
                }
            }

            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
