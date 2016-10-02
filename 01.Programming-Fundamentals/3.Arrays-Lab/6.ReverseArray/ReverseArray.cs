using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.ReverseArray
{
    /* 
     * Write a program to read an array of string (space separated values),
     * reverse it and print its elements.
     * You can check this code here:
     * https://judge.softuni.bg/Contests/Practice/Index/172#5
     */
    class ReverseArray
    {
        static void Main()
        {
            List<string> input = Console.ReadLine().Split().ToList();
            
            input.Reverse();
            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
        }
    }
}
