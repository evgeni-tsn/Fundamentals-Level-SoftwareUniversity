using System;
using System.Collections.Generic;
using System.Linq;

class LongestAreaArray
{
    //Write a program to find the longest area of equal elements in array of strings.You first should read an integer n and n strings(each at a separate line), then find and print the longest sequence of equal elements(first its length, then its elements). If multiple sequences have the same maximal length, print the leftmost of them.
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        List<string> strings = new List<string>();
        for (int i = 0; i < n; i++)
        {
            strings.Add(Console.ReadLine());
        }
        var result = strings.GroupBy(x => x).Select(x => new
        {
            Name = x.Key,
            Total = x.Count()
        });
        int biggestCount = 0;
        string longestArea = "";
        foreach (var s in result)
        {
            if (s.Total > biggestCount)
            {
                biggestCount = s.Total;
                longestArea = s.Name;
            }
        }
        Console.WriteLine(biggestCount);
        for (int i = 0; i < biggestCount; i++)
        {
            Console.WriteLine(longestArea);
        }
    }
}
