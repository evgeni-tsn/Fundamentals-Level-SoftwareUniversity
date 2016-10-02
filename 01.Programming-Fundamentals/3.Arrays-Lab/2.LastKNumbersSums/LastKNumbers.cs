using System;
using System.Collections.Generic;

namespace _2.LastKNumbersSums
{
    /* 
     * Enter two integers n and k. Generate and print the following sequence:
        •	The first element is: 1
        •	All other elements = sum of the previous k elements
        •	Example: n = 9, k = 5  120 = 4 + 8 + 16 + 31 + 61
     * You can check this code here:
     * https://judge.softuni.bg/Contests/Practice/Index/172#1
     */
    class LastKNumbers
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            long k = long.Parse(Console.ReadLine());
            List<long> resultList = new List<long>();
            resultList.Add(1);
            for (long currentPosition = 1; currentPosition < n; currentPosition++)
            {
                long start = Math.Max(0, currentPosition - k);
                long end = currentPosition - 1;
                long sum = 0;

                for (long backIndex = start; backIndex <= end; backIndex++)
                {
                    sum += resultList[(int) backIndex];
                }
                resultList.Add(sum);
            }

            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}
