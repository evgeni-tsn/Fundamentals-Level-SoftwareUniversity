using System;
using System.Runtime.InteropServices;

class BitsExchange
{
    //Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());

        uint firstBits = (n >> 3) & 7;
        uint secondBits = (n >> 24) & 7;
        uint maskFirstBits = 7 << 3;
        uint maskSecondBits = 7 << 24;

        n = n & ~maskFirstBits | (secondBits << 3);
        n = n & ~maskSecondBits | (firstBits << 24);

        Console.WriteLine(n);

    }
}
