using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.SquareNumbers
{
    /* 
     * Read a list of integers and extract square numbers from it and print them in descending order.
     * A square number is an integer which is the square of any integer. 
     * For example, 1, 4, 9, 16 are square numbers.
     * You can check this code here:
     * https://judge.softuni.bg/Contests/Practice/Index/173#6
     */
    class SquareNumbers
    {
        static void Main()
        {
            var input = Console.ReadLine().Trim().Split().Select(int.Parse).ToList();
            var result = new List<int>();

            foreach (var num in input)
            {
                if (Math.Sqrt(num) == Math.Floor(Math.Sqrt(num)))
                {
                    result.Add(num);
                }
            }
            result.Sort();
            result.Reverse();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
