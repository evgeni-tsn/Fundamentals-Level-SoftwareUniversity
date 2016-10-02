using System;
using System.Linq;

namespace _08.Largest3Numbers
{
    /*
     * Read a list of real numbers and print largest 3 of them
     * You can check your solutions here: 
     * https://judge.softuni.bg/Contests/174/Strings-Dictionaries-Lambda-and-LINQ-Lab
     */
    class Largest3Numbers
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().Select(decimal.Parse).ToList();
            input.Sort();
            input.Reverse();
            if (input.Count == 2)
            {
                Console.WriteLine("{0} {1}", input[0], input[1]);
            }
            else if (input.Count == 1)
            {
                Console.WriteLine("{0}", input[0]);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", input[0], input[1], input[2]);
            }
        }
    }
}
