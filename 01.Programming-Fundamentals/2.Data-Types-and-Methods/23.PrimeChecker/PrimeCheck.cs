using System;
namespace _23.PrimeChecker
{
    /* 
    * Write a Boolean method IsPrime(n) that check whether a given integer number n is prime. 
    * You can check this code here:
    * https://judge.softuni.bg/Contests/Practice/Index/206#22
    */
    class PrimeCheck
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());

            Console.WriteLine(PrimeChecker(n));
        }

        static bool PrimeChecker(long n)
        {
            if (n == 0)
            {
                return false;
            }
            if (n == 1)
            {
                return false;
            }
            if (n == 2)
            {
                return true;
            }

            for (int i = 2; i <= Math.Ceiling(Math.Sqrt(n)); ++i)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}