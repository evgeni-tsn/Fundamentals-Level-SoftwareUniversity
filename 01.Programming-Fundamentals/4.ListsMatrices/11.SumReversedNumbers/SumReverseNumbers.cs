using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.SumReversedNumbers
{
    /*
     * Write a program that reads sequence of numbers reverses them and print their sum.
     * You can check your solutions here: 
     * https://judge.softuni.bg/Contests/208/Lists-and-Matrices-Exercises
     */
    class SumReverseNumbers
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> reversed = new List<int>();

            foreach (var number in numbers)
            {
                var temp = number.ToString().ToCharArray();
                Array.Reverse(temp);
                reversed.Add(int.Parse(new string(temp)));
            }

            Console.WriteLine(reversed.Sum());
        }
    }
}
