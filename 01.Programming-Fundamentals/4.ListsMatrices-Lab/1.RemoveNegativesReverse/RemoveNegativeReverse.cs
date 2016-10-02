using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.RemoveNegativesReverse
{
    /* 
     * Read a list of integers, remove all negative numbers from it 
     * and print the list in reversed order.
     * You can check this code here:
     * https://judge.softuni.bg/Contests/Practice/Index/173#0
     */
    class RemoveNegativeReverse
    {
        static void Main()
        {
            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Where(e => e >= 0)
                .ToList();

            input.Reverse();
            Console.WriteLine(input.Count > 0 ? string.Join(" ", input) : "empty");
        }
    }
}
