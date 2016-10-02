using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.MaxSequenceEqualElements
{
    /*
     * Read a list of integers and find the longest sequence of equal elements. 
     * If several exist, print the leftmost.
     * You can check your solutions here: 
     * https://judge.softuni.bg/Contests/208/Lists-and-Matrices-Exercises
     */
    class MaxSequenceEqualElements
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int output = 0;
            int count = 1;
            int maxcount = 1;
            int pos = 0;
            while (pos < numbers.Count - 1)
            {
                if (numbers[pos] == numbers[pos + 1])
                {
                    count++;
                    if (count > maxcount)
                    {
                        maxcount = count;
                        output = numbers[pos];
                    }
                }
                else
                {
                    count = 1;
                }
                pos++;
                if (maxcount == 1)
                {
                    output = numbers[0];
                }
            }

            for (int i = 0; i < maxcount; i++)
            {
                Console.Write(output + " ");
            }
        }
    }
}
