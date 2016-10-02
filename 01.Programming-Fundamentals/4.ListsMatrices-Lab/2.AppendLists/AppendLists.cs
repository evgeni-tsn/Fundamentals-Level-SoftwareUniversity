using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.AppendLists
{
    /* 
     * Write a program to append several lists of numbers.
        Lists are separated by ‘|’
        Values are separated by space (‘ ’, one or more)
        Order the lists from last to first, and their values from left to right
     * You can check this code here:
     * https://judge.softuni.bg/Contests/Practice/Index/173#1
     */
    class AppendLists
    {
        static void Main()
        {
            List<string> input = Console.ReadLine()
                .Split(new []{'|'}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<string> result = new List<string>();
            foreach (var item in input)
            {
                result.Add(
                    string.Join(
                        " ", item.Split(
                            new[] { " " }, StringSplitOptions.RemoveEmptyEntries)));
            }
            result.Reverse();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
