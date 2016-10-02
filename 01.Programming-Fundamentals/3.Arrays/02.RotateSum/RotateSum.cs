using System;
using System.Linq;

namespace _02.RotateSum
{
    /* 
     * Read an array of n integers and an integer k. Rotate the array right k times and 
     * sum the obtained arrays as shown below:
     * You can check this code here:
     * https://judge.softuni.bg/Contests/Practice/Index/207#1
     */
    class RotateSum
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());
            int[] sumResult = new int[input.Length];

            for (int i = 0; i < k; i++)
            {
                int lastElement = input[input.Length - 1];

                for (int j = input.Length - 1; j > 0; j--)
                {
                    input[j] = input[j - 1];
                }
                input[0] = lastElement;

                for (int w = 0; w < input.Length; w++)
                {
                    sumResult[w] += input[w];
                }
            }
            Console.WriteLine(string.Join(" ", sumResult));
        }
    }
}
