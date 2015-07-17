using System;
class CalcGCD
{
    //Write a program that calculates the greatest common divisor(GCD) of given two integers a and b.Use the Euclidean algorithm(find it in Internet). 
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int remain = a % b;
        while (remain != 0)
        {
            a = b;
            b = remain;
            remain = a % b;
        }
        Console.WriteLine(Math.Abs(b));
    }
}
