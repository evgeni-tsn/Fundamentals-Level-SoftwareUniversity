using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.RoundingNumbers
{
    /* 
     * Write a program to read an array of real numbers (space separated values),
     * round them in “away from 0” style and print the output as in the examples:
     * You can check this code here:
     * https://judge.softuni.bg/Contests/Practice/Index/172#4
     */
    class RoundingNumbers
    {
        static void Main()
        {
            List<double> input = Console.ReadLine().Split().Select(double.Parse).ToList();

            foreach (var item in input)
            {
                Console.WriteLine($"{item} => {Math.Round(item, MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
