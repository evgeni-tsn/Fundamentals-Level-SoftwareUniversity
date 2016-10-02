using System;
using System.Numerics;

namespace _03.BigFactorial
{
    /* 
     * Calculate n! (n factorial) for very big n (e.g. 1000)
     * You can check your solutions here: 
     * https://judge.softuni.bg/Contests/175/Objects-and-Classes-Lab
     */
    class BigFactorial
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            Console.WriteLine(result);
        }
    }
}
