using System;
using System.Linq;

namespace _11.EqualSums
{
    /* 
   * Write a program that determines if there exists an element in the 
   * array such that the sum of the elements on its left is equal to the
   * sum of the elements on its right. If there are no elements to the 
   * left/right, then the sum is considered to be zero. Print the index 
   * that satisfies the required condition or “no” if there is no such index.
   * You can check this code here:
   * https://judge.softuni.bg/Contests/Practice/Index/207#10
   */

    class EqualSum
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();

            bool trigger = false;
            var leftSum = 0;
            var rightSum = 0;
            for (int i = 0; i < input.Count; i++)
            {
                for (int leftIndex = i - 1; leftIndex >= 0; leftIndex--)
                {
                    leftSum += input[leftIndex];
                }
                for (int rightIndex = i + 1; rightIndex < input.Count; rightIndex++)
                {
                    rightSum += input[rightIndex];
                }

                if (leftSum == rightSum)
                {
                    trigger = true;
                    Console.WriteLine(i);
                }
                leftSum = 0;
                rightSum = 0;
            }
            if (!trigger)
            {
                Console.WriteLine("no");
            }
        }
    }
}
