using System;
class CatalanNums
{
    //In combinatorics, the Catalan numbers are calculated by the following formula:

    //Write a program to calculate the nth Catalan number by given n(1 < n< 100). Examples:

    static void Main()
    {
        double n = double.Parse(Console.ReadLine());

        double factDevision = 1;
        double factN1 = 1;
        double factN = 1;

        for (int i = 1; i <= 2 * n; i++)
        {
            factDevision *= i;

            if (i <= n + 1)
            {
                factN1 *= i;
            }

            if (i <= n)
            {
                factN *= i;
            }
        }

        double sum = factDevision / (factN1 * factN);

        Console.WriteLine(sum);
    }
}
