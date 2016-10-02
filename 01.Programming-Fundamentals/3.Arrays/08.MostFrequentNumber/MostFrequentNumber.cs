using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.MostFrequentNumber
{
    /* 
    * Write a program that find the most frequent number in a given sequence of numbers. 
    * You can check this code here:
    * https://judge.softuni.bg/Contests/Practice/Index/207#7
    */
    class MostFrequentNumber
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            var dict = new Dictionary<int, int>();

            foreach (var item in input)
            {
                if (!dict.ContainsKey(item))
                {
                    dict.Add(item, 1);
                }
                else
                {
                    dict[item]++;
                }
            }

            int maxKey = 0;
            int maxValue = 0;
            foreach (var kvp in dict)
            {
                if (kvp.Value>maxValue)
                {
                    maxValue = kvp.Value;
                    maxKey = kvp.Key;
                }
            }
            Console.WriteLine(maxKey);
        }
    }
}
