using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.Pairs
{
    /* 
    * Write a program that count the number of pairs in given array which difference 
    * is equal to given number. 
    * On the first line you will receive the sequence of numbers. 
    * On the second line – the difference.
    * You can check this code here:
    * https://judge.softuni.bg/Contests/Practice/Index/207#9
    */
    class Pairs
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().Select(long.Parse).ToList();
            var neededNumber = Console.ReadLine().Split().Select(long.Parse).ToList();
            var result = new List<long>();
            int counter = 0;

            foreach (var number in neededNumber)
            {
                for (int i = 0; i < input.Count; i++)
                {
                    for (int j = i + 1; j < input.Count; j++)
                    {
                        if (Math.Abs(input[i] - input[j]) == number)
                        {
                            counter++;
                        }
                    }
                }
                result.Add(counter);
                counter = 0;
            }
            Console.WriteLine(result.Max());
        }
    }
}
