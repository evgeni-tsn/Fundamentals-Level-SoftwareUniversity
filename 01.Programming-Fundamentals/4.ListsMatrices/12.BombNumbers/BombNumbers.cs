using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.BombNumbers
{
    /*
     * Write a program that reads sequence of numbers and special bomb number with a certain power.
     * Your task is to detonate every occurrence of the special bomb number and according to 
     * its power his neighbors from left and right. 
     * Finally print the sum of the remaining elements of the sequence.
     * You can check your solutions here: 
     * https://judge.softuni.bg/Contests/208/Lists-and-Matrices-Exercises
     */
    class BombNumbers
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var bomb = data[0];
            var damage = data[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bomb)
                {
                    for (int right = i + 1; right < i + 1 + damage; right++)
                    {
                        if (right < numbers.Count)
                        {
                            numbers[right] = 0;
                        }
                    }
                    for (int left = i - 1; left >= i - damage; left--)
                    {
                        if (left >= 0)
                        {
                            numbers[left] = 0;
                        }
                    }
                    numbers[i] = 0;
                }
            }
            numbers.RemoveAll(e => e == 0);
            Console.WriteLine(numbers.Sum());
            //            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
