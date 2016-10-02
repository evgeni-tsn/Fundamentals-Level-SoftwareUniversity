using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.CountNumbers
{
    /* 
     * Read a list of integers in range [0…1000] and print them in 
     * ascending order along with their number of occurrences.
     * You can check this code here:
     * https://judge.softuni.bg/Contests/Practice/Index/173#5
     */
    class CountNums
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            Dictionary<int, int> result = new Dictionary<int, int>();
            foreach (var num in input)
            {
                if (!result.ContainsKey(num))
                {
                    result.Add(num, 1);
                }
                else
                {
                    result[num]++;
                }
            }
            foreach (var kvp in result.OrderBy(e => e.Key))
            {
                Console.WriteLine(kvp.Key + " -> " + kvp.Value);
            }
        }
    }
}
