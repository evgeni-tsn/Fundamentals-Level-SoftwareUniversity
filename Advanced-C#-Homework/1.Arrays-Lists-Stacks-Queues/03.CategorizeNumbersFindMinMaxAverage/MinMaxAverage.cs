using System;
using System.Collections.Generic;
using System.Linq;

class MinMaxAverage
{
    //Write a program that reads N floating-point numbers from the console.
    //Your task is to separate them in two sets, one containing only the round 
    //numbers(e.g. 1, 1.00, etc.) and the other containing the floating-point numberswith non-zero fraction.
    //Print both arrays along with their minimum, maximum, sum and average (rounded to two decimal places).
    static void Main()
    {
        double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();
        double eps = 1e-14;

        List<double> doubleList = new List<double>();
        List<int> intList = new List<int>();

        foreach (var item in input)
        {
            if (Math.Abs(item-(int)item)<=eps)
            {
                intList.Add((int)item);
            }
            else
            {
                doubleList.Add(item);
            }
        }

        Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:F2}", 
                string.Join(", ", doubleList), doubleList.Min(),doubleList.Max(), 
                                        doubleList.Sum(), doubleList.Average());
        Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:F2}",
                string.Join(", ", intList), intList.Min(),intList.Max(), 
                                        intList.Sum(), intList.Average());
        
    }
}