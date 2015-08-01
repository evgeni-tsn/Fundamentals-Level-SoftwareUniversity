using System;
class Calc2Fact
{
    //Write a program that calculates n! / k! for given n and k (1 < k < n < 100). Use only one loop. 
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        double factorialN = 1;
        double factorialK = 1;
        for (int count = 1; count <= n; count++)
        {
            if (count <= k)
            {
                factorialK *= count;
            }
            factorialN *= count;
        }
        Console.WriteLine(factorialN / factorialK);

    }
}