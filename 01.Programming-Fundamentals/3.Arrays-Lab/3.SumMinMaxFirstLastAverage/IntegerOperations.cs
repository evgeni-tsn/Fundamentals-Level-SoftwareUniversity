using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.SumMinMaxFirstLastAverage
{
    /* 
     * Write a program to read n integers and print their sum, min, max, first, last and average values.
     * You can check this code here:
     * https://judge.softuni.bg/Contests/Practice/Index/172#2
     */
    class IntegerOperations
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<int> ints = new List<int>();
            for (int i = 0; i < n; i++)
            {
                ints.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("Sum = " + ints.Sum());
            Console.WriteLine("Min = " + ints.Min());
            Console.WriteLine("Max = " + ints.Max());
            Console.WriteLine("First = " + ints.First());
            Console.WriteLine("Last = " + ints.Last());
            Console.WriteLine("Average = " + ints.Average());
        }
    }
}
