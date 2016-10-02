using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.TripleSum
{
    /* 
     * Write a program to read an array of integers and find all triples of elements
     * a, b and c, such that a + b == c (a stays left from b).
     * You can check this code here:
     * https://judge.softuni.bg/Contests/Practice/Index/172#3
     */
    class TripleSum
    {
        static void Main()
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            bool isTriggered = false;
            for (int i = 0; i < input.Count; i++)
            {
                for (int j = i+1; j < input.Count; j++)
                {
                    int sum = input[i] + input[j];
                    if (input.Contains(sum))
                    {
                        isTriggered = true;
                        Console.WriteLine(input[i] + " + " + input[j] + " == " + sum);
                    }
                }
            }
            if (!isTriggered)
            {
                Console.WriteLine("No");
            }
        }
    }
}
