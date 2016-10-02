using System;
using System.Linq;

namespace _01.LargestCommonEnd
{
    /* 
     * Read two arrays of words and find the length of the largest common end (left or right).
     * You can check this code here:
     * https://judge.softuni.bg/Contests/Practice/Index/207#0
     */
    class LargestCommonEnd
    {
        static void Main()
        {
            var first = Console.ReadLine().Split().ToArray();
            var second = Console.ReadLine().Split().ToArray();

            var leftToRight = 0;

            for (int i = 0; i < first.Length && i < second.Length; i++)
            {
                if (first[i] == second[i])
                {
                    leftToRight++;
                }
            }

            int diff = 0;
            int rightToLeft = 0;
            while (first.Length > diff && second.Length > diff)
            {
                if (first[first.Length-1-diff] == second[second.Length-1-diff])
                {
                    rightToLeft++;
                }
                diff++;
            }

            Console.WriteLine(leftToRight > rightToLeft ? leftToRight : rightToLeft);
        }
    }
}
