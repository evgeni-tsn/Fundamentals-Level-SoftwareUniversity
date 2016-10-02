using System;
using System.Collections.Generic;
using System.Linq;

namespace _8.CondenseArrayNumber
{
    /* 
     * Write a program to read an array of integers and condense them by summing adjacent couples of elements until a single integer is obtained.
     * You can check this code here:
     * https://judge.softuni.bg/Contests/Practice/Index/172#7
     */
    class CondenseArray
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (input.Count >= 2)
            {
                int[] tempArr = new int[input.Count - 1];

                for (int i = 0; i < tempArr.Length; i++)
                {
                    tempArr[i] = input[i] + input[i + 1];
                }
                input = tempArr.ToList();
            }
            Console.WriteLine(input[0]);
        }
    }
}
