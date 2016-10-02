using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.SumArrays
{
    /* 
     * Write a program that reads two arrays of integers and sums them.
     * You can check this code here:
     * https://judge.softuni.bg/Contests/Practice/Index/172#6
     */
    class SumArrays
    {
        static void Main()
        {
            List<int> arr1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> arr2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            int biggerList = Math.Max(arr1.Count, arr2.Count);
            int[] result = new int[biggerList];
            for (int i = 0; i < biggerList; i++)
            {
                result[i] = arr1[i % arr1.Count] + arr2[i % arr2.Count];
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
