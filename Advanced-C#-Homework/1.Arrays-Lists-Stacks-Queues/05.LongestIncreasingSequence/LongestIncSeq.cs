using System;
using System.Collections.Generic;
using System.Linq;

class LongestIncSeq
{
    //Write a program to find all increasing sequences inside an array of integers. 
    //The integers are given on a single line, separated by a space. 
    //Print the sequences in the order of their appearance in the input array, each at a single line. 
    //Separate the sequence elements by a space. Find also the longest increasing sequence and print it
    //at the last line. If several sequences have the same longest length, print the left-most of them. 
    static void Main()
    {
        int[] nums = Array.ConvertAll(Console.ReadLine().Split(), s => int.Parse(s));

        Dictionary<int, List<int>> sorted = new Dictionary<int, List<int>>();

        sorted[0] = new List<int>();
        sorted[0].Add(nums[0]);

        for (int i = 1, index = 0; i < nums.Length; i++)
        {
            if (nums[i] < nums[i - 1] || nums[i] == nums[i - 1])
            {
                index++;
            }
            if (!sorted.Keys.Contains(index))
            {
                sorted[index] = new List<int>();
            }
            sorted[index].Add(nums[i]);
        }
        foreach (var key in sorted.Keys)
        {
            Console.WriteLine(string.Join(" ",sorted[key]));
        }
        Console.WriteLine("Longest: {0}", string.Join(" ", sorted.OrderByDescending(a=>a.Value.Count).First().Value));
    }
}