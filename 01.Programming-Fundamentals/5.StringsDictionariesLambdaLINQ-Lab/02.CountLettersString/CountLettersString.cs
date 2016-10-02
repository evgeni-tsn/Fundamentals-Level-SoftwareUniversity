using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.CountLettersString
{
    /*
     * Read a string and count how many times each character occurs. 
     * Print all chars (case insensitive) alphabetically with their counts
     * You can check your solutions here: 
     * https://judge.softuni.bg/Contests/174/Strings-Dictionaries-Lambda-and-LINQ-Lab
     */
    class CountLettersString
    {
        static void Main()
        {
            var input = Console.ReadLine().ToLower().ToCharArray();
            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach (char ch in input)
            {
                if (!dict.ContainsKey(ch))
                {
                    dict.Add(ch, 1);
                }
                else
                {
                    dict[ch] += 1;
                }
            }
            
            foreach (var kvp in dict.OrderBy(e => e.Key))
            {
                Console.WriteLine(kvp.Key + " -> " + kvp.Value);
            }
        }
    }
}
