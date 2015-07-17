using System;
using System.Collections.Generic;
using System.Numerics;

class FibNumMethod
{
    //Define a method Fib(n) that calculates the nth Fibonacci number. 
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Fib(n));
    }

    private static BigInteger Fib(int n)
    {
        List<BigInteger> fibonacci =new List<BigInteger>();
        fibonacci.Add(1);
        fibonacci.Add(1);
        if (n<2)
        {
            return fibonacci[n];
        }
        else
        {
            for (int i = 2; i <= n; i++)
            {
                fibonacci.Add(fibonacci[i-2]+fibonacci[i-1]);
            }
            return fibonacci[n];
        }
        
    }
}
