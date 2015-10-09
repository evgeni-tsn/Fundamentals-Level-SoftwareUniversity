using System;
using System.Numerics;

class fibonacciNumbers
{
    static void Main()
    {
        BigInteger a = 0, b = 1, c = 0;
        Console.Write("{0} {1}", a, b);

        for (int i = 2; i < 100; i++)
        {
            c = a + b;
            Console.Write(" {0}", c);
            a = b;
            b = c;
        }
        Console.WriteLine();
    }
}
