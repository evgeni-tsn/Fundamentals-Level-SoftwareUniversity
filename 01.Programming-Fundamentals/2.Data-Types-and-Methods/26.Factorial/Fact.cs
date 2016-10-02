using System;
using System.Numerics;

namespace _26.Factorial
{
    /* 
    * Write a program that calculates and prints the n! for any n in the range [1…100].
    * You can check this code here:
    * https://judge.softuni.bg/Contests/Practice/Index/206#25
    */
    class Fact
    {
        static void Main()
        {
            BigInteger numberInt = BigInteger.Parse(Console.ReadLine());
            BigInteger result = numberInt;

            for (BigInteger i = 1; i < numberInt; i++)
            {
                result = result * i;
            }

            Console.WriteLine(result);
        }
    }
}
