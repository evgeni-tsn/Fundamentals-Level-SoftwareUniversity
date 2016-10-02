using System;

namespace _04.PrimeNumbers
{
    /* 
     * Read an array of 4*k integers, fold it like shown below, 
     * and print the sum of the upper and lower rows (2 * k integers)
     * You can check this code here:
     * https://judge.softuni.bg/Contests/Practice/Index/207#3
     */

    class PrimeNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            bool[] primes = new bool[n + 1];

            primes[0] = primes[1] = false;

            for (int i = 2; i <= n; i++)
            {
                primes[i] = true;
            }

            for (int i = 2; i <= n; i++)
            {
                if (primes[i])
                {
                    for (int j = i + i; j < primes.Length; j += i)
                    {
                        primes[j] = false;
                    }
                }
            }

            for (int i = 0; i < primes.Length; i++)
            {
                if (primes[i])
                {
                    Console.Write(i+" ");
                }
            }
        }
    }
}
