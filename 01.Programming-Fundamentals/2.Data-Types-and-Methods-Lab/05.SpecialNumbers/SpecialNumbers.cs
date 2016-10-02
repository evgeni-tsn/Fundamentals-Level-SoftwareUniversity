using System;
using System.Linq;

namespace _05.SpecialNumbers
{
    class SpecialNumbers
    {
        /* You can check this code here:
        * https://judge.softuni.bg/Contests/Practice/Index/171#4
        */

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int currentSum;

            for (int number = 1; number <= n; number++)
            {
                currentSum = number.ToString().Sum(c => c - '0');
                Console.WriteLine($"{number} -> " + (currentSum == 5 || currentSum == 7 || currentSum == 11 ? "True" : "False"));
                currentSum = 0;
            }
        }
    }
}
