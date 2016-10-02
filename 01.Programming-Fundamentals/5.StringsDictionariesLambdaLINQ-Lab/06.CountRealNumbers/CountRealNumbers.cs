using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.CountRealNumbers
{
    /*
     * Read a list of real numbers and print them in ascending order along with their number of occurrences
     * You can check your solutions here: 
     * https://judge.softuni.bg/Contests/174/Strings-Dictionaries-Lambda-and-LINQ-Lab
     */
    class CountRealNumbers
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().Select(decimal.Parse).ToList();
            Dictionary<decimal, int> dict = new Dictionary<decimal, int>();

            foreach (var num in input)
            {
                if (!dict.ContainsKey(num))
                {
                    dict.Add(num, 1);
                }
                else
                {
                    dict[num] += 1;
                }
            }

            foreach (var kvp in dict.OrderBy(e => e.Key))
            {
                Console.WriteLine(kvp.Key + " -> " + kvp.Value);
            }
        }
    }
}
