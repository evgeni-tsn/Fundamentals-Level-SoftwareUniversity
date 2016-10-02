using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.SumAdjacentEqualNumbers
{
    /* 
     * Write a program to sum all adjacent equal numbers 
     * in a list of decimal numbers, starting from left to right.
        After two numbers are summed, the obtained result could be equal
        to some of its neighbors and should be summed as well
        Order the lists from last to first, and their values from left to right
     * You can check this code here:
     * https://judge.softuni.bg/Contests/Practice/Index/173#2
     */
    class SumAdjacentEqualNums
    {
        static void Main()
        {
            List<double> input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            List<double> result = new List<double>();

            bool areDifferent = false;
            while (!areDifferent)
            {
                areDifferent = true;
                for (int i = 0; i < input.Count; i++)
                {
                    if (i < input.Count - 1 && input[i] == input[i + 1])
                    {
                        result.Add(input[i] * 2);
                        i++;
                        areDifferent = false;
                    }
                    else
                    {
                        result.Add(input[i]);
                    }
                }
                input = result;
                result = new List<double>();
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
