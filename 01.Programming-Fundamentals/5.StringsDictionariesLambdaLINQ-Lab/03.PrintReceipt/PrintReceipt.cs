using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PrintReceipt
{
    /*
     * Read a sequence of numbers and print a receipt of width 24 chars
     * You can check your solutions here: 
     * https://judge.softuni.bg/Contests/174/Strings-Dictionaries-Lambda-and-LINQ-Lab
     */
    class PrintReceipt
    {
        static void Main()
        {
            List<double> input = Console.ReadLine().Split().Select(double.Parse).ToList();

            Console.WriteLine("/----------------------\\");
            for (int i = 0; i < input.Count; i++)
            {
                Console.WriteLine("|{0,21:F2} |", input[i]);
            }
            Console.WriteLine("|----------------------|");
            Console.WriteLine("| Total:{0,14:F2} |", input.Sum());
            Console.WriteLine("\\----------------------/");

            /*
             /----------------------\
            |                12.50 |
            |                 7.00 |
            |                 0.50 |
            |----------------------|
            | Total:         20.00 |
            \----------------------/

            */
        }
    }
}
