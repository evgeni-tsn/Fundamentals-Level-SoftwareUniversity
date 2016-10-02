using System;
using System.Linq;

namespace _9.ExtractMiddleElements
{
    /* 
     * Write a method to extract the middle 1, 2 or 3 elements from array of n integers and print them.
        •	n = 1 -> 1 element
        •	even n -> 2 elements
        •	odd n -> 3 elements
     * You can check this code here:
     * https://judge.softuni.bg/Contests/Practice/Index/172#8
     */
    class ExtractMiddleElements
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if (input.Length == 1)
            {

            }
            else if (input.Length % 2 == 0)
            {
                Console.WriteLine("{0}, {1}", input[input.Length/2-1], input[input.Length / 2]);
            }
            else
            {
                Console.WriteLine("{0}, {1}, {2}", input[input.Length / 2 - 1], input[input.Length / 2], input[input.Length / 2 + 1]);
            }
        }
    }
}
