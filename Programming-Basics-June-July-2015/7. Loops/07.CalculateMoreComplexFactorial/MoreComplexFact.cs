using System;
class MoreComplexFact
{
    //In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula:

    //For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k(1 < k<n< 100). Try to use only two loops.

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        double factorialN = 1;
        double factorialK = 1;
        double factorialNK = 1;

        for (int count = 1; count <= n; count++)
        {
            if (count <= k)
            {
                factorialK *= count;
            }
            factorialN *= count;
        }
        for (int count =1 ; count <= n-k; count++)
        {
            factorialNK *= count;
        }

        Console.WriteLine(factorialN / (factorialK*factorialNK));
    }
}