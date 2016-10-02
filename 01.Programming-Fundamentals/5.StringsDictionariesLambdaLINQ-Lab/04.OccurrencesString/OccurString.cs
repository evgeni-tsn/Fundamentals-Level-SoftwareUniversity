using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.OccurrencesString
{
    /*
     * Read a text and a word and count how many times the word occurs in the text as substring.
     * You can check your solutions here: 
     * https://judge.softuni.bg/Contests/174/Strings-Dictionaries-Lambda-and-LINQ-Lab
     */
    class OccurString
    {
        static void Main()
        {
            var text = Console.ReadLine().ToLower();
            var lookFor = Console.ReadLine();

            int offset = text.IndexOf(lookFor);
            bool flag = false;

            int center = 0;

            while (offset != -1)
            {
                flag = true;
                offset = text.IndexOf(lookFor, offset + 1);

                if (offset != -1)
                {
                    center++;
                }
            }
            if (flag)
            {
                center++;
            }
            Console.WriteLine(center);
        }
    }
}
